using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace CDTimer.Model
{
  public class SettingModel : Common.BindableBase
  {
    public static SettingModel Instance { get; } = new SettingModel();
    Common.CommonClass conv = new Common.CommonClass();
    DispatcherTimer dispatcherTimer;    // タイマーオブジェクト
    private int _count;
    //private int time;
    private int dispTime;

    private MediaElement element = new MediaElement();
    private MediaElement element2 = new MediaElement();
    private Windows.Storage.Streams.IRandomAccessStream stream;

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
      stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
      element.SetSource(stream, "");
      element2.SetSource(stream, "");
      //element.Play();
    }


    /*
    //dust
    private int colorsIndex0;
    public int ColorsIndex0
    {
      get { return this.colorsIndex0; }
      set { this.SetProperty(ref this.colorsIndex0, value); }
    }


    private int colorsIndex;
    public int ColorsIndex
    {
      get { return this.colorsIndex; }
      set { this.SetProperty(ref this.colorsIndex, value); }
    }
    */



    //start
    private string startTitle;
    public string StartTitle
    {
      get { return this.startTitle; }
      set { this.SetProperty(ref this.startTitle, value); }
    }
    private Color labelColor0;
    public Color LabelColor0
    {
      get { return this.labelColor0; }
      set { this.SetProperty(ref this.labelColor0, value); }
    }

    private bool uporDown;
    public bool UporDown
    {
      get { return this.uporDown; }
      set { this.SetProperty(ref this.uporDown, value); }
    }


    //first
    private string firstTitle;
    public string FirstTitle
    {
      get { return this.firstTitle; }
      set { this.SetProperty(ref this.firstTitle, value); }
    }

    private Int32 timesIndex;
    public Int32 TimesIndex
    {
      get { return this.timesIndex; }
      set { this.SetProperty(ref this.timesIndex, value); }
    }

    private Color labelColor1;
    public Color LabelColor1
    {
      get { return this.labelColor1; }
      set { this.SetProperty(ref this.labelColor1, value); }
    }

    private Int32 preBellIndex;
    public Int32 PreBellIndex
    {
      get { return this.preBellIndex; }
      set { this.SetProperty(ref this.preBellIndex, value); }
    }

    /*
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
    */

    //second
    private string secondTitle;
    public string SecondTitle
    {
      get { return this.secondTitle; }
      set { this.SetProperty(ref this.secondTitle, value); }
    }

    private Int32 timesIndex2;
    public Int32 TimesIndex2
    {
      get { return this.timesIndex2; }
      set { this.SetProperty(ref this.timesIndex2, value); }
    }
    private Color labelColor2;
    public Color LabelColor2
    {
      get { return this.labelColor2; }
      set { this.SetProperty(ref this.labelColor2, value); }
    }

    private Int32 endBellIndex;
    public Int32 EndBellIndex
    {
      get { return this.endBellIndex; }
      set { this.SetProperty(ref this.endBellIndex, value); }
    }


    //third
    private string thirdTitle;
    public string ThirdTitle
    {
      get { return this.thirdTitle; }
      set { this.SetProperty(ref this.thirdTitle, value); }
    }

    private Int32 timesIndex3;
    public Int32 TimesIndex3
    {
      get { return this.timesIndex3; }
      set { this.SetProperty(ref this.timesIndex3, value); }
    }


    private Color labelColor3;
    public Color LabelColor3
    {
      get { return this.labelColor3; }
      set { this.SetProperty(ref this.labelColor3, value); }
    }

    private Int32 endBellIndex2;
    public Int32 EndBellIndex2
    {
      get { return this.endBellIndex2; }
      set { this.SetProperty(ref this.endBellIndex2, value); }
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

    private Color labelColort;
    public Color LabelColort
    {
      get { return this.labelColort; }
      set { this.SetProperty(ref this.labelColort, value); }
    }

    //add
    /*
     * 
     * 
     *     private int colorsIndex3;
    public int ColorsIndex3
    {
      get { return this.colorsIndex3; }
      set { this.SetProperty(ref this.colorsIndex3, value); }
    }
     * 
     *     private int colorsIndex2;
    public int ColorsIndex2
    {
      get { return this.colorsIndex2; }
      set { this.SetProperty(ref this.colorsIndex2, value); }
    }
    private TimeSpan firstTimeSpan;
    public TimeSpan FirstTimeSpan
    {
      get { return this.firstTimeSpan; }
      set { this.SetProperty(ref this.firstTimeSpan, value); }
    }

    private TimeSpan secondTimeSpan;
    public TimeSpan SecondTimeSpan
    {
      get { return this.secondTimeSpan; }
      set { this.SetProperty(ref this.secondTimeSpan, value); }
    }

    private TimeSpan thirdTimeSpan;
    public TimeSpan ThirdTimeSpan
    {
      get { return this.thirdTimeSpan; }
      set { this.SetProperty(ref this.thirdTimeSpan, value); }
    }



    /// <summary>
    /// カラー設定をどうにかしないといけない
    /// </summary>
    /// 

    private Brush labelBrush0;
    public Brush LabelBrush0
    {
      get { return this.labelBrush0; }
      set { this.SetProperty(ref this.labelBrush0, value); }
    }

    private Brush labelBrush1;
    public Brush LabelBrush1
    {
      get { return this.labelBrush1; }
      set { this.SetProperty(ref this.labelBrush1, value); }
    }

    private Brush labelBrush2;
    public Brush LabelBrush2
    {
      get { return this.labelBrush2; }
      set { this.SetProperty(ref this.labelBrush2, value); }
    }

    private Brush labelBrush3;
    public Brush LabelBrush3
    {
      get { return this.labelBrush3; }
      set { this.SetProperty(ref this.labelBrush3, value); }
    }

            */



    //not_use
    /*
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
    */


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

      if (UporDown == false)
      {
        TimeSpan ts = new TimeSpan(0, 0, 0);
        this.dispTime = 0;
        this.LabelTime = ts.ToString();
      }
      else
      {
        //TimeSpan ts = new TimeSpan(0, (int)this.TimesIndex, 0);
        //_count = (int)ts.TotalSeconds;
        TimeSpan ts = new TimeSpan(0, this.TimesIndex3, 0);//timesindex3=0の時の対応できてない
        this.dispTime = (int)ts.TotalSeconds;
        this.LabelTime = ts.ToString();
      }

      this._count = 0;

      //var color = conv.selectColor(ColorsIndex);
      //this.ForegroundColor = color;
      this.ForegroundColor = new SolidColorBrush(LabelColor0);
      this.TitleBlock = this.StartTitle;
      //time = 0;
    }

    private async void playsound(int index)
    {
      //element.SetSource(stream, "");
      //element2.SetSource(stream, "");

      if (index == 1)
      {
        this.element.Play();
        //element.SetSource(stream, "");
        await Task.Delay(300);
      }
      else if (index == 2)
      {
        //element.SetSource(stream, "");
        this.element.Play();
        await Task.Delay(300);

        //element2.SetSource(stream, "");
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

        this.element2.Play();
        await Task.Delay(300);
        this.element2.Stop();

        this.element.Play();
        await Task.Delay(300);

        this.element2.Play();
        await Task.Delay(300);
      }
      else if (index == 5)
      {
        this.element.Play();
        await Task.Delay(300);
        this.element.Stop();

        this.element2.Play();
        await Task.Delay(300);
        this.element2.Stop();

        this.element.Play();
        await Task.Delay(300);
        this.element.Stop();

        this.element2.Play();
        await Task.Delay(300);

        this.element.Play();
        await Task.Delay(300);
      }

    }

    private void dispatcherTimer_Tick(object sender, object e)
    {

      this._count++;
      if (this.UporDown == false)
      {
        this.dispTime++;
      }
      else
      {
        this.dispTime--;
      }
      TimeSpan ts = new TimeSpan(0, 0, this.dispTime);
      this.LabelTime = ts.ToString();

      if (_count == (this.TimesIndex) * 60 && this.TimesIndex != 0)
      {
        playsound(this.PreBellIndex);
        this.ForegroundColor = new SolidColorBrush(LabelColor1);
        this.TitleBlock = this.FirstTitle;
      }


      //if (_count == (this.TimesIndex + this.TimesIndex2) * 60 && this.TimesIndex2 != 0)
      if (_count == (this.TimesIndex2) * 60 && this.TimesIndex2 != 0)
      {
        playsound(this.EndBellIndex);
        //var color = conv.selectColor(ColorsIndex2);
        //this.ForegroundColor = color;
        this.ForegroundColor = new SolidColorBrush(LabelColor2);
        this.TitleBlock = this.SecondTitle;
      }

      //if (_count == (this.TimesIndex + this.TimesIndex2 + this.TimesIndex3) * 60 && this.TimesIndex3 != 0)
      if (_count == (this.TimesIndex3) * 60 && this.TimesIndex3 != 0)
      {
        playsound(this.EndBellIndex2);
        //var color = conv.selectColor(ColorsIndex3);
        //this.ForegroundColor = color;
        this.ForegroundColor = new SolidColorBrush(LabelColor3);
      }

      /*
      if (time == 0)//first
      {
        this._count++;
        TimeSpan ts = new TimeSpan(0, 0, _count);
        this.LabelTime = ts.ToString();
        if (_count == (this.FirstTimeSpan.TotalMinutes) * 60 && this.FirstTimeSpan != null)
        {
          playsound(int.Parse(this.PreBellValue));
        }
        if (_count == this.SecondTimeSpan.Milliseconds )
        {
          playsound(this.EndBellIndex + 1);
          SecondTime();
        }
      }
      else if (time == 1)
      {
        this._count++;
        TimeSpan ts = new TimeSpan(0, 0, _count);
        this.LabelTime = ts.ToString();
        if (_count == this.SecondTimeSpan.TotalMinutes * 60 && this.SecondTimeSpan != null )
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

      */
    }


      /*
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

*/



    public void SaveCount()
    {
      var settings = ApplicationData.Current.RoamingSettings;

      //start
      settings.Values["start_title"] = this.StartTitle;
      settings.Values["label_color0"] = this.LabelColor0.ToString();
      settings.Values["up_down"] = this.UporDown;



      //first
      settings.Values["first_title"] = this.FirstTitle;
      settings.Values["times_index"] = this.TimesIndex;
      settings.Values["label_color1"] = this.LabelColor1.ToString();
      settings.Values["pre_bell_index"] = this.PreBellIndex;
      //settings.Values["colors_index"] = this.ColorsIndex;
      //settings.Values["pre_bell_value"] = this.PreBellValue;
      //settings.Values["pre_bell_minutes_index"] = this.PreBellMinutesIndex;
      //settings.Values["pre_bell_minutes_value"] = this.PreBellMinutesValue;


      //second
      settings.Values["end_bell_index"] = this.EndBellIndex;
      settings.Values["second_title"] = this.SecondTitle;
      settings.Values["times_index2"] = this.TimesIndex2;
      settings.Values["label_color2"] = this.LabelColor2.ToString();
      //settings.Values["colors_index2"] = this.ColorsIndex2;


      //third
      settings.Values["third_title"] = this.ThirdTitle;
      settings.Values["end_bell_index2"] = this.EndBellIndex2;
      settings.Values["label_color3"] = this.LabelColor3.ToString();
      settings.Values["times_index3"] = this.TimesIndex3;
      //settings.Values["colors_index3"] = this.ColorsIndex3;
      //notuse
      /*
      settings.Values["hours_index"] = this.HoursIndex;
      settings.Values["minutes_index"] = this.MinutesIndex;
      settings.Values["times_index3"] = this.TimesIndex3;
      settings.Values["end_bell_index3"] = this.EndBellIndex3;
      */


      System.Diagnostics.Debug.WriteLine("SaveCount is finished!!!!!!!!!!");
      System.Diagnostics.Debug.WriteLine(this.LabelColor0.ToString()+"!!!!!!!!!!");
    }



    public SolidColorBrush GetSolidColorBrush(string hex)
    {
      hex = hex.Replace("#", string.Empty);
      byte a = (byte)(Convert.ToUInt32(hex.Substring(0, 2), 16));
      byte r = (byte)(Convert.ToUInt32(hex.Substring(2, 2), 16));
      byte g = (byte)(Convert.ToUInt32(hex.Substring(4, 2), 16));
      byte b = (byte)(Convert.ToUInt32(hex.Substring(6, 2), 16));
      SolidColorBrush myBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(a, r, g, b));
      return myBrush;
    }


    public void LoadCount()
    {
      var settings = ApplicationData.Current.RoamingSettings;
      var temp = default(object);
      try
      {

        //start
        if (settings.Values.TryGetValue("start_title", out temp))
        {
          this.StartTitle = (string)temp;
        }
        
        if (settings.Values.TryGetValue("label_color0", out temp))
        {
          this.LabelColor0 = GetSolidColorBrush((string)temp).Color; 
        }
        
        
        if (settings.Values.TryGetValue("up_down", out temp))
        {
          this.UporDown = (bool)temp;
        }

        //first
        if (settings.Values.TryGetValue("first_title", out temp))
        {
          this.FirstTitle = (string)temp;
        }
        if (settings.Values.TryGetValue("times_index", out temp))
        {
          this.TimesIndex = (Int32)temp;
        }

        if (settings.Values.TryGetValue("pre_bell_index", out temp))
        {
          this.PreBellIndex = (Int32)temp;
        }
        if (settings.Values.TryGetValue("label_color1", out temp))
        {
          this.LabelColor1 = GetSolidColorBrush((string)temp).Color; 
        }

        //second
        if (settings.Values.TryGetValue("second_title", out temp))
        {
          this.SecondTitle = (string)temp;
        }
        if (settings.Values.TryGetValue("times_index2", out temp))
        {
          this.TimesIndex2 = (Int32)temp;
        }

        if (settings.Values.TryGetValue("end_bell_index", out temp))
        {
          this.EndBellIndex = (Int32)temp;
        }
        if (settings.Values.TryGetValue("label_color2", out temp))
        {
          this.LabelColor2 = GetSolidColorBrush((string)temp).Color; 
        }

        //third
        if (settings.Values.TryGetValue("third_title", out temp))
        {
          this.ThirdTitle = (string)temp;
        }

        if (settings.Values.TryGetValue("end_bell_index2", out temp))
        {
          this.EndBellIndex2 = (Int32)temp;
        }
        if (settings.Values.TryGetValue("times_index3", out temp))
        {
          this.TimesIndex3 = (int)temp;
        }
        if (settings.Values.TryGetValue("label_color3", out temp))
        {
          this.LabelColor3 = GetSolidColorBrush((string)temp).Color; 
        }

        System.Diagnostics.Debug.WriteLine("!!!!!!!!!!!!!!!!!!" + this.LabelColort + "??????????");


      }

      catch (Exception ex)
      {
        System.Diagnostics.Debug.WriteLine("!!!!!!!!!!!!!!!!!!" + ex.Message);
      }


      /*
if (settings.Values.TryGetValue("colors_index", out temp))
{
  this.ColorsIndex = (int)temp;
}
*/
      /*
      if (settings.Values.TryGetValue("colors_index2", out temp))
      {
        this.ColorsIndex2 = (int)temp;
      }
      */
      /*
      if (settings.Values.TryGetValue("pre_bell_value", out temp))
      {
        this.PreBellValue = (string)temp;
      }
      if (settings.Values.TryGetValue("pre_bell_minutes_index", out temp))
      {
        this.PreBellMinutesIndex = (Int32)temp;
      }
      if (settings.Values.TryGetValue("pre_bell_minutes_value", out temp))
      {
        this.PreBellMinutesValue = (string)temp;
      }
      */
      /*
      if (settings.Values.TryGetValue("colors_index3", out temp))
      {
        this.ColorsIndex3 = (int)temp;
      }
      */
      /*
      if (settings.Values.TryGetValue("hours_index", out temp))
      {
        this.HoursIndex = (Int32)temp;
      }
      if (settings.Values.TryGetValue("minutes_index", out temp))
      {
        this.MinutesIndex = (double)temp;
      }

      if (settings.Values.TryGetValue("end_bell_index3", out temp))
      {
        this.EndBellIndex3 = (Int32)temp;
      }
      */
    }

  }
}
