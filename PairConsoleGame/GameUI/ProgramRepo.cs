﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameUI
{//
    class ProgramRepo
    {
        List<CharacterProperties> _characterProperties = new List<CharacterProperties>();
        //List<EnemyProperties> _enemyProperties = new List<EnemyProperties>();
        //List<CharacterProperties> _characterProperties

        public void CreateCharacterProperties()
        {//change levels/experience to innate character props
            _characterProperties.Add(new CharacterProperties(1, "Human", 5));
            _characterProperties.Add(new CharacterProperties(2, "Khajat", 1));
            _characterProperties.Add(new CharacterProperties(3, "Argunian", 1));
            _characterProperties.Add(new CharacterProperties(4, "Elf", 1));
            _characterProperties.Add(new CharacterProperties(5, "Not-Day Elf", 1));
            _characterProperties.Add(new CharacterProperties(6, "Witch", 1));
            _characterProperties.Add(new CharacterProperties(7, "Blue Guard", 1));
            _characterProperties.Add(new CharacterProperties(8, "Nerds", 1));
            _characterProperties.Add(new CharacterProperties(9, "Unforgiven", 1));
        }//^^ Change GameProperties to CharacterProperties
        // CreateEnemyProperties
        // CreateLevelSystemProperties
        // CreateWorldProperties, paths to locations etc
        // CreateWorldDangers, ex. Dragons, Bandits, Giants
    }
}