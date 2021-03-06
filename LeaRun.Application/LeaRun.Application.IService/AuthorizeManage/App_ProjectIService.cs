﻿using LeaRun.Application.Entity.AuthorizeManage;
using LeaRun.Util.WebControl;
using System.Collections.Generic;

namespace LeaRun.Application.IService.AuthorizeManage
{
    /// <summary>
    /// 版 本 6.1
   
    /// 创 建：超级管理员
    /// 日 期：2017-05-04 13:25
    /// 描 述：移动开发项目表
    /// </summary>
    public interface App_ProjectIService
    {
        #region 获取数据
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns>返回分页列表</returns>
        IEnumerable<App_ProjectEntity> GetPageList(Pagination pagination, string queryJson);
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="queryJson">查询参数</param>
        /// <returns>返回列表</returns>
        IEnumerable<App_ProjectEntity> GetList(string queryJson);
        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        App_ProjectEntity GetEntity(string keyValue);
        #endregion

        #region 提交数据
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        void RemoveForm(string keyValue);
        /// <summary>
        /// 保存表单（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        void SaveForm(string keyValue, App_ProjectEntity entity);
        #endregion
    }
}
