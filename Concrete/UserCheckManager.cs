using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    class UserCheckManager : IUserCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
           ;
            if (gamer.FirstName.Length>0 || gamer.LastName.Length>0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
