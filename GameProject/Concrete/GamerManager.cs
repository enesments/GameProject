using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
       
        private IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Deleted(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi : "+gamer.FirstName);
        }

        public void Registration(Gamer gamer)
        {
           
            
                Console.WriteLine("Oyuncu kayıt edildi : " + gamer.FirstName);
            
           
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi : " + gamer.FirstName);
        }
    }
}
