using System;  
using System.Collections;  
  
public class Program  
{  
    public static void Main()  
    {  
        int[] arr = { 2, 11, 15, 1, 7, 99, 6, 85, 4 };  
        Array.Sort(arr); 
        for(int i=arr.Length-2;i>0;i--)
        {
          if(arr[i]!=arr[arr.Length-1])
          {
            Console.WriteLine(" second Largest value is  :"+arr[i]);
            break;
          }
          
        }
    }  
} 