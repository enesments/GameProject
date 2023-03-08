using GameProject.Abstract;
using System;

namespace GameProject.Entities
{
  public  class Gamer :IEntity
    {
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int DateOfBirth { get; set; }
    }
}
