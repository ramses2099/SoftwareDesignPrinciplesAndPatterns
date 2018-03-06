using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance
{
    public class Fridge : IFridge
    {
        bool _isPlugged = false;
        double _setTemperature = double.NaN;
        double _realTemperature = 0;

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

                RealTemperature = IsPlugged ? SetTemperature : 0;
            }
        }
        //        
        public double SetTemperature
        {
            get
            {
                return _setTemperature;
            }

            set
            {
                if (_setTemperature == value)
                    return;

                _setTemperature = value;

                RealTemperature = IsPlugged ? SetTemperature : 0;

            }
        }
        //
        public double RealTemperature
        {
            get
            {
                return _setTemperature;
            }
            private set
            {
                if (_realTemperature == value)
                    return;

                _realTemperature = value;

                Console.WriteLine($"Real Temperature is {RealTemperature} degrees");   
            }
        }
        
    }
}
