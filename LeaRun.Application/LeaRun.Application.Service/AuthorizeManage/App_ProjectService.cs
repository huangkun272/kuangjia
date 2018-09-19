using LeaRun.Application.Entity.AuthorizeManage;
using LeaRun.Application.IService.AuthorizeManage;
using LeaRun.Data.Repository;
using LeaRun.Util.WebControl;
using System.Collections.Generic;
using System.Linq;

using LeaRun.Util;

using LeaRun.Util.Extension;

namespace LeaRun.Application.Service.AuthorizeManage
{
    /// <summary>
    /// 版 本 6.1
   
    /// 创 建：超级管理员
    /// 日 期：2017-05-04 13:25
    /// 描 述：移动开发项目表
    /// </summary>
    public class App_ProjectService : RepositoryFactory<App_ProjectEntity>, App_ProjectIService
    {
        #region 获取数据
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns>返回分页列表</returns>
        public IEnumerable<App_ProjectEntity> GetPageList(Pagination pagination, string queryJson)
        {
            return this.BaseRepository("BaseDb","SqlServer").FindList(pagination);
        }
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="queryJson">查询参数</param>
        /// <returns>返回列表</returns>
        public IEnumerable<App_ProjectEntity> GetList(string queryJson)
        {
            return this.BaseRepository("BaseDb","SqlServer").IQueryable().ToList();
        }
        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        public App_ProjectEntity GetEntity(string keyValue)
        {
            return this.BaseRepository("BaseDb","SqlServer").FindEntity(keyValue);
        }
        #endregion

        #region 提交数据
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        public void RemoveForm(string keyValue)
        {
            this.BaseRepository("BaseDb","SqlServer").Delete(keyValue);
        }
        /// <summary>
        /// 保存表单（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public void SaveForm(string keyValue, App_ProjectEntity entity)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                entity.Modify(keyValue);
                this.BaseRepository("BaseDb","SqlServer").Update(entity);
            }
            else
            {
                entity.Create();
                this.BaseRepository("BaseDb","SqlServer").Insert(entity);
            }
        }
        #endregion
    }
}
