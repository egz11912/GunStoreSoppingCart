using System;
namespace Gunstoreshoppingcart.Models
{
    class Program
    {
        static void Main()
        {





            MyClass myVariable = new MyClass();
            myVariable.MyNewMethod<string>("hello", "How are you?", "I am doing good");
            Console.WriteLine(myVariable.MyProperty1);
            Console.WriteLine(myVariable.MyProperty2);
            Console.WriteLine(myVariable.MyProperty3);


        }
    }




}


public class MyClass
{
    public string MyProperty1 { get; set; }
    public string MyProperty2 { get; set; }
    public string MyProperty3 { get; set; }


    public void MyNewMethod<T>(T parameter1, T parameter2, T parameter3)
    {
        this.MyProperty1 = parameter1.ToString();
        this.MyProperty2 = parameter2.ToString();
        this.MyProperty3 = parameter3.ToString();

        
    }


}
