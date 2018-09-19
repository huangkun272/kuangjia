using LeaRun.Application.Entity.AuthorizeManage;
using System.Data.Entity.ModelConfiguration;

namespace LeaRun.Application.Mapping.AuthorizeManage
{
    /// <summary>
    /// 版 本
   
    /// 创 建：超级管理员
    /// 日 期：2017-05-04 13:25
    /// 描 述：移动开发项目表
    /// </summary>
    public class App_ProjectMap : EntityTypeConfiguration<App_ProjectEntity>
    {
        public App_ProjectMap()
        {
            #region 表、主键
            //表
            this.ToTable("App_Project");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
