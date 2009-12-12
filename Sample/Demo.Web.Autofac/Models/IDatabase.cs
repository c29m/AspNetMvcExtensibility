namespace Demo.Web.Autofac
{
    using System.Collections.Generic;

    public interface IDatabase
    {
        IList<TEntity> GetObjectSet<TEntity>() where TEntity : EntityBase;
    }
}