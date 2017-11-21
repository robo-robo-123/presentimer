using CDTimer.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace CDTimer.View
{


  /// <summary>
  /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
  /// </summary>
  public sealed partial class MainPage : Page
  {
    public ViewModel.SettingViewModel ViewModel { get; } = new ViewModel.SettingViewModel();

    public SolidColorBrush color;

    //    public List<int>

    public MainPage()
    {
      this.InitializeComponent();

      /*
List<Color> colors = new List<Color>();

// Add some items to collection
colors.Add( new Color( "Green", color = new SolidColorBrush(Windows.UI.Colors.Green) ) );
colors.Add( new Color( "Yellow", color = new SolidColorBrush(Windows.UI.Colors.Yellow) ) );
colors.Add( new Color( "Red", color = new SolidColorBrush(Windows.UI.Colors.Red) ) );
colors.Add( new Color( "Blue", color = new SolidColorBrush(Windows.UI.Colors.Blue) ) );
colors.Add( new Color( "Pink", color = new SolidColorBrush(Windows.UI.Colors.Pink) ) );
*/


      for (int i = 0; i <= 60; i++)
      {
        timeFirst.Items.Add(i);
        timeSecond.Items.Add(i);
        timeThird.Items.Add(i);
      }

      for (int i = 0; i <= 5; i++)
      {
        bellFirst.Items.Add(i);
        bellSecond.Items.Add(i);
        bellThird.Items.Add(i);
      }

      //if(記録されている値がない場合
      bellFirst.SelectedIndex = 0;
      bellSecond.SelectedIndex = 0;
      bellThird.SelectedIndex = 0;

      timeFirst.SelectedIndex = 0;
      timeSecond.SelectedIndex = 0;
      timeThird.SelectedIndex = 0;
      //myColorPicker0.Color = Colors.Green;
      //myColorPicker1.Color = Colors.Green;
      //myColorPicker2.Color = Colors.Yellow;
      //myColorPicker3.Color = Colors.Red;

      //if(ViewModel.LabelColor2 == null)
      //{

      //値が格納されていない場合の処理とする必要がある。
      if(ViewModel.LabelColor0.ToString() == "#00000000")
      {
        myColorPicker0.Color = Colors.Green;
        ViewModel.LabelColor0 = myColorPicker0.Color;
      }
      if (ViewModel.LabelColor1.ToString() == "#00000000")
      {
        myColorPicker0.Color = Colors.Green;
        ViewModel.LabelColor1 = myColorPicker0.Color;
      }
      if (ViewModel.LabelColor2.ToString() == "#00000000")
      {
        myColorPicker2.Color = Colors.Yellow;
        ViewModel.LabelColor2 = myColorPicker0.Color;
      }
      if (ViewModel.LabelColor3.ToString() == "#00000000")
      {
        myColorPicker3.Color = Colors.Red;
        ViewModel.LabelColor3 = myColorPicker0.Color;
      }
      //ViewModel.LabelColor1 = myColorPicker1.Color;
      //ViewModel.LabelColor2 = myColorPicker2.Color;
      //ViewModel.LabelColor3 = myColorPicker3.Color;
      //}


      //colorCombo2.ItemsSource = colors;

      
      //ViewModel.StartTitle = startText.Text;
      //ViewModel.FirstTitle = firstText.Text;
      //ViewModel.SecondTitle = secondText.Text;
      //ViewModel.ThirdTitle = thirdText.Text;

      ViewModel.TimerReset();


      if (ApplicationView.GetForCurrentView().IsViewModeSupported(ApplicationViewMode.CompactOverlay))
      {
        pinpButton.Visibility = Visibility.Visible;
      }

      var appView = ApplicationView.GetForCurrentView();
      // タイトルバーにもUIを展開表示するための設定（これは必須ではありませんが、見た目的には必要）
      CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
      appView.TitleBar.ButtonBackgroundColor = Colors.Transparent;
      appView.TitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;

    }


    /// <summary>
    /// count up screen
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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


    private void backToWindowsButton_Click(object sender, RoutedEventArgs e)
    {
      Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().ExitFullScreenMode();
      backToWindowsButton.Visibility = Visibility.Collapsed;
      fullScreenButton.Visibility = Visibility.Visible;

      pinpButton.IsEnabled = true;

    }

    private void fullScreenButton_Click(object sender, RoutedEventArgs e)
    {
      Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
      fullScreenButton.Visibility = Visibility.Collapsed;
      backToWindowsButton.Visibility = Visibility.Visible;

      pinpButton.IsEnabled = false;
    }

    private void previewStart_Click(object sender, RoutedEventArgs e)
    {
      previewStart.IsEnabled = false;
      previewStop.IsEnabled = true;
      previewReset.IsEnabled = false;
      ViewModel.TimerStart();
    }

    private void previewStop_Click(object sender, RoutedEventArgs e)
    {
      previewStart.IsEnabled = true;
      previewStop.IsEnabled = false;
      previewReset.IsEnabled = true;
      ViewModel.TimerStop();
    }

    private void previewReset_Click(object sender, RoutedEventArgs e)
    {
      ViewModel.TimerReset();




    }


    /// <summary>
    /// picture in picture
    /// </summary>
    /// <returns></returns>
    private async void viewModeToggle_Click(object sender, RoutedEventArgs e)

    {

      viewModeToggle.IsEnabled = false;



      if (viewModeToggle.IsChecked ?? false)

        await EnterTopMostAsync();

      else

        await ExitTopMostAsync();



      viewModeToggle.IsEnabled = true;

    }



    private async Task EnterTopMostAsync()

    {

      //var previousSize = LocalSettings.CompactOverlaySize;

      //await ViewMode.EnterCompactOverlayAsync(previousSize);

    }



    private async Task ExitTopMostAsync()

    {

      // LocalSettings.CompactOverlaySize = this.PageSize;

      // await ViewMode.ExitCompactOverlayAsync();

    }


    /*
            public static async Task SwitchViewModeCompactOverayAsync(bool isCompactOverlay)
            {
                if (!ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 4))
                {
                    return;
                }

                var appView = ApplicationView.GetForCurrentView();
                if (appView.IsViewModeSupported(ApplicationViewMode.CompactOverlay))
                {
                    if (isCompactOverlay)
                    {
                        // PC等1080pであればデフォルトで最大サイズ（横500px 縦280px）で表示されるが
                        // タブレット等の小サイズ画面ではより小さい幅で表示されます
                        // そのため任意に表示サイズを指定してください
                        ViewModePreferences compactOptions = ViewModePreferences.CreateDefault(ApplicationViewMode.CompactOverlay);
                        compactOptions.CustomSize = new Windows.Foundation.Size(500, 280);

                        var result = await appView.TryEnterViewModeAsync(ApplicationViewMode.CompactOverlay, compactOptions);
                        if (result)
                        {
                            // タイトルバーにもUIを展開表示するための設定（これは必須ではありませんが、見た目的には必要）
                            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
                            appView.TitleBar.ButtonBackgroundColor = Colors.Transparent;
                            appView.TitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
                        }
                    }
                    else
                    {
                        var result = await appView.TryEnterViewModeAsync(ApplicationViewMode.Default);
                        if (result)
                        {
                            // タイトルバーを透過表示するための設定を元に戻す
                            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = false;
                            appView.TitleBar.ButtonBackgroundColor = null;
                            appView.TitleBar.ButtonInactiveBackgroundColor = null;
                        }
                    }
                }
            }
    */

    private async void pinpButton_Click(object sender, RoutedEventArgs e)
    {

      ViewModePreferences compactOptions = ViewModePreferences.CreateDefault(ApplicationViewMode.CompactOverlay);
      compactOptions.CustomSize = new Windows.Foundation.Size(500, 350);

      /*
      var result = await appView.TryEnterViewModeAsync(ApplicationViewMode.CompactOverlay, compactOptions);
      if (result)
      {

      }
      */

      bool modeSwitched = await ApplicationView.GetForCurrentView().TryEnterViewModeAsync(ApplicationViewMode.CompactOverlay, compactOptions);
      pinpButton.Visibility = Visibility.Collapsed;
      standardButton.Visibility = Visibility.Visible;

      fullScreenButton.IsEnabled = false;
    }

    private async void standard(object sender, RoutedEventArgs e)
    {
      /*
      var appView = ApplicationView.GetForCurrentView();
      // タイトルバーを透過表示するための設定を元に戻す
      CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = false;
      appView.TitleBar.ButtonBackgroundColor = null;
      appView.TitleBar.ButtonInactiveBackgroundColor = null;
      */

      bool modeSwitched = await ApplicationView.GetForCurrentView().TryEnterViewModeAsync(ApplicationViewMode.Default);
      standardButton.Visibility = Visibility.Collapsed;
      pinpButton.Visibility = Visibility.Visible;

      fullScreenButton.IsEnabled = true;

    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      Debug.WriteLine(e.ToString());
    }

    private void myColorPicker_ColorChanged(ColorPicker sender, ColorChangedEventArgs args)
    {
      //Debug.WriteLine(args.ToString());

      //ViewModel.LabelColor2 = sender.Color;
      //ViewModel.LabelBrush1 = new SolidColorBrush(sender.Color);
      //ViewModel.ColorLabel2 = ViewModel.GetBrush(sender.Color);

    }

    /*
    private async void compactOverlayButton_Click(object sender, RoutedEventArgs e)
    {
      bool modeSwitched = await ApplicationView.GetForCurrentView().TryEnterViewModeAsync(ApplicationViewMode.CompactOverlay);
    }

    private async void standardModeButton_Click(object sender, RoutedEventArgs e)
    {
      bool modeSwitched = await ApplicationView.GetForCurrentView().TryEnterViewModeAsync(ApplicationViewMode.Default);
    }
    */

  }
}
