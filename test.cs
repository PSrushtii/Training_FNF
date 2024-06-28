using System;
namespace SampleConApp
{
    class baseclass{
        public virtual void testfunc()
        {
            Console.WriteLine("From base class");
        }
    }

    class derivedclass : baseclass{
        public override void testfunc()
        {
            Console.WriteLine("From derived class");
        }
        public void test1(){
            
        }
    }

    class factory{
        public static baseclass Createobject(string choice){
            if(choice=="Base") return new baseclass();
            else return new derivedclass();
        }
    }
    class test{
        static void Main(string[] args)
        {
            //string str= Console.ReadLine();
            var obj= factory.Createobject(Console.ReadLine());
            obj.testfunc();
        }
    }
    
}