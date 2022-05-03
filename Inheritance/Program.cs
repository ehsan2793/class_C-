using System;

namespace Inheritance
{
    internal class Program
    {
       
        public static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Super Radio");
            
            myRadio.ListenToRadio();
            myRadio.SwitchOn();
            myRadio.ListenToRadio();


            TV myTV = new TV(false, "Sony");
            myTV.SwitchOn();
            myTV.WatchTV();

        }
    }
}