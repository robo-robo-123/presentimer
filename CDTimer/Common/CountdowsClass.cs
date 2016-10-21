using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace CDTimer.Common
{
  class CountdowsClass
  {
    DispatcherTimer dispatcherTimer;    // タイマーオブジェクト
    private int _count;
    private int time;

    public CountdowsClass()
    {

      // タイマーのインスタンスを生成
      dispatcherTimer = new DispatcherTimer();
      dispatcherTimer.Interval = TimeSpan.FromMilliseconds(100);
      //dispatcherTimer.Tick += dispatcherTimer_Tick;


      //default設定
      //ViewModel.FirstTitle = firstText.Text;
      //ViewModel.SecondTitle = secondText.Text;
      //ViewModel.ThirdTitle = thirdText.Text;


    }

    /*
    private void dispatcherTimer_Tick(object sender, object e)
    {

      if (time == 0)
      {
        this._count--;
        TimeSpan ts = new TimeSpan(0, 0, _count);
        lblTime.Text = ts.ToString();
        if (_count == (ViewModel.PreBellMinutesIndex) * 60 && ViewModel.PreBellMinutesIndex != 0)
        {
          playsound(int.Parse(ViewModel.PreBellValue));
        }
        if (_count == 0)
        {
          playsound(ViewModel.EndBellIndex + 1);
          SecondTime();
        }

      }
      else if (time == 1)
      {
        this._count--;
        TimeSpan ts = new TimeSpan(0, 0, _count);
        lblTime.Text = ts.ToString();
        if (_count == 0)
        {
          playsound(ViewModel.EndBellIndex2 + 1);
          ThirdTime();
        }
      }
      else if (time == 2)
      {
        this._count++;
        TimeSpan ts = new TimeSpan(0, 0, _count);
        lblTime.Text = ts.ToString();
      }

    }
    */

  }
}
