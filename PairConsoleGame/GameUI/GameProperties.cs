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
        public int Lives { get; set; }
        //public float Experience { get; set; }
        public CharacterProperties() { }

        public CharacterProperties(int characterID, string characterName, int lives)
        {
            CharacterID = characterID;
            CharacterName = characterName;
            Lives = lives; //each race has different starting lives, power?
            //Experience = experience; => ExpGain
        }
    }//class for character levels

    public class EnemyProperties
    {
        public int EnemyID { get; set; }
        public string EnemyName { get; set; }
        public int EnemyPowerLevel { get; set; }
        public string EnemyWeapon { get; set; } //weapon ID, nest inside of prop
        public int EnemyXP { get; set; }
        public string DeathNote { get; set; }// also ID?
        public EnemyProperties() { }

        public EnemyProperties(int enemyID, string enemyName, int enemyPowerLevel, string enemyWeapon, int enemyXP,
            string deathNote)
        {
            EnemyID = enemyID;
            EnemyName = enemyName;
            EnemyPowerLevel = enemyPowerLevel;
            EnemyWeapon = enemyWeapon;
            EnemyXP = enemyXP;
            DeathNote = deathNote;
        }
    }
    public class MapProperties
    {
        public char NorthDirection { get; set; }
        public char EastDirection { get; set; }
        public char WestDirection { get; set; }
        public char SouthDirection { get; set; }
        public char UpDirection { get; set; }
        public char DownDirection { get; set; }
        public MapProperties() { }
    }
    ////BRAIN-STORMMMMMMM

    //All map properties / move properties (second class)
    //starting location, does it change with each race? no | what options should the user have to move around? (N,E,W,S,U,D)
    //what, if anything, happens during travel, does traveling reduce any character attributes (water/food/lives?) I don't think this is necessary
    //is this the win condition? should it be?
    //
    //All world events properties, chances of running into them, what/where they are etc
    // Negative events: Dragon, bandits, breaking your ankle,
    // Positive events: Lives gained, food/water found,
    //option to open static world map ASCII, or repeat, plus returning where they are

    //Win condition: Boss(escape or fight? experience = points) +

    //losing lives: lose a fight with enemy, negative world events giving a chance to lose life,
}
