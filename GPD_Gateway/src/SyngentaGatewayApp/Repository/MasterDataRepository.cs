using SyngentaGatewayApp.Database;
using SyngentaGatewayApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngentaGatewayApp.Repository
{
    public class MasterDataRepository
    {
        public async Task AddDataLog(MasterData data)
        {
            using (var context = new AppDBContext())
            {
                var repo = new GenericRepository<MasterData, AppDBContext>(context);
                await repo.Add(data);
            }
        }
        public async Task GetListLog(MasterData data) 
        {
            using (var context = new AppDBContext())
            {
                var repo = new GenericRepository<MasterData, AppDBContext>(context);
                await repo.GetAllAsync();
            }
        }

    }
}
