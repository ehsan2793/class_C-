namespace Inheritance
{
    public class ElectricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }
        public void SwitchOn()
        {
            IsOn = true;
        }        // turning off the Radio
        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}