using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.System;
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
  public sealed partial class SettingPage : Page
  {
    public ViewModel.SettingViewModel ViewModel { get; } = new ViewModel.SettingViewModel();


    //DispatcherTimer dispatcherTimer;    // タイマーオブジェクト
    //DateTime StartTime;                 // カウント開始時刻

    Common.CommonClass conv = new Common.CommonClass();
    //private int _count;
    //private int time;

    public SettingPage()
    {
      this.InitializeComponent();

      // コンポーネントの状態を初期化　
      //lblTime.Text = "00:00:00";
      btnStart.IsEnabled = true;
      btnStop.IsEnabled = false;
      btnReset.IsEnabled = true;

      /*
      // タイマーのインスタンスを生成
      dispatcherTimer = new DispatcherTimer();
      dispatcherTimer.Interval = TimeSpan.FromMilliseconds(100);
      dispatcherTimer.Tick += dispatcherTimer_Tick;
      */
      DisplayInformation.AutoRotationPreferences = DisplayOrientations.Portrait;

      TimeSpan ts;
      ts = new TimeSpan(0, (int)ViewModel.TimesIndex, 0);
      testTime.Time = ts;
      ts = new TimeSpan(0, (int)ViewModel.TimesIndex2, 0);
      secondTime.Time = ts;


      //一番最初の初期化
      //default設定
      ViewModel.FirstTitle = firstText.Text;
      ViewModel.SecondTitle = secondText.Text;
      ViewModel.ThirdTitle = thirdText.Text;
      //this.ViewModel.PropertyChanged += ViewModel_PropertyChanged;

      if (ViewModel.PreBellValue == null)
        prebellMinutesCombo1.SelectedIndex = 0;

      this.ViewModel.TimerReset();

    }

    private void OnNavigatedTo(object sender, NavigationEventArgs e)
    {
      DisplayInformation.AutoRotationPreferences = DisplayOrientations.Portrait;
    }

    /// <summary>
    /// App bar
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void start_Click(object sender, RoutedEventArgs e)
    {
      this.Frame.Navigate(typeof(CountPage));
    }

    private void infoButton_Click(object sender, RoutedEventArgs e)
    {
      this.Frame.Navigate(typeof(InfoPage));
    }



    // ボタンクリック時の処理分岐
    private void Button_Click(object sender, RoutedEventArgs e)
    {
      var ctrl = (Button)sender;
      switch (ctrl.Name)
      {
        case "btnStart":
          TimerStart();
          break;

        case "btnStop":
          TimerStop();
          break;

        case "btnReset":
          //TimerReset();
          ViewModel.TimerReset();
          break;

      }
    }

    // タイマー操作：開始
    private void TimerStart()
    {
      btnStart.IsEnabled = false;
      btnStop.IsEnabled = true;
      btnReset.IsEnabled = false;
      //StartTime = DateTime.Now;
      //dispatcherTimer.Start();
      ViewModel.TimerStart();
    }

    // タイマー操作：停止
    private void TimerStop()
    {
      btnStart.IsEnabled = true;
      btnStop.IsEnabled = false;
      btnReset.IsEnabled = true;
      //dispatcherTimer.Stop();
      ViewModel.TimerStop();
    }

    /// <summary>
    /// 時間の設定項目
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void testTime_TimeChanged(object sender, TimePickerValueChangedEventArgs e)
    {
            /*
      if (((TimePicker)sender).Name == "testTime")
        ViewModel.TimesIndex = ((TimePicker)sender).Time.TotalMinutes;
      else if (((TimePicker)sender).Name == "secondTime")
        ViewModel.TimesIndex2 = ((TimePicker)sender).Time.TotalMinutes;
        */
    }

    private void titleText_KeyDown(object sender, KeyRoutedEventArgs e)
    {
      if (e.Key == VirtualKey.Enter)
      {
        if (((TextBox)sender).Name == "firstText")
          ViewModel.FirstTitle = ((TextBox)sender).Text;
        else if (((TextBox)sender).Name == "secondText")
          ViewModel.SecondTitle = ((TextBox)sender).Text;
        else if (((TextBox)sender).Name == "thirdText")
          ViewModel.ThirdTitle = ((TextBox)sender).Text;
        e.Handled = true;
      }
    }

    private void CheckBox_Checked(object sender, RoutedEventArgs e)
    {
      prebellCombo1.IsEnabled = true;
      prebellMinutesCombo1.IsEnabled = true;
    }

    private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
    {
      prebellCombo1.IsEnabled = false;
      prebellMinutesCombo1.IsEnabled = false;
    }

    private void prebellMinutesCombo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      if (((ComboBox)sender).SelectedIndex == 0)
      {
        prebellCombo1.IsEnabled = false;
        prebellCombo1.SelectedIndex = 0;
      }
      else
      {
        prebellCombo1.IsEnabled = true;
      }
    }


    /// <summary>
    /// pivot（将来的に）
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void mainPivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      //horTime.Text = mainPivot.SelectedIndex.ToString();
    }

    private void mainPivot_PivotItemLoaded(Pivot sender, PivotItemEventArgs args)
    {


    }



    /// <summary>
    /// not use
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// 
    /*
    private void saveAllButton_Click(object sender, RoutedEventArgs e)
    {
      ViewModel.ColorsIndex = colorCombo.SelectedIndex;

      lblTime.Text = this.testTime.Time.ToString();
      ViewModel.MinutesIndex = this.testTime.Time.Minutes;
      ViewModel.HoursIndex = this.testTime.Time.Hours;
      ViewModel.TimesIndex = this.testTime.Time.TotalMinutes;
    }
    */

    ///使ってない
    private void colorCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private void bellCombo_end1_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private void prebellCombo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
    }


    /// <summary>
    /// 時間の処理
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>


  }
}
