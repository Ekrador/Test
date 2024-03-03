using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Imitation
{
    public class DurationRepository : IRepository<DurationRepository>
    {
        public async Task<string> Get()
        {
            var json = File.ReadAllText("./API_Imitation/Data/Duration.txt");
            return json;
        }
    }
}
