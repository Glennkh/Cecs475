using Cecs475.Othello.Model;
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
	public class OthelloAdvantageConverter : IValueConverter
    {
        
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            GameAdvantage advantage = (GameAdvantage)value;

            String player = advantage.Player == 1 ? "Black" : "White";

            if (advantage.Advantage == 0)
            {
                return "tie game";
            }
            else {
                return player+ " is winning by " + advantage.Advantage;
            }
            

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
    }
}
