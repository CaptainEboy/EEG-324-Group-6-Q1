using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EEG324_GROUP6_Q1
{

    //class
    public class Val
    {
       //NB:Transformer Voltage is Vtrs
       public double Vtrs;
       public double Vled;
       public double Iled;
       
       //Constructor
       public Val(double Vt, double Vl, double Il)
       {
           Vtrs = Vt;
           Vled = Vl;
           Iled = Il;
       }
      //End of the constructor
       
       
       //method
       public void DisplayRs()
       {
       
           //NB:Vcc is (Vtrs - Vdrop) * √2, where Vdrop has a constant of 0.7 *2
           double Vcc = (Vtrs - 1.4) * (Math.Sqrt(2));
           double Rs = (Vcc - Vled)/Iled;
           Console.WriteLine($"The value of Rs is {Rs}");
           
       }
      //End of the method
       
       
    }
    //End of the class Val
    
    
    //Beginning of the app
    class Program
    {
        static void Main(string[] args)
        {
            //create group1 to group10 objects
            Val group1 = new Val(6, 1.5, 10);
            Val group2 = new Val(6, 2.5, 10);
            Val group3 = new Val(9, 1.5, 10);
            Val group4 = new Val(9, 2.5, 10);
            Val group5 = new Val(12, 1.5, 10);
            Val group6 = new Val(12, 2.5, 10);
            Val group7 = new Val(15, 1.5, 10);
            Val group8 = new Val(15, 2.5, 10);
            Val group9 = new Val(25, 1.5, 10);
           Val group10 = new Val(25, 2.5, 10);
           
           
           //Display the value of Rs for Group1 to Group 10
           group1.DisplayRs();
           group2.DisplayRs();
           group3.DisplayRs();
           group4.DisplayRs();
           group5.DisplayRs();
           group6.DisplayRs();
           group7.DisplayRs();
           group8.DisplayRs();
           group9.DisplayRs();
           group10.DisplayRs();
           
        }
    }
   //End of the app
    
}

