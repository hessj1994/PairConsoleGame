using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;


namespace GameUI
{
    public class GameMethods
    {
        private readonly ProgramRepo _gameRepo = new ProgramRepo();

        public void Run()
        {
            _gameRepo.CreateCharacterProperties();
            _gameRepo.CreateEnemyProperties();
            StartGame();
        }

        //class ImageTest
        //{
        //    static void MainImage()
        //    {
        //        using (Image image = Image.FromFile("C:\Users\hessj\Desktop\1150\CSharpGold\PairConsoleGame\PairConsoleGame\GameUI\assets\image.png"))
        //        {
        //            image.Tag = "image.png";
        //            // Do Stuff
        //            Console.ReadLine();
        //            Console.WriteLine(image.Tag);
        //        }
        //    }
        //}

        private void StartGame()
        {

            //Declare the variables: lives, experience points, lose/exit condition(), any data that will globally for all characters
            int startLives = 7;
            int startingExperiencePoints = 0;
            bool exitCondition =



            //List<> variable = new List<>();

            Console.ReadLine();
        }
    }
}
