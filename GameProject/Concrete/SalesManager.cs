using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Add(Gamer gamer, Game game, Campaign campaign)
        {
            double DiscountPrice = (game.GamePrice * campaign.Discount) / 100;
            DiscountPrice = game.GamePrice - DiscountPrice;
            Console.WriteLine("Sale completed. " + gamer.FirstName + " " + gamer.LastName + " " + game.GameName + "Toplam Fiyat : " + DiscountPrice);
        }
    }
}