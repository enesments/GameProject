﻿using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Delete(Game game)
        {
            Console.WriteLine("Oyun silindi : " + game.GameName);
        }

        public void Save(Game game)
        {
            Console.WriteLine("Oyun kaydedildi : " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun güncellendi : " + game.GameName);
        }
    }
}
