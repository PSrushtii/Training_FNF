using System;
namespace SampleConApp{
    class ArraysExample{
        static void samplearray(){
            Console.WriteLine("Enter the size of an array");
            int size=int.Parse(Console.ReadLine());
            int [] elements= new int[size];
            for(int i=0; i<size;i++)
            {
                Console.WriteLine("Enter the value at position {0}", i);
                elements[i]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("All the values are set");
            foreach ( var item in elements)
            {
                Console.WriteLine(item);
            }
        }

        static void creatingArrayatRunTime(){
            Console.WriteLine("Enter the Array size");
            int size= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the CTS type for the type of Array");
            Type arrayType= Type.GetType(Console.ReadLine());

            if (arrayType==null)
            {
                Console.WriteLine("Not a valid Data Type of .Net");
                return;
            }

            Array array= Array.CreateInstance(arrayType, size);
            for(int i=0;i<size; i++)
            {
                Console.WriteLine("Enter the value at position {0} of type {1}",i,arrayType.Name ); //for just string instead of System.String use arrayType.Name
                object value= Convert.ChangeType(Console.ReadLine(),arrayType);//------->(to change the type, take an input that has to be converted to type arrayType)-----> then convert it using "Convert"
                array.SetValue(value,i);//-------------> set value at i position
            }
            Console.WriteLine("All the values are set, they are as follows");
            foreach( var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(){
            //samplearray();
            creatingArrayatRunTime();      
      }
    }
}