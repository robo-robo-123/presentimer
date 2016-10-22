using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace CDTimer
{
  /// <summary>
  /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
  /// </summary>
  public sealed partial class CountPage : Page
  {
    public ViewModel.SettingViewModel ViewModel { get; } = new ViewModel.SettingViewModel();
    Common.CommonClass conv = new Common.CommonClass();

    public CountPage()
    {
      this.InitializeComponent();

      /*
      // コンポーネントの状態を初期化　
      timeBlock.Text = "00:00";

      // タイマーのインスタンスを生成
      dispatcherTimer = new DispatcherTimer();
      dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
      dispatcherTimer.Tick += dispatcherTimer_Tick;
      */

      Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
      Windows.Graphics.Display.DisplayInformation.AutoRotationPreferences = Windows.Graphics.Display.DisplayOrientations.Landscape;

      /*
      // タイマー開始
      time = 0;
      TimerStart();
      dispatcherTimer.Start();
      */

      ViewModel.TimerReset();
      ViewModel.MainTimerStart();

    }

    private void OnNavigatedTo(object sender, NavigationEventArgs e)
    {
      DisplayInformation.AutoRotationPreferences = DisplayOrientations.Landscape;
    }


    private void stopButton_Click(object sender, RoutedEventArgs e)
    {
      ViewModel.TimerStop();
      Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().ExitFullScreenMode();
      Frame.GoBack();
    }

    private void resetButton_Click(object sender, RoutedEventArgs e)
    {
      ViewModel.TimerStop();
      ViewModel.TimerReset();
      pauseButton.Visibility = Visibility.Collapsed;
      startButton.Visibility = Visibility.Visible;
    }

    private void startButton_Click(object sender, RoutedEventArgs e)
    {
      ViewModel.MainTimerStart();
      startButton.Visibility = Visibility.Collapsed;
      pauseButton.Visibility = Visibility.Visible;
    }

    private void pauseButton_Click(object sender, RoutedEventArgs e)
    {
      ViewModel.TimerStop();
      pauseButton.Visibility = Visibility.Collapsed;
      startButton.Visibility = Visibility.Visible;
    }


    private void Button_Click(object sender, RoutedEventArgs e)
    {
      Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().ExitFullScreenMode();
      backToWindowsButton.Visibility = Visibility.Collapsed;
      fullScreenButton.Visibility = Visibility.Visible;
    }

    private void fullScreenButton_Click(object sender, RoutedEventArgs e)
    {
      Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
      fullScreenButton.Visibility = Visibility.Collapsed;
      backToWindowsButton.Visibility = Visibility.Visible;
    }


    /*
private void TimerStart()
{

  TimeSpan ts = new TimeSpan(0, (int)ViewModel.TimesIndex, 0);
  _count = (int)ts.TotalSeconds;
  timeBlock.Text = ts.ToString();
  int index = ViewModel.ColorsIndex;
  var color = conv.selectColor(index);
  timeBlock.Foreground = color;
  infoBlock.Foreground = color;
  infoBlock.Text = ViewModel.FirstTitle;

}

private void SecondTime()
{

  TimeSpan ts2 = new TimeSpan(0, (int)ViewModel.TimesIndex2, 0);
  _count = (int)ts2.TotalSeconds;
  if (_count == 0)
  {
    time++;
    ThirdTime();
  }
  else
  {
    time++;
    int index = ViewModel.ColorsIndex2;
    var color = conv.selectColor(index);
    timeBlock.Foreground = color;
    infoBlock.Foreground = color;
    infoBlock.Text = ViewModel.SecondTitle;
  }

}

private void ThirdTime()
{
  time++;
  _count = 0;
  int index = ViewModel.ColorsIndex3;
  var color = conv.selectColor(index);
  timeBlock.Foreground = color;
  infoBlock.Foreground = color;
  infoBlock.Text = ViewModel.ThirdTitle;
}

private void dispatcherTimer_Tick(object sender, object e)
{
  if (time == 0)
  {
    this._count--;
    TimeSpan ts = new TimeSpan(0, 0, _count);
    timeBlock.Text = ts.ToString();
    //if (_count == int.Parse(ViewModel.PreBellMinutesValue) * 60)
    if(_count == (ViewModel.PreBellMinutesIndex)*60 && ViewModel.PreBellMinutesIndex != 0)
    //if(_count == (ViewModel.PreBellMinutesIndex) *60)
      {
        playsound(int.Parse(ViewModel.PreBellValue));
    }
    if (_count == 0)
    {
      playsound(ViewModel.EndBellIndex + 1);
      SecondTime();
    }
  }
  else if(time ==1)
  {
    this._count--;
    TimeSpan ts = new TimeSpan(0, 0, _count);
    timeBlock.Text = ts.ToString();
    if (_count == 0)
    {
      playsound(ViewModel.EndBellIndex2 + 1);
      ThirdTime();
    }
  }
  else if(time ==2)
  {
    this._count++;
    TimeSpan ts = new TimeSpan(0, 0, _count);
    timeBlock.Text = ts.ToString();
  }
}

private async void playsound(int index)
{

  if (index == 1)
  {
    this.SoundGoo.Play();
    await Task.Delay(300);
  }
  else if (index == 2)
  {
    this.SoundGoo2.Play();
    await Task.Delay(300);
    this.SoundGoo2.Stop();

    this.SoundGoo.Play();
    await Task.Delay(300);
  }
  else if (index == 3)
  {
    this.SoundGoo.Play();
    await Task.Delay(300);
    this.SoundGoo.Stop();

    this.SoundGoo2.Play();
    await Task.Delay(300);
    this.SoundGoo2.Stop();

    this.SoundGoo.Play();
    await Task.Delay(300);
  }
  else if (index == 4)
  {
    this.SoundGoo2.Play();
    await Task.Delay(300);
    this.SoundGoo2.Stop();

    this.SoundGoo.Play();
    await Task.Delay(300);
    this.SoundGoo.Stop();

    this.SoundGoo2.Play();
    await Task.Delay(300);
    this.SoundGoo2.Stop();

    this.SoundGoo.Play();
    await Task.Delay(300);
  }
  else if (index == 5)
  {
    this.SoundGoo.Play();
    await Task.Delay(300);
    this.SoundGoo.Stop();

    this.SoundGoo2.Play();
    await Task.Delay(300);
    this.SoundGoo2.Stop();

    this.SoundGoo.Play();
    await Task.Delay(300);
    this.SoundGoo.Stop();

    this.SoundGoo2.Play();
    await Task.Delay(300);
    this.SoundGoo2.Stop();

    this.SoundGoo.Play();
    await Task.Delay(300);
  }
}
*/

  }
}
