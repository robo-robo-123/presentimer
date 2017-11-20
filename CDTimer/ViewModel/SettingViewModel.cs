using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDTimer.Model;
using System.ComponentModel;
using Windows.UI.Xaml.Media;
using Windows.UI;

namespace CDTimer.ViewModel
{
  public class SettingViewModel : Common.BindableBase//, IDisposable
  {
    private Model.SettingModel Model { get; } = SettingModel.Instance;

    //start
    public string StartTitle
    {
      get { return this.Model.StartTitle; }
      set { this.Model.StartTitle = value; }
    }

    public Color LabelColor0
    {
      get { return this.Model.LabelColor0; }
      set { this.Model.LabelColor0 = value; }
    }


    //first_section
    public string FirstTitle
    {
      get { return this.Model.FirstTitle; }
      set { this.Model.FirstTitle = value; }
    }

    public Int32 TimesIndex
    {
      get { return this.Model.TimesIndex; }
      set { this.Model.TimesIndex = value; }
    }

    public Color LabelColor1
    {
      get { return this.Model.LabelColor1; }
      set { this.Model.LabelColor1 = value; }
    }



    public Int32 PreBellIndex
    {
      get { return this.Model.PreBellIndex; }
      set { this.Model.PreBellIndex = value; }
    }

    /*
    public string PreBellValue
    {
      get { return this.Model.PreBellValue; }
      set { this.Model.PreBellValue = value; }
    }

    public Int32 PreBellMinutesIndex
    {
      get { return this.Model.PreBellMinutesIndex; }
      set { this.Model.PreBellMinutesIndex = value; }
    }

    public string PreBellMinutesValue
    {
      get { return this.Model.PreBellMinutesValue; }
      set { this.Model.PreBellMinutesValue = value; }
    }
    */



    //second_section
    public string SecondTitle
    {
      get { return this.Model.SecondTitle; }
      set { this.Model.SecondTitle = value; }
    }

    public Int32 TimesIndex2
    {
      get { return this.Model.TimesIndex2; }
      set { this.Model.TimesIndex2 = value; }
    }

    public Color LabelColor2
    {
      get { return this.Model.LabelColor2; }
      set { this.Model.LabelColor2 = value; }
    }

    public Int32 EndBellIndex
    {
      get { return this.Model.EndBellIndex; }
      set { this.Model.EndBellIndex = value; }
    }


    //third_time
    public string ThirdTitle
    {
      get { return this.Model.ThirdTitle; }
      set { this.Model.ThirdTitle = value; }
    }

    public Int32 TimesIndex3
    {
      get { return this.Model.TimesIndex3; }
      set { this.Model.TimesIndex3 = value; }
    }

    public Color LabelColor3
    {
      get { return this.Model.LabelColor3; }
      set { this.Model.LabelColor3 = value; }
    }
    public Int32 EndBellIndex2
    {
      get { return this.Model.EndBellIndex2; }
      set { this.Model.EndBellIndex2 = value; }
    }


    //common
    public string LabelTime
    {
      get { return this.Model.LabelTime; }
      set { this.Model.LabelTime = value; }
    }

    public string TitleBlock
    {
      get { return this.Model.TitleBlock; }
      set { this.Model.TitleBlock = value; }
    }

    public Windows.UI.Xaml.Media.Brush ForegroundColor
    {
      get { return this.Model.ForegroundColor; }
      set { this.Model.ForegroundColor = value; }
    }


    public bool UporDown
    {
      get { return this.Model.UporDown; }
      set { this.Model.UporDown = value; }
    }

    /*
    //not_use 
        public int ColorsIndex0
    {
      get { return this.Model.ColorsIndex0; }
      set { this.Model.ColorsIndex0 = value; }
    }

          public int ColorsIndex
    {
      get { return this.Model.ColorsIndex; }
      set { this.Model.ColorsIndex = value; }
    }

    public int ColorsIndex3
    {
      get { return this.Model.ColorsIndex3; }
      set { this.Model.ColorsIndex3 = value; }
    }

    public int ColorsIndex2
    {
      get { return this.Model.ColorsIndex2; }
      set { this.Model.ColorsIndex2 = value; }
    }

    public Int32 HoursIndex
    {
      get { return this.Model.HoursIndex; }
      set { this.Model.HoursIndex = value; }
    }
    public double MinutesIndex
    {
      get { return this.Model.MinutesIndex; }
      set { this.Model.MinutesIndex = value; }
    }
    public double TimesIndex3
    {
      get { return this.Model.TimesIndex3; }
      set { this.Model.TimesIndex3 = value; }
    }
    public Int32 EndBellIndex3
    {
      get { return this.Model.EndBellIndex3; }
      set { this.Model.EndBellIndex3 = value; }
    }
    public string ColorsInfo
    {
      get { return this.Model.ColorsInfo; }
      set { this.Model.ColorsInfo = value; }
    }

    //

    public void foretest()
    {
      this.Model.foretest();
    }
    */

    //add
    /*
  public TimeSpan FirstTimeSpan
  {
    get { return this.Model.FirstTimeSpan; }
    set { this.Model.FirstTimeSpan = value; }
  }

  public TimeSpan SecondTimeSpan
  {
    get { return this.Model.SecondTimeSpan; }
    set { this.Model.SecondTimeSpan = value; }
  }

  public TimeSpan ThirdTimeSpan
  {
    get { return this.Model.ThirdTimeSpan; }
    set { this.Model.ThirdTimeSpan = value; }
  }
  */







    /*


    public Brush LabelBrush0
    {
      get { return this.Model.LabelBrush0; }
      set { this.Model.LabelBrush0 = value; }
    }

    public Brush LabelBrush1
    {
      get { return this.Model.LabelBrush1; }
      set { this.Model.LabelBrush1 = value; }
    }

    public Brush LabelBrush2
    {
      get { return this.Model.LabelBrush2; }
      set { this.Model.LabelBrush2 = value; }
    }

    public Brush LabelBrush3
    {
      get { return this.Model.LabelBrush3; }
      set { this.Model.LabelBrush3 = value; }
    }

    public Brush LabelColorBrush2
    {
        get { return new SolidColorBrush(this.LabelColor2); }
        //set { this.Model.LabelColor2 = value; }
    }
    */

    /*
    public string FirstLabel
    {
      get { return this.Model.LabelTime; }
      set { this.Model.LabelTime = value; }
    }

    public string SecondLabel
    {
      get { return this.Model.LabelTime; }
      set { this.Model.LabelTime = value; }
    }

    public string ThirdLabel
    {
      get { return this.Model.LabelTime; }
      set { this.Model.LabelTime = value; }
    }

     public Brush GetBrush(Color color)
    {
      return new SolidColorBrush(color);
    }


       */
    //method


    public void TimerStart()
    {
      this.Model.TimerStart();
    }

    public void MainTimerStart()
    {
      this.Model.MainTimerStart();
    }

    public void TimerStop()
    {
      this.Model.TimerStop();
    }

    public void TimerReset()
    {
      this.Model.TimerReset();
    }

    public void Test()
    {
      this.Model.SaveCount();
    }

    public SettingViewModel()
    {
      this.Model.PropertyChanged += this.SettingViewModel_PropertyChanged;
    }

    private void SettingViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      this.OnPropertyChanged(e.PropertyName);
    }

  }
}
