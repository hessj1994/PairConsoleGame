using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameUI
{
    public class CharacterProperties
    {
        public int CharacterID { get; set; }
        public string CharacterName { get; set; }//skills, race abilities
        public int Level { get; set; }
        public int Lives { get; set; }
        public float Experience { get; set; }
        public string Enemies { get; set; }
        public CharacterProperties() { }

        public CharacterProperties(int characterID, string characterName, int level, int lives, float experience, string enemies)
        {
            CharacterID = characterID;
            CharacterName = characterName;
            //Level = level; => to leveling class, including exp from monsters, make inside of enemy class
            Lives = lives; //each race has different starting lives
            //Experience = experience; => ExpGain
            //Exp => own class? or contain inside this one
            //Enemies = enemies;
        }
    }

    ////BRAIN-STORMMMMMMM
    ///All human properties
    //
    //
    //All enemy/level properties
    //
    //
    //All map properties / move properties (second class)
    //
    //
    //All world events properties, chances of running into them, what/where they are etc
    //
    //




    public class EnemyProperties
    {
        public int CharacterID { get; set; }
        public string CharacterName { get; set; }//skills, race abilities
        public int Level { get; set; }
        public int Lives { get; set; }
        public float Experience { get; set; }
        public string Enemies { get; set; }
        public EnemyProperties() { }

        public EnemyProperties(int characterID, string characterName, int level, int lives, float experience, string enemies)
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
