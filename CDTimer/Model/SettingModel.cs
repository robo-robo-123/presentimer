﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CDTimer.Model
{
  public class SettingModel : Common.BindableBase
  {
    public static SettingModel Instance { get; } = new SettingModel();
    Common.CommonClass conv = new Common.CommonClass();
    DispatcherTimer dispatcherTimer;    // タイマーオブジェクト
    private int _count;
    private int time;

    private MediaElement element = new MediaElement();
    private MediaElement element2 = new MediaElement();

    public SettingModel()
    {

      // タイマーのインスタンスを生成
      dispatcherTimer = new DispatcherTimer();
      //dispatcherTimer.Interval = TimeSpan.FromMilliseconds(100);
      dispatcherTimer.Tick += dispatcherTimer_Tick;

      //初期化
      //TimeSpan ts;
      //this.TimeIndex = new TimeSpan(0, (int)this.TimesIndex, 0);
      //this.TimeIndex2 = new TimeSpan(0, (int)this.TimesIndex2, 0);

      //_count = 0;
      //dispatcherTimer.Start();
      //sound
      settingSound();


    }

    private async void settingSound()
    {
      var folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Source");
      var file = await folder.GetFileAsync("test.mp3");
      var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
      element.SetSource(stream, "");
      element2.SetSource(stream, "");
      //element.Play();
    }


    //first
    private string firstTitle;
    public string FirstTitle
    {
      get { return this.firstTitle; }
      set { this.SetProperty(ref this.firstTitle, value); }
    }

    private double timesIndex;
    public double TimesIndex
    {
      get { return this.timesIndex; }
      set { this.SetProperty(ref this.timesIndex, value); }
    }

    private int colorsIndex;
    public int ColorsIndex
    {
      get { return this.colorsIndex; }
      set { this.SetProperty(ref this.colorsIndex, value); }
    }



    private Int32 endBellIndex;
    public Int32 EndBellIndex
    {
      get { return this.endBellIndex; }
      set { this.SetProperty(ref this.endBellIndex, value); }
    }

    private Int32 preBellIndex;
    public Int32 PreBellIndex
    {
      get { return this.preBellIndex; }
      set { this.SetProperty(ref this.preBellIndex, value); }
    }

    private string preBellValue;
    public string PreBellValue
    {
      get { return this.preBellValue; }
      set { this.SetProperty(ref this.preBellValue, value); }
    }

    private Int32 preBellMinutesIndex;
    public Int32 PreBellMinutesIndex
    {
      get { return this.preBellMinutesIndex; }
      set { this.SetProperty(ref this.preBellMinutesIndex, value); }
    }

    private string preBellMinutesValue;
    public string PreBellMinutesValue
    {
      get { return this.preBellMinutesValue; }
      set { this.SetProperty(ref this.preBellMinutesValue, value); }
    }

    //second
    private string secondTitle;
    public string SecondTitle
    {
      get { return this.secondTitle; }
      set { this.SetProperty(ref this.secondTitle, value); }
    }

    private double timesIndex2;
    public double TimesIndex2
    {
      get { return this.timesIndex2; }
      set { this.SetProperty(ref this.timesIndex2, value); }
    }

    private int colorsIndex2;
    public int ColorsIndex2
    {
      get { return this.colorsIndex2; }
      set { this.SetProperty(ref this.colorsIndex2, value); }
    }

    private Int32 endBellIndex2;
    public Int32 EndBellIndex2
    {
      get { return this.endBellIndex2; }
      set { this.SetProperty(ref this.endBellIndex2, value); }
    }

    //third
    private string thirdTitle;
    public string ThirdTitle
    {
      get { return this.thirdTitle; }
      set { this.SetProperty(ref this.thirdTitle, value); }
    }

    private int colorsIndex3;
    public int ColorsIndex3
    {
      get { return this.colorsIndex3; }
      set { this.SetProperty(ref this.colorsIndex3, value); }
    }

    //common
    private string labelTime;
    public string LabelTime
    {
      get { return this.labelTime; }
      set { this.SetProperty(ref this.labelTime, value); }
    }

    private Windows.UI.Xaml.Media.Brush foregroundColor;
    public Windows.UI.Xaml.Media.Brush ForegroundColor
    {
      get { return foregroundColor; }
      set { this.SetProperty(ref this.foregroundColor, value); }
    }

    private string titleBlock;
    public string TitleBlock
    {
      get { return this.titleBlock; }
      set { this.SetProperty(ref this.titleBlock, value); }
    }

    //not_use
    private Int32 hoursIndex;
    public Int32 HoursIndex
    {
      get { return this.hoursIndex; }
      set { this.SetProperty(ref this.hoursIndex, value); }
    }
    private double minutesIndex;
    public double MinutesIndex
    {
      get { return this.minutesIndex; }
      set { this.SetProperty(ref this.minutesIndex, value); }
    }
    private double timesIndex3;
    public double TimesIndex3
    {
      get { return this.timesIndex3; }
      set { this.SetProperty(ref this.timesIndex3, value); }
    }
    private Int32 endBellIndex3;
    public Int32 EndBellIndex3
    {
      get { return this.endBellIndex3; }
      set { this.SetProperty(ref this.endBellIndex3, value); }
    }
    private string colorsInfo;
    public string ColorsInfo
    {
      get { return this.colorsInfo; }
      set { this.SetProperty(ref this.colorsInfo, value); }
    }
    public void foretest()
    {
      //int index = ViewModel.ColorsIndex2;
      var color = conv.selectColor(ColorsIndex);
      this.ForegroundColor = color;
    }


    //timecount
    public void TimerStart()
    {
      dispatcherTimer.Interval = TimeSpan.FromMilliseconds(100);
      dispatcherTimer.Start();
    }

    public void MainTimerStart()
    {
      dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
      dispatcherTimer.Start();
    }

    public void TimerStop()
    {
      dispatcherTimer.Stop();
    }

    public void TimerReset()
    {
      TimeSpan ts = new TimeSpan(0, (int)this.TimesIndex, 0);
      _count = (int)ts.TotalSeconds;
      this.LabelTime = ts.ToString();
      var color = conv.selectColor(ColorsIndex);
      this.ForegroundColor = color;
      this.TitleBlock = this.FirstTitle;
      time = 0;
    }

    private async void playsound(int index)
    {

      if (index == 1)
      {
        this.element.Play();
        await Task.Delay(300);
      }
      else if (index == 2)
      {
        this.element.Play();
        await Task.Delay(300);

        this.element2.Play();
        await Task.Delay(300);
      }
      else if (index == 3)
      {
        this.element.Play();
        await Task.Delay(300);
        this.element.Stop();

        this.element2.Play();
        await Task.Delay(300);

        this.element.Play();
        await Task.Delay(300);
      }
      else if (index == 4)
      {
        this.element.Play();
        await Task.Delay(300);
        this.element.Stop();

        this.element.Play();
        await Task.Delay(300);
        this.element.Stop();

        this.element.Play();
        await Task.Delay(300);
        this.element.Stop();

        this.element.Play();
        await Task.Delay(300);
      }
      else if (index == 5)
      {
        this.element.Play();
        await Task.Delay(300);
        this.element.Stop();

        this.element.Play();
        await Task.Delay(300);
        this.element.Stop();

        this.element.Play();
        await Task.Delay(300);
        this.element.Stop();

        this.element.Play();
        await Task.Delay(300);
        this.element.Stop();

        this.element.Play();
        await Task.Delay(300);
      }

    }

    private void dispatcherTimer_Tick(object sender, object e)
    {
      //this._count++;
      //TimeSpan ts = new TimeSpan(0, 0, _count);
      //this.MinutesIndex = ts.TotalSeconds;
      if (time == 0)
      {
        this._count--;
        TimeSpan ts = new TimeSpan(0, 0, _count);
        this.LabelTime = ts.ToString();
        if (_count == (this.PreBellMinutesIndex) * 60 && this.PreBellMinutesIndex != 0)
        {
          playsound(int.Parse(this.PreBellValue));
        }
        if (_count == 0)
        {
          playsound(this.EndBellIndex + 1);
          SecondTime();
        }
      }
      else if (time == 1)
      {
        this._count--;
        TimeSpan ts = new TimeSpan(0, 0, _count);
        this.LabelTime = ts.ToString();
        if (_count == 0)
        {
          playsound(this.EndBellIndex2 + 1);
          ThirdTime();
        }
      }
      else if (time == 2)
      {
        this._count++;
        TimeSpan ts = new TimeSpan(0, 0, _count);
        this.LabelTime = ts.ToString();
      }
    }

    private void SecondTime()
    {
      TimeSpan ts2 = new TimeSpan(0, (int)this.TimesIndex2, 0);
      _count = (int)ts2.TotalSeconds;
      if (_count == 0)
      {
        time++;
        ThirdTime();
      }
      else
      {
        time++;
        var color = conv.selectColor(ColorsIndex2);
        this.ForegroundColor = color;
        this.TitleBlock = this.SecondTitle;
      }
    }

    private void ThirdTime()
    {
      time++;
      var color = conv.selectColor(ColorsIndex3);
      this.ForegroundColor = color;
        this.TitleBlock = this.ThirdTitle;
      _count = 0;
    }



    public void SaveCount()
    {
      var settings = ApplicationData.Current.RoamingSettings;

      //first
      settings.Values["first_title"] = this.FirstTitle;
      settings.Values["times_index"] = this.TimesIndex;
      settings.Values["colors_index"] = this.ColorsIndex;
      settings.Values["end_bell_index"] = this.EndBellIndex;
      settings.Values["pre_bell_index"] = this.PreBellIndex;
      settings.Values["pre_bell_value"] = this.PreBellValue;
      settings.Values["pre_bell_minutes_index"] = this.PreBellMinutesIndex;
      settings.Values["pre_bell_minutes_value"] = this.PreBellMinutesValue;
      //second
      settings.Values["second_title"] = this.SecondTitle;
      settings.Values["times_index2"] = this.TimesIndex2;
      settings.Values["colors_index2"] = this.ColorsIndex2;
      settings.Values["end_bell_index2"] = this.EndBellIndex2;
      //third
      settings.Values["third_title"] = this.ThirdTitle;
      settings.Values["colors_index3"] = this.ColorsIndex3;
      //notuse
      settings.Values["hours_index"] = this.HoursIndex;
      settings.Values["minutes_index"] = this.MinutesIndex;
      settings.Values["times_index3"] = this.TimesIndex3;
      settings.Values["end_bell_index3"] = this.EndBellIndex3;

    }

    public void LoadCount()
    {
      var settings = ApplicationData.Current.RoamingSettings;
      var temp = default(object);
      //first
      if (settings.Values.TryGetValue("first_title", out temp))
      {
        this.FirstTitle = (string)temp;
      }
      if (settings.Values.TryGetValue("times_index", out temp))
      {
        this.TimesIndex = (double)temp;
      }
      if (settings.Values.TryGetValue("colors_index", out temp))
      {
        this.ColorsIndex = (int)temp;
      }
      if (settings.Values.TryGetValue("pre_bell_index", out temp))
      {
        this.PreBellIndex = (Int32)temp;
      }
      if (settings.Values.TryGetValue("pre_bell_value", out temp))
      {
        try
        {
          this.PreBellValue = (string)temp;
        }
        catch
        {

        }
      }
      if (settings.Values.TryGetValue("pre_bell_minutes_index", out temp))
      {
        try
        {
          this.PreBellMinutesIndex = (Int32)temp;
        }
        catch
        {

        }
      }
      if (settings.Values.TryGetValue("pre_bell_minutes_value", out temp))
      {
        try
        {
          this.PreBellMinutesValue = (string)temp;
        }
        catch
        {

        }
      }
      if (settings.Values.TryGetValue("end_bell_index", out temp))
      {
        this.EndBellIndex = (Int32)temp;
      }

      //second
      if (settings.Values.TryGetValue("second_title", out temp))
      {
        this.SecondTitle = (string)temp;
      }
      if (settings.Values.TryGetValue("times_index2", out temp))
      {
        this.TimesIndex2 = (double)temp;
      }
      if (settings.Values.TryGetValue("colors_index2", out temp))
      {
        this.ColorsIndex2 = (int)temp;
      }
      if (settings.Values.TryGetValue("end_bell_index2", out temp))
      {
        this.EndBellIndex2 = (Int32)temp;
      }

      //third
      if (settings.Values.TryGetValue("third_title", out temp))
      {
        this.ThirdTitle = (string)temp;
      }
      if (settings.Values.TryGetValue("colors_index3", out temp))
      {
        this.ColorsIndex3 = (int)temp;
      }



      if (settings.Values.TryGetValue("hours_index", out temp))
      {
        this.HoursIndex = (Int32)temp;
      }
      if (settings.Values.TryGetValue("minutes_index", out temp))
      {
        this.MinutesIndex = (double)temp;
      }
      if (settings.Values.TryGetValue("times_index3", out temp))
      {
        this.TimesIndex3 = (double)temp;
      }
      if (settings.Values.TryGetValue("end_bell_index3", out temp))
      {
        this.EndBellIndex3 = (Int32)temp;
      }
    }

  }
}
