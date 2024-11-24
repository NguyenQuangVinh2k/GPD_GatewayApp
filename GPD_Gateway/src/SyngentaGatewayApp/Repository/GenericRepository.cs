using Microsoft.EntityFrameworkCore;
using SyngentaGatewayApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngentaGatewayApp.Repository
{
    public class GenericRepository<TEntity, TContext> where TEntity : BaseEntity where TContext : DbContext
    {
        public DbContext Context { get; set; }
        public GenericRepository(DbContext context)
        {
            Context = context;
        }

        public GenericRepository()
        {

        }


        public async Task<List<TEntity>> GetAllAsync()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }


        public async Task Add(TEntity datas)
        {
            try
            {
                await Context.Database.BeginTransactionAsync();
                await Context.Database.EnsureCreatedAsync();
                await Context.Set<TEntity>().AddAsync(datas);
                await Context.SaveChangesAsync();
                Context.Database.CommitTransaction();
            }
            catch (Exception ex)
            {
                Context.Database.RollbackTransaction();
            }
        }

        public async Task Remove(TEntity datas)
        {
            try
            {
                await Context.Database.BeginTransactionAsync();
                await Context.Database.EnsureCreatedAsync();
                Context.Set<TEntity>().Remove(datas);
                await Context.SaveChangesAsync();
                Context.Database.CommitTransaction();
            }
            catch (Exception)
            {
                Context.Database.RollbackTransaction();
            }
        }


        public async Task Delete(TEntity datas)
        {
            try
            {
                await Context.Database.BeginTransactionAsync();
                var dbset = Context.Set<TEntity>();
                dbset.Remove(datas);
                await Context.SaveChangesAsync();
                Context.Database.CommitTransaction();
            }
            catch (Exception)
            {
                Context.Database.RollbackTransaction();
            }
        }


        public async Task AddRange(List<TEntity> datas)
        {
            try
            {
                await Context.Database.EnsureCreatedAsync();
                await Context.Database.BeginTransactionAsync();
                await Context.Set<TEntity>().AddRangeAsync(datas);
                await Context.SaveChangesAsync();
                Context.Database.CommitTransaction();
            }
            catch (Exception)
            {
                Context.Database.RollbackTransaction();
            }

        }

    }
}
