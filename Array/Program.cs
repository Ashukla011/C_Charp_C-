
using System;

namespace Palindrome;

class Program{

    static void Main(string [] args){
        // find palendrome 
        int i=0, j;
         char[] arr;
         int flag =0;
         Console.WriteLine("Enter String:");
         arr = Console.ReadLine().ToCharArray();
         j = arr.Length-1;
         while (i<=j)
         {
            if(arr[i] == arr[j]){
                i++;
                j--;
            }else{
                flag =1;
               break;
            }
         }
         if(flag==0){
            Console.WriteLine("Enter String is a palindrom");
         }else{
            Console.WriteLine("Enter string is not a palindrom");
         }
        
        // Foreach loop 
        char[] ch;
        Console.WriteLine("Enter string");
        ch = Console.ReadLine().ToCharArray();
        foreach(char c in ch){
            Console.WriteLine("{0} ",c);
        }


        // Findig the largest nuber from an array 

        int[] maxarr = {2,8,4,7};
        int max =maxarr[0], k=1;
        while(k<=maxarr.Length-1){
            if(maxarr[k]>max){
                max = maxarr[k];
            }
            k++;
        }
        Console.WriteLine("The largest number in the aray is:",max);

    }

    
}



// for Two dimentiona 
// int[,] myarray = new int [4,2];