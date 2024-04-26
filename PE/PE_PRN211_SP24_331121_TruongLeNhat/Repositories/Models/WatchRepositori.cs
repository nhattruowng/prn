using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Models
{
    public class WatchRepositori
    {
        private WatchDb2024Context a;
        public List<Watch> GetAllWatchs()
        {
            a = new();
            return a.Watches.ToList();
        }


        public void DeleteWatch(Watch watch)
        {
            a = new();
            a.Watches.Remove(watch);
            a.SaveChanges();
        }


        public void AddWatch(Watch watch)
        {
            a = new();
            a.Watches.Add(watch);
            a.SaveChanges();
        }
        public void UpdateWatch(Watch watch)
        {
            a = new();
            a.Watches.Update(watch);
            a.SaveChanges();
        }
    }
}
