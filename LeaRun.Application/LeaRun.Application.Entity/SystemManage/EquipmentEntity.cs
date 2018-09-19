using System;
using LeaRun.Application.Code;

namespace LeaRun.Application.Entity.SystemManage
{
    /// <summary>
    /// 版 本
   
    /// 创 建：超级管理员
    /// 日 期：2018-06-25 17:43
    /// 描 述：设备信息表
    /// </summary>
    public class EquipmentEntity : BaseEntity
    {
        #region 实体成员
        /// <summary>
        /// 设备序号
        /// </summary>
        /// <returns></returns>
        public string SBXH { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        /// <returns></returns>
        public string SBMC { get; set; }
        /// <summary>
        /// 型号
        /// </summary>
        /// <returns></returns>
        public string XH { get; set; }
        /// <summary>
        /// 设备类型
        /// </summary>
        /// <returns></returns>
        public string SBLX { get; set; }
        /// <summary>
        /// 考场序号
        /// </summary>
        /// <returns></returns>
        public string KCXH { get; set; }
        /// <summary>
        /// 网络地址
        /// </summary>
        /// <returns></returns>
        public string WLDZ { get; set; }
        /// <summary>
        /// 端口
        /// </summary>
        /// <returns></returns>
        public string DK { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        /// <returns></returns>
        public string YHM { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        /// <returns></returns>
        public string MM { get; set; }
        #endregion

        #region 扩展操作
        /// <summary>
        /// 新增调用
        /// </summary>
        public override void Create()
        {
            this.SBXH = Guid.NewGuid().ToString();
                                            }
        /// <summary>
        /// 编辑调用
        /// </summary>
        /// <param name="keyValue"></param>
        public override void Modify(string keyValue)
        {
            this.SBXH = keyValue;
                                            }
        #endregion
    }
}