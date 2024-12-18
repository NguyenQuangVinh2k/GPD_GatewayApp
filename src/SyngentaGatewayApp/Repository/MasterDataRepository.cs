﻿using SyngentaGatewayApp.Database;
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
        public async Task AddDataLog(MasterDataEntity data)
        {
            using (var context = new AppDBContext())
            {
                var repo = new GenericRepository<MasterDataEntity, AppDBContext>(context);
                await repo.Add(data);
            }
        }
        public async Task GetListLog(MasterDataEntity data) 
        {
            using (var context = new AppDBContext())
            {
                var repo = new GenericRepository<MasterDataEntity, AppDBContext>(context);
                await repo.GetAllAsync();
            }
        }

    }
}
