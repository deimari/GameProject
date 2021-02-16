using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;
using GameProject.Concrete;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            if (player.YearOfBirth == 1998 && player.Name == "Ilgit" && player.LastName == "Bozdogan" && player.NationalityId == "01234")
            {
                return true;
            }
            return false;
        }
    }
}
