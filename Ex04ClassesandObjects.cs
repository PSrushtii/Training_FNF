using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleConApp
{
    class Ex04ClassesAndObjects
    {
        static void Main(string[] args)
        {
            MachineDatabase db = new MachineDatabase();
            do{
                chooseoption();
                int choice= int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1: Machine mac= readinput();
                            db.RegisterDevice(mac);
                            break;


                     case 2: 
                            Machine mav= readinput();
                            db.UpdateDeviceDetails(mav.SlNo, mav);
                            break;


                    case 3: db.GetAllRegisteredDevice(); 
                            break;

                    default:
                            return;

                }    

            }while(true);
            

        }

        public static Machine readinput()
        {
            var slno=MyConsole.GetString("Enter the serial Number of the laptop");

            var make=MyConsole.GetString("Enter the make of the laptop");

            var model=MyConsole.GetString("Enter the model of the laptop");

            var price=MyConsole.GetString("Enter the price of the laptop");

            var myMachine= new Machine{SlNo=int.Parse(slno), Make=make, Model=model, Price=int.Parse(price)};

            return myMachine;
        }

        public static void chooseoption()
        {
            Console.WriteLine("-----------MENU-----------\n1. Register\t2. Update\t3. List");
        }
    }
}