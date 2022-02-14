using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        List<Game> games = new List<Game>();
        public void Add(Game game)
        {
            if (game.Name.Length>0 && game.Price!<0)
            {
                games.Add(game);
                Console.WriteLine("Oyun eklendi : "+game.Name);
                
            }
            else
            {
                Console.WriteLine("Eklenemedi. Bilgileri kontrol edin...");
            }
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi : "+game.Name);
        }

        public List<Game> getAllGames()
        {
            return games;
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun güncellendi : "+game.Name);
        }
    }
}
