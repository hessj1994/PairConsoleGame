using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameUI
{
    public class GameProperties
    {
        public int CharacterID { get; set; }
        public string CharacterName { get; set; }//skills, race abilities
        public int Level { get; set; }
        public int Lives { get; set; }
        public float Experience { get; set; }
        public string Enemies { get; set; }
        public GameProperties() { }

        public GameProperties(int characterID, string characterName, int level, int lives, float experience, string enemies)
        {
            CharacterID = characterID;
            CharacterName = characterName;
            Level = level;
            Lives = lives;
            Experience = experience;
            Enemies = enemies;
        }
    }
    //separate classes for character selection, enemies, levels
}
