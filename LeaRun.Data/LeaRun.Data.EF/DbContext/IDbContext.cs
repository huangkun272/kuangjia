using System;
using System.Data.Entity.Infrastructure;

namespace LeaRun.Data.EF
{
    /// <summary>
    /// 描 述：数据库连接接口 
    /// </summary>
    public interface IDbContext : IDisposable, IObjectContextAdapter
    {
    }
}
