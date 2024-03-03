using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Imitation
{
    public class RatingsRepository : IRepository<RatingsRepository>
    {
        public async Task<string> Get()
        {
            var json = File.ReadAllText("./Data/Ratings.txt");
            return json;
        }
    }
}
