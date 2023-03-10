using SnakeProject.UserServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject.UI
{
    public class UIService
    {
        private GamePlay _gamePlay = new GamePlay();
        private UserService _userService = new UserService();
        private User _user = new User();

        public void GetMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 5);
            Console.WriteLine("||==================================================||");
            Console.SetCursorPosition(30, 6);
            Console.WriteLine("||--------------------------------------------------||");
            Console.SetCursorPosition(30, 7);
            Console.WriteLine("||-------------Welcome to snake game----------------||");
            Console.SetCursorPosition(30, 8);
            Console.WriteLine("||--------------------------------------------------||");
            Console.SetCursorPosition(30, 9);
            Console.WriteLine("||==================================================||");
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("              -Press Enter to start the game          ");
            Console.SetCursorPosition(30, 13);
            Console.WriteLine("              -Use arrows to move the snake           ");
            Console.SetCursorPosition(30, 14);
            Console.WriteLine("              -Press C to create the user             ");
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("              -Press S to get all scores              ");
            Console.SetCursorPosition(30, 16);
            Console.WriteLine("              -Press ESC to quite the game            ");
            Console.SetCursorPosition(30, 17);
            Console.WriteLine("||--------------------------------------------------||");
            Console.SetCursorPosition(30, 18);
            Console.WriteLine("||==================================================||");



        }
        public void GetComand(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.Enter:
                    StartGame();
                    break;
                case ConsoleKey.C:
                    CreateUserform();
                    break;
                case ConsoleKey.S:
                    ScoreBoard();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;


                default:
                    GetMenu();
                    break;
            }
        }
        private void StartGame()
        {
            Console.Clear();
            _gamePlay.StartGame(_user);
            Concede();

        }
        private void CreateUserform()
        {
            Label:
            Console.Clear();
            Console.WriteLine("Create User Form");

            Console.Write("Enter Your name Please:");

            string userName = Console.ReadLine();
            try
            {
                _user = _userService.CreateUser(userName);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                goto Label;
            }
            

            Console.WriteLine("User Saved");

            Console.WriteLine("Press Backspace to back");

        }
        private void ScoreBoard()
        {
            Console.Clear();
            Console.WriteLine("Score Boarg");
           var users= _userService.GetAllUsers();
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Name} with score:{item.Score}");
            }
            Console.WriteLine("Press Backspace to back");

        }
        private void Concede()
        {
            Console.Clear();
            Console.WriteLine("Game Over");
            Console.WriteLine("To try again press Entar");
            Console.WriteLine("Back to manu press Backspace");
        }

       

        
    }
}
