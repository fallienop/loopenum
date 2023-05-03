namespace oop;
using may3task;
using System.Drawing;
class Program 
{
    static void Main()
    {
        foreach(Status st in Enum.GetValues(typeof(Status)))
        {
          
            Console.WriteLine(
                st
                + "-->"
                + st.GetDisplayName());
            

        }
        Console.ReadLine();
      
    }
}


