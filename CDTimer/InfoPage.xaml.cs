using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
  public sealed partial class InfoPage : Page
  {
    public InfoPage()
    {
      this.InitializeComponent();
    }

    protected override async void OnNavigatedTo(NavigationEventArgs e)
    {
      base.OnNavigatedTo(e);

      Windows.UI.Core.SystemNavigationManager.GetForCurrentView()
 .AppViewBackButtonVisibility
 = Frame.CanGoBack
 ? Windows.UI.Core.AppViewBackButtonVisibility.Visible
 : Windows.UI.Core.AppViewBackButtonVisibility.Collapsed;

      // システムの［戻る］ボタンに対応するイベントハンドラーを結び付ける
      Windows.UI.Core.SystemNavigationManager.GetForCurrentView()
 .BackRequested += MainPage_BackRequested;
    }

    protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
    {
      base.OnNavigatingFrom(e);

  // システムの［戻る］ボタンに対応するイベントハンドラーを解除する
  Windows.UI.Core.SystemNavigationManager.GetForCurrentView()
 .BackRequested -= MainPage_BackRequested;
    }

    // システムの［戻る］ボタンが押された時のイベントハンドラー
    private void MainPage_BackRequested(object sender,
     Windows.UI.Core.BackRequestedEventArgs e)
    {
      if (Frame.CanGoBack)
      {
        Frame.GoBack();
        e.Handled = true;
      }
    }
  }
}
