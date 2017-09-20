using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace CDTimer.Common
{

  class CommonMethod
  {

  }


  public class Color
  {
    public string TextName { get; set; }
    public Brush TextForeground { get; set; }

    public Color(string textName, Brush textforeground)
    {
      this.TextName = textName;
      this.TextForeground = textforeground;
    }
  }

  class CommonClass
  {




    public Brush selectColor(int index)
    {
      SolidColorBrush color;
      if (index == 0)
      {
        color = new SolidColorBrush(Windows.UI.Colors.Green);
      }
      else if (index == 1)
      {
        color = new SolidColorBrush(Windows.UI.Colors.Yellow);
      }

      else if (index == 2)
      {
        color = new SolidColorBrush(Windows.UI.Colors.Red);
      }
      else
      {
        color = new SolidColorBrush(Windows.UI.Colors.White);
      }

      return color;
    }

    public int selectTime(int index)
    {
      int time;
      if (index == 0)
      {
        time = index + 1;
      }
      else if (index == 1)
      {
        time = index + 1;
      }
      else if (index == 2)
      {
        time = index + 1;
      }
      else if (index == 3)
      {
        time = index + 1;
      }
      else if (index == 4)
      {
        time = index + 1;
      }
      else
      {
        time = index + 1;
      }
      return time;
    }

  }
}
