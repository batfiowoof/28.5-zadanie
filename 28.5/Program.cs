using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._5
{
    class Program
    {
        static void PrintString(char[] arr1,int l)
        {

            char ch; //promenliva za bukvite
            for (int x = 0; x < l; x++)
            {
                ch = arr1[x];
                if (Char.IsLower(ch)) Console.Write(Char.ToUpper(ch)); //proverka dali bukvata e malka, ako e, preobrazuva se v golqma(1)
                else Console.Write(Char.ToLower(ch)); //obratnoto na (1)
                
            }
        }
        static void Main(string[] args)
        {
            //zadacha - preobrazuvane na malki bukvi v golemi i obratnoto v string
            Console.WriteLine("Enter string");
            char[] arr1; //masiv za bukvite
            int duljina; //int za duljinata na stringa
            string str = Console.ReadLine(); //vuvejdane na stringa
            duljina = str.Length; //izvejdane na duljinata na stringa kum promenlivata
            arr1 = str.ToCharArray(0, duljina); //preobrazuvane na stringa v bukvi 
            PrintString(arr1,duljina); //vikane na metoda ^
            
            Console.ReadKey();
        }
    }
}
