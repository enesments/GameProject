using GameProject.Abstract;
using GameProject.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Adapters
{
    internal class EDevletServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            KPSPublicSoapClient kPSPublicSoapClient = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            Task<TCKimlikNoDogrulaResponse> tCKimlikNoDogrulaResponse = kPSPublicSoapClient.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth);
            return tCKimlikNoDogrulaResponse.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
