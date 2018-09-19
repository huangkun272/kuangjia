﻿using LeaRun.Application.Entity.FlowManage;
using System.Data.Entity.ModelConfiguration;

namespace LeaRun.Application.Mapping.FlowManage
{
    /// <summary>
    /// 版 本
   
   
    /// 日 期：2016.03.18 09:58
    /// 描 述：工作流实例模板表
    /// </summary>
    public class WFProcessSchemeMap: EntityTypeConfiguration<WFProcessSchemeEntity>
    {
        public WFProcessSchemeMap()
        {
            #region 表、主键
            //表
            this.ToTable("WF_ProcessScheme");
            //主键
            this.HasKey(t => t.Id);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
