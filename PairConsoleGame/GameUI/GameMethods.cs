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
        private readonly ProgramUI _gameRepo = new ProgramUI();

        public void Run()
        {
            //_gameRepo.CreateCharacterProperties();
            //added in extra enemy, character, level classes if enough time
            StartGame();
        }

        class ImageTest
        {
            static void MainImage()
            {
                using (Image image = Image.FromFile("C:\Users\hessj\Desktop\1150\CSharpGold\PairConsoleGame\PairConsoleGame\GameUI\assets\image.png"))
                {
                    image.Tag = "image.png";
                    // Do Stuff
                    Console.ReadLine();
                    Console.WriteLine(image.Tag);
                }
            }
        }

        private void StartGame()
        {
            int x = 0;//lives, time, points, etc
            int y = 0;
            int z = 0;

            //List<> variable = new List<>();

            Console.ReadLine();
        }
    }
}
