using System;
using System.Collections.Generic;
using System.Linq;
class Machine{
        public int SlNo {get; set;}

        public string Make {get; set;}

        public string Model {get; set;}

        public int Price {get; set;}

        public override string ToString(){
            return string.Format("Serial Number= {0} \nMake = {1} \nModel= {2} \nPrice is {3}", SlNo, Make, Model, Price);
        }
}

class MachineDatabase{
    private List<Machine> laptops= new List<Machine>();

    public void RegisterDevice(Machine mac){
    
        laptops.Add(mac);

    }

    public void UpdateDeviceDetails(int slNo, Machine mac){
        Machine device=null;
        foreach(var m in laptops){
            if(m.SlNo==slNo)
            {
                device = m;
                break;
            }
        }
        if(device != null)
        {
            device.Make=mac.Make;
            device.Model=mac.Model;
            device.Price=mac.Price;

        }
    }

    public List<Machine> GetAllRegisteredDevice()
    {
        Console.WriteLine("The laptops are as follows\n");
        foreach(var lap in laptops)
        {
            Console.WriteLine(lap);
            Console.WriteLine();
        }
        return laptops;
    }
}