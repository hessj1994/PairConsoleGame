using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;

namespace GameUI
{//program methods
    public class ProgramRepo
    {
        private readonly ProgramUI _gameRepo = new ProgramUI();

        public void Run()
        {
            _gameRepo.GameProperties();
            //added in extra enemy, character, level classes if enough time
            StartGame();
        }

        private void StartGame()
        {
            int x = 0;//lives, time, points, etc
            int y = 0;
            int z = 0;

            List<Stages> stages = new List<Stages>();
        }
    }
}
