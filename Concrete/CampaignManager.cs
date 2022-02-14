using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign added : "+campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted : "+campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign update : "+campaign.Name);
        }
    }
}
