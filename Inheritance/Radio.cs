using System;

namespace Inheritance
{
    public class Radio : ElectricalDevice
    {
      

//constructor 
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {
            
        }
        
        // listening to the Radio
        /// <summary>
        /// you can start to listen to radio if its on
        /// </summary>
        public void ListenToRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the Radio");
            }
            else
            {
                Console.WriteLine("Radio is off , switch it 'On' first");
            }
        }
    }
}