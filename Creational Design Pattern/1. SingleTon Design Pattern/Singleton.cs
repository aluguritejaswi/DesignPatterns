using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
  /* 
   Applications: 
   Singleton is used for Log writer  
   */
  public class SingleTon
  {
    /*This variable value will be increment by 1 each time the object of the class is created*/
    private static int Counter = 0;

    /*This variable is going to store the Singleton Instance*/
    private static SingleTon Instance = null;
    private static string logFilePath = "";
    //private static StreamWriter writer = null;

    /*The following Static Method is going to return the Singleton Instance*/
    public static SingleTon GetInstance()
    {
      //If the variable instance is null, then create the Singleton instance 
      //else return the already created singleton instance
      //This version is not thread safe
      if (Instance==null)
      {
        Instance=new SingleTon();
        //string timeStamp = DateTime.Now.ToString("yyyyMMddhhmmss");
        //logFilePath="C:\\log"+timeStamp+".txt";
        //if (!File.Exists(logFilePath))
        //  File.Create(logFilePath);
        //  //FileStream fileStream = new FileStream(logFilePath, FileMode.Create);
        //  writer=new StreamWriter(logFilePath);
      }
      //Return the Singleton Instance
      return Instance;
    }

    ~SingleTon()
    {
      //Instance.PrintDetails("LOG ENDED "+Counter.ToString());
      //writer.Close();
      Instance=null;
      //writer=null;
      Console.WriteLine("LOG ENDED "+Counter.ToString());
    }

    /*Constructor is Private means, from outside the class we cannot create an instance of this class*/
    private SingleTon()
    {
      /*Each Time the Constructor called, increment the Counter value by 1*/
      Counter++;
      Console.WriteLine("Counter Value "+Counter.ToString());
    }

    /*The following can be accesed from outside of the class by using the Singleton Instance*/
    public void PrintDetails(string message)
    {
      //writer.WriteLine(message);
      Console.WriteLine(message);
    }


    /*
     DerivedSingleton - It is a nested class
     Sealed key word prevents Inheritance, even for Nested class
     */
     public class DerivedSingleton : SingleTon
     {

     }
  }
}
/**/
