using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Shapes;

namespace TrafficLights.Objects
{
    public class TrafficLights
    {
        public enum StateType
        {
            red, yellow, green
        }
        public enum ModeType 
        {
            automatic, manual
        }
        private Ellipse _red;
        private Ellipse _yellow;
        private Ellipse _green;
        private StateType _state = StateType.red;
        private ModeType _mode= ModeType.manual;

        public TrafficLights(Ellipse red, Ellipse yellow, Ellipse green) 
        {
            _red = red;
            _yellow = yellow;
            _green = green;
        }
    }
}
