using SnakeProject.UI;
using System;

namespace SnakeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UIService uIService = new UIService();
            uIService.GetMenu();
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                uIService.GetComand(key.Key);
                
            }


            
            
        }
    }
}
