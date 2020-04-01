using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameUI
{
    class ProgramUI
    {
        static void Main(string[] args)
        {
            static int[] iColors = { 0x000000, 0x000080, 0x008000, 0x008080, 0x800000, 0x800080, 0x808000, 0xC0C0C0, 0x808080, 0x0000FF, 0x00FF00, 0x00FFFF, 0xFF0000, 0xFF00FF, 0xFFFF00, 0xFFFFFF };

            public static void ConsoleSplashImage(Color iValue)
            {
                ConsoleColor[] iTable = iColors.Select(x => Color.FromArgb(x)).ToArray();

            }


            GameMethods _ui = new GameMethods();
            _ui.Run();
        }
    }
}
