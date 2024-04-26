using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    
    public class WatchService
    {
        private WatchRepositori _watchRepositori = new();
        public List<Watch> GetAllWatchs() =>
            _watchRepositori.GetAllWatchs();

        public void DeleteWatch(Watch watch) =>
            _watchRepositori.DeleteWatch(watch);

        public void AddWatch(Watch watch) => 
            _watchRepositori.AddWatch(watch);

        public void Update(Watch watch) =>
            _watchRepositori.UpdateWatch(watch);

    }
}
