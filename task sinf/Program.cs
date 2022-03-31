using System;
using System.IO;

namespace task_sinf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "https://media.moddb.com/images/members/5/4550/4549205/duck.jpg";

            int index = str.LastIndexOf('/');
           

            for (int i=index+1; i < str.Length; i++)
            {
                //Console.Write(str[i]);
            }



            //Random
            Random random= new Random();
            //Console.WriteLine(random.Next(1,10));





            //2ci usul
            //string fileName = Path.GetFileName(url);
            //Console.WriteLine($"Picture's Name: {fileName}");
            //Console.WriteLine(Str[54]);
            //Console.ReadLine();
            //Console.WriteLine(index);


            //UUID generator random id verir
            string copy = "6bd158f2 - b163 - 4f24 - ac65 - 541fd53a3f2d";
            string uid=Guid.NewGuid().ToString();
            Console.WriteLine(uid);




        }
    }
}
