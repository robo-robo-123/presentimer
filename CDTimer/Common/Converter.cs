using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace PresenTimer.Common
{
    /// <summary>
    /// BooleanをVisibilityに変換する。
    /// </summary>
    public class Boolean2VisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Trueをセットした場合、変換を逆転させる。TrueがCollapsedを返す。
        /// </summary>
        public bool IsReversed { get; set; }

        public object Convert(object value, Type typeName, object parameter, string language)
        {
            var val = System.Convert.ToBoolean(value);
            if (this.IsReversed)
            {
                val = !val;
            }
            if (val)
            {
                return Visibility.Visible;
            }
            return Visibility.Collapsed;
        }
        public object ConvertBack(object value, Type typeName, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }


    public class Color2BrushConverter : IValueConverter
    {
        /// <summary>
        /// Color⇒brush
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, string language)
        {

            if (value == null)
            {
                return new SolidColorBrush(Colors.Blue);
            }
            //System.Diagnostics.Debug.WriteLine("!!!!!!!!" + value.ToString());

            if (value is Color color)
            {
                return new SolidColorBrush(color);
            }
            else
                throw new Exception("Can't get color from a brush that is not a SolidColorBrush");

            /*
            if (null == value) {
                return null;
            }
            // For a more sophisticated converter, check also the targetType and react accordingly..
            if (value is Color) {
                Color color = (Color)value;
                return new Windows.UI.Xaml.Media.SolidColorBrush(color);
            }
            // You can support here more source types if you wish
            // For the example I throw an exception

            Type type = value.GetType();
            throw new InvalidOperationException("Unsupported type ["+type.Name+"]");            
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            // If necessary, here you can convert back. Check if which brush it is (if its one),
            // get its Color-value and return it.

            throw new NotImplementedException();
        }

    */

        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }


    public class Brush2ColorConverter : IValueConverter
    {
        /// <summary>
        /// Color⇒brush
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, string language)
        {

            System.Diagnostics.Debug.WriteLine("!!!!!!!!" + value.ToString());

            if (value == null)
            {
                return "#FFFFFFFF";
            }

            if (value is Color color)
            {
                return new SolidColorBrush(color);
            }
            else
                throw new Exception("Can't get color from a brush that is not a SolidColorBrush");

            /*
            if (null == value) {
                return null;
            }
            // For a more sophisticated converter, check also the targetType and react accordingly..
            if (value is Color) {
                Color color = (Color)value;
                return new Windows.UI.Xaml.Media.SolidColorBrush(color);
            }
            // You can support here more source types if you wish
            // For the example I throw an exception

            Type type = value.GetType();
            throw new InvalidOperationException("Unsupported type ["+type.Name+"]");            
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            // If necessary, here you can convert back. Check if which brush it is (if its one),
            // get its Color-value and return it.

            throw new NotImplementedException();
        }

    */

        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

}
