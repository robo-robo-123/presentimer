using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDTimer.Model;
using System.ComponentModel;

namespace CDTimer.ViewModel
{
  public class SettingViewModel : Common.BindableBase//, IDisposable
  {
    private Model.SettingModel Model { get; } = SettingModel.Instance;

    //first_time
    public string FirstTitle
    {
      get { return this.Model.FirstTitle; }
      set { this.Model.FirstTitle = value; }
    }

    public double TimesIndex
    {
      get { return this.Model.TimesIndex; }
      set { this.Model.TimesIndex = value; }
    }

    public int ColorsIndex
    {
      get { return this.Model.ColorsIndex; }
      set { this.Model.ColorsIndex = value; }
    }

    public Int32 PreBellIndex
    {
      get { return this.Model.PreBellIndex; }
      set { this.Model.PreBellIndex = value; }
    }

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

    public Int32 EndBellIndex
    {
      get { return this.Model.EndBellIndex; }
      set { this.Model.EndBellIndex = value; }
    }


    //second_time
    public string SecondTitle
    {
      get { return this.Model.SecondTitle; }
      set { this.Model.SecondTitle = value; }
    }

    public double TimesIndex2
    {
      get { return this.Model.TimesIndex2; }
      set { this.Model.TimesIndex2 = value; }
    }

    public int ColorsIndex2
    {
      get { return this.Model.ColorsIndex2; }
      set { this.Model.ColorsIndex2 = value; }
    }

    public Int32 EndBellIndex2
    {
      get { return this.Model.EndBellIndex2; }
      set { this.Model.EndBellIndex2 = value; }
    }


    //third_time
    public string ThirdTitle
    {
      get { return this.Model.ThirdTitle; }
      set { this.Model.ThirdTitle = value; }
    }

    public int ColorsIndex3
    {
      get { return this.Model.ColorsIndex3; }
      set { this.Model.ColorsIndex3 = value; }
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

    /*
    //not_use 
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
