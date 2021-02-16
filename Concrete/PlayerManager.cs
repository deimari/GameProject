using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    public class PlayerManager : IPlayerService
    {
        IUserValidationService _userValidationService;
        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Player player)
        {
            if (_userValidationService.Validate(player))
            {
                Console.WriteLine("User added: " + player.Name);
            }
            else
            {
                Console.WriteLine("[ERROR]: User must be validated!!!!");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Player is deleted");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Player is updated");
        }
    }
}
