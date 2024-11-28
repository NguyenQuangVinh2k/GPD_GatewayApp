using SyngentaGatewayApp.Database;
using SyngentaGatewayApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngentaGatewayApp.Repository
{
    public class GatewayRepository
    {
        public async Task AddDataLog(GatewayEntity data)
        {
            using (var context = new AppDBContext())
            {
                var repo = new GenericRepository<GatewayEntity, AppDBContext>(context);
                await repo.Add(data);
            }
        }
        public async Task GetListLog(GatewayEntity data)
        {
            using (var context = new AppDBContext())
            {
                var repo = new GenericRepository<GatewayEntity, AppDBContext>(context);
                await repo.GetAllAsync();
            }
        }
    }
}
