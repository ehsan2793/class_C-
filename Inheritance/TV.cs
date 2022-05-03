using System;

namespace Inheritance
{
    public class TV: ElectricalDevice
    {
       

        public TV(bool isOn, string brand):base(isOn,brand)
        {
        }
       
        // Watch to the TV
        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("watching TV");
            }
            else
            {
                Console.WriteLine("TV is off , switch it 'On' first");
            }
        }
    }
}