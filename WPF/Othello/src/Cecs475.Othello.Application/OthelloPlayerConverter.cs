using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Cecs475.Othello.Application
{

	/// <summary>
	/// Converts from an integer player number to an Ellipse representing that player's token.
	/// </summary>
	public class OthelloPlayerConverter : IValueConverter
	{

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			int player = (int)value;
			if (player == 1)
			{
				return "Current Player: Black";
			}
            return "Current Player: White";
        }
        
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
