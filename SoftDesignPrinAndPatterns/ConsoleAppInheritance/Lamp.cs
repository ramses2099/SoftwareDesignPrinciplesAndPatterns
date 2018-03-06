using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance
{
    public class Lamp : ILamp
    {
        bool _isSwitchOn = false;
        bool _isOn = false;
        bool _isPlugged = false;

        public bool IsOn
        {
            get
            {
                return _isOn;
            }
            set
            {
                if (_isOn == value)
                    return;
                _isOn = value;

                Console.WriteLine($"The lamp is {(_isOn ? "On" : "Off")}");
            }
        }

        public bool IsPlugged
        {
            get
            {
                return _isPlugged;
            }

            set
            {
                if (_isPlugged == value)
                    return;
                _isPlugged = value;

                IsOn = IsSwitchOn && IsPlugged;
            }
        }

        public bool IsSwitchOn
        {
            get
            {
                return _isSwitchOn;
            }

            set
            {
                if (_isSwitchOn == value)
                    return;
                _isSwitchOn = value;

                IsOn = IsSwitchOn && IsPlugged;
            }

        }
    }
}
