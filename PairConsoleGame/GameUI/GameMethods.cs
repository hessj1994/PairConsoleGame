using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameUI
{
    public class GameMethods
    {
        private readonly ProgramUI _gameRepo = new ProgramUI();

        public void Run()
        {
            _gameRepo.CreateCharacterProperties();
            //added in extra enemy, character, level classes if enough time
            StartGame();
        }

        private void StartGame()
        {
            int x = 0;//lives, time, points, etc
            int y = 0;
            int z = 0;

            List<> variable = new List<>();
        }
    }
}
