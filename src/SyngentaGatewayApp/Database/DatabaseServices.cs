using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngentaGatewayApp.Database
{
    public class DatabaseServices
    {
        private static DatabaseServices _ins;

        public static DatabaseServices Ins
        {
            get { return _ins == null ? _ins = new DatabaseServices() : _ins; }
        }
        
        public static async Task Init() 
        {
            using (var db = new AppDBContext()) 
            {
                try
                {
                    await db.Database.EnsureCreatedAsync();
                    await db.Database.BeginTransactionAsync();
                }
                catch (Exception ex)
                {
                    db.Database.RollbackTransaction();
                    throw ex;
                }
            }
        }

    }
}
