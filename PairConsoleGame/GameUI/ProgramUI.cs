using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Media;

namespace GameUI
{
    class ProgramUI
    {
        static void Main(string[] args)
        {
            WindowsMediaPlayer myPlayer = new WindowsMediaPlayer();
            myPlayer.URL = "music.mp3";
            myPlayer.controls.play();

            GameMethods _ui = new GameMethods();
            _ui.Run();
        }
    }
}
