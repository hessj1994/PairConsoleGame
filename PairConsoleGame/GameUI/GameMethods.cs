using System;
using System.Collections.Generic;
using System.Linq;
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

        private void StartGame()
        {

            //Declare the variables: lives, experience points, lose/exit condition(), any data that will globally for all characters
            int startLives = 7; //Starting lives
            int startingExperiencePoints = 0; //starting "points"
            string spawnPoint = "Skyrim";
            //bool exitCondition != false;

            List<CharacterProperties> charProps = new List<CharacterProperties>();
            charProps = _gameRepo.ShowCharacterProperties();
            // instead of locations, as of right now we're just setting combat
            string characterSelection = "What type of doooood would you like to be?\n";

            foreach (CharacterProperties showUserCharAtrributes in charProps)
            {
                characterSelection +=
                    $" {showUserCharAtrributes.CharacterID} --- {showUserCharAtrributes.CharacterName}\n";
            }

            while (startLives > 0/* && bossKilled != true*/)
            {
                CharacterProperties showCharInfo = new CharacterProperties();
                int userSelectsCharacter;
                string selectionForCharacterType = "";
                bool leaveLoop = false;

                while (!leaveLoop)
                {
                    Console.WriteLine($"TITLE PLACEHOLDER - The Eldest Bewks, Ladryn. But show the user starting stats etc.\n" +
                                      $"Starting location\n" +
                                      $"The beginning of the game starts in {spawnPoint}...");
                    characterSelection = Console.ReadLine();
                    //NULL EXCEPTION HANDLER, STRING EXCEPTION HANDLER
                    //if (....

                    foreach (CharacterProperties raceCharacterProperties in charProps)
                    {
                        if (selectionForCharacterType == raceCharacterProperties.CharacterID)
                        {
                            leaveLoop = true;
                            showCharInfo = charProps;
                            break;
                        }
                    }
                    //NULL EXCEPTION HANDLER, STRING EXCEPTION HANDLER
                    //if (....
                    //Maybe an exception of invalid character choice. ex 11
                } //leaving while loop

                //we've shown the user the title screen, allowed them to select a character ID, and shown them properties of the selected character
                // WHAT DO WE DO NEXT??? ARE THERE ANY OTHER OPTIONS WE SHOULD INCLUDE
                //
                //Brainstorm time yooooo of what decisions to give the user next
                //
            }

            //Console.ReadLine();
        }
    }
}
