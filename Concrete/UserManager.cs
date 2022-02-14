using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    class UserManager : IUserService
    {
        IUserCheckService checkService;

        public UserManager(IUserCheckService checkService)
        {
            this.checkService = checkService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Silindi : "+gamer.FirstName);
        }

        public void Register(Gamer gamer)
        {
            if (checkService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Kaydedildi : "+gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız.");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Güncellendi : "+gamer.FirstName);
        }
    }
}
