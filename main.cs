using System;  //Fix formating and loop logic tmwr 

class Program 
{
  public static void Main (string[] args)
  {
    //vars and Arrays 
    Double[] fiveTemp = new Double[5];
    Double result = 0; 
    bool x; 
    bool y; 

    //adds values in Array, throws non specified 
    for(int sub = 0; sub<fiveTemp.Length; ++sub)
    {
      Console.Write("Enter weather {0}: ", sub+1); //Good
      fiveTemp[sub] = Convert.ToInt32(Console.ReadLine());//Good
    
      if(fiveTemp[sub] < -30 || fiveTemp[sub] > 130)//Good
       {
         while(fiveTemp[sub] < -30 || fiveTemp[sub] > 130)
         {
           Console.WriteLine("Exception Temperature {0} is invalid, Please enter a Valid temperature between -30 and 130", fiveTemp[0]);
           Console.WriteLine(" "); 
           Console.Write("Enter weather {0}: ", sub+1); 
           fiveTemp[sub] = Convert.ToDouble(Console.ReadLine()); 
         }
       }  
    }
    
    if(x = fiveTemp[0] < fiveTemp[1])
    {
      if(fiveTemp[2]<fiveTemp[3])
      {
        if(fiveTemp[4]>fiveTemp[3])
        {
          Console.WriteLine(" ");
          Console.WriteLine("Getting warmer");
          Console.WriteLine(" ");
        }
      }
    }

    if( y = fiveTemp[0] > fiveTemp[1])
    {
      if(fiveTemp[1] > fiveTemp[2])
      {
        if(fiveTemp[2] > fiveTemp[3])
        {
          if(fiveTemp[3] > fiveTemp[4])
          {
            Console.WriteLine(" ");
            Console.WriteLine("Getting Colder"); 
            Console.WriteLine(" ");
          }
        }
      }
    }

    // else if (reason = x && y)
    // {
    //   Console.WriteLine(" ");
    //   Console.WriteLine("It's a mixed bag"); 
    //   Console.WriteLine(" ");
    // }

    else if (!(fiveTemp[0] < fiveTemp[1] && fiveTemp[1] < fiveTemp[2] && fiveTemp[2] < fiveTemp[3] && fiveTemp[3] < fiveTemp[4]) &&
             !(fiveTemp[0] > fiveTemp[1] && fiveTemp[1] > fiveTemp[2] && fiveTemp[2] > fiveTemp[3] && fiveTemp[3] > fiveTemp[4]))
    {
        Console.WriteLine(" ");
        Console.WriteLine("It's a mixed bag"); 
        Console.WriteLine(" ");
    }

    Console.WriteLine("Five day temps: ");
    Console.WriteLine(" "); 
    foreach(int element in fiveTemp){
      Console.WriteLine(element);
      Console.WriteLine(" ");
    }

    foreach(int i in fiveTemp){
      result += i; 
    }

    Double Average = (result / fiveTemp.Length); 

    Console.WriteLine("Average Temperature is {0} degrees.", Average); 
  }
}
