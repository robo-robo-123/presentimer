using CDTimer.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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

    public MainPage()
    {
      this.InitializeComponent();

      List<Color> colors = new List<Color>();

      // Add some items to collection
      colors.Add( new Color( "Green", color = new SolidColorBrush(Windows.UI.Colors.Green) ) );
      colors.Add( new Color( "Yellow", color = new SolidColorBrush(Windows.UI.Colors.Yellow) ) );
      colors.Add( new Color( "Red", color = new SolidColorBrush(Windows.UI.Colors.Red) ) );
      colors.Add( new Color( "Blue", color = new SolidColorBrush(Windows.UI.Colors.Blue) ) );
      colors.Add( new Color( "Pink", color = new SolidColorBrush(Windows.UI.Colors.Pink) ) );

      //colorCombo2.ItemsSource = colors;
      ViewModel.StartTitle = startText.Text;
      ViewModel.FirstTitle = firstText.Text;
      ViewModel.SecondTitle = secondText.Text;
      ViewModel.ThirdTitle = thirdText.Text;

      ViewModel.TimerReset();
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
