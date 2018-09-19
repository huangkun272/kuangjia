using LeaRun.Application.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace LeaRun.Application.Mapping.SystemManage
{
    /// <summary>
    /// 版 本
   
    /// 创 建：超级管理员
    /// 日 期：2018-06-25 17:43
    /// 描 述：设备信息表
    /// </summary>
    public class EquipmentMap : EntityTypeConfiguration<EquipmentEntity>
    {
        public EquipmentMap()
        {
            #region 表、主键
            //表
            this.ToTable("Equipment");
            //主键
            this.HasKey(t => t.SBXH);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
