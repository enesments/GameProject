using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using GameProject.Abstract;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new EDevletServiceAdapter());
            Gamer gamer1 = new Gamer() { NationalityId="1524856525",FirstName="Enes",LastName="Mentese",DateOfBirth=2000};
            gamerManager.Registration(gamer1);

            Campaign campaign = new Campaign();
            CampaignManager campaignManager = new CampaignManager();
            campaign.CampaignName = "First Sales";
            campaign.Discount = "50";

            campaignManager.Save(campaign);

            GameManager gameManager = new GameManager();
            Game game = new Game() { GameName = "Forest 2 ",GamePrice = 1000,};
            gameManager.Save(game);

            SalesManager salesManager = new SalesManager();
            salesManager.Add(gamer1, game, campaign);

        }
    }
}
