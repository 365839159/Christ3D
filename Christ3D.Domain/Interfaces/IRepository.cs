using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christ3D.Domain.Interfaces
{
    /// <summary>
    /// 定义仓储泛型接口， 并继承IDisposable 显示释放资源
    /// </summary>
    /// <typeparam name=""></typeparam>
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        //添加
        void Add(TEntity entity);

        //根据id进行查询
        TEntity GetById(Guid id);
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> GetAll();
        //根据对象进行更新
        void Update(TEntity entity);
        /// <summary>
        /// 根据id删除
        /// </summary>
        /// <param name="id"></param>
        void Remove(Guid id);
        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        int SaveChanges();
    }
}
