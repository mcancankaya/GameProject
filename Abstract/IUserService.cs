using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    interface IUserService
    {
        void Register(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
