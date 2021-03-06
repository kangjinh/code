﻿/*******************************************************************************
* Copyright (C) JuCheap.Com
* 
* Author: dj.wong
* Create Date: 09/04/2015 11:47:14
* Description: Automated building by service@JuCheap.com 
* 
* Revision History:
* Date         Author               Description
*
*********************************************************************************/

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using JuCheap.Data.Entity;

namespace JuCheap.Data.Config
{
    /// <summary>
    /// 用户表配置
    /// </summary>
    public class StaffConfig : EntityTypeConfiguration<StaffEntity>
    {
        public StaffConfig()
        {
            ToTable("Staffs");
            HasKey(item => item.Id);
            Property(item => item.Id).HasColumnType("varchar").HasMaxLength(20);
            Property(item => item.LoginName).HasColumnType("varchar").IsRequired().HasMaxLength(20);
            Property(item => item.Email).HasColumnType("varchar").IsRequired().HasMaxLength(36);
            Property(item => item.Password).HasColumnType("varchar").IsRequired().HasMaxLength(36);
            Property(item => item.RealName).HasColumnType("nvarchar").IsRequired().HasMaxLength(20);
            Property(item => item.IsSuperMan).IsRequired();

            HasOptional(x => x.Department).WithMany(x => x.Staffs).HasForeignKey(x => x.DepartmentId);
        }
    }
}
