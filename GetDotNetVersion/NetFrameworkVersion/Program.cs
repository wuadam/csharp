using System;
using Microsoft.Win32;

namespace NetFrameworkVersion {

    class Program
    {
        static void Main(string[] args)
        {
            Getdotnetver greet = new Getdotnetver("Local Machine ....");

            greet.Print();
            
            Getdotnetver.Get45PlusFromRegistry();

            Console.ReadLine();
        }
    }


}