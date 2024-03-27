using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Configurations
{
    internal class UserConfig : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            // Tên Bảng:
            builder.ToTable("Users");
            // khóa chính 
            builder.HasKey(x => x.ID);
            // ràng buộc 

            builder.HasMany(p => p.UserAddresses).WithOne(p=>p.User).HasForeignKey(p=>p.ID_User).HasConstraintName("FK_USADD_USer");
            builder.HasMany(p => p.HoaDons).WithOne(p => p.Users).HasForeignKey(p => p.ID_Users).HasConstraintName("FK_HD_USer");
            builder.HasOne(p => p.GIoHang).WithOne(p => p.Users).HasForeignKey<GIoHang>(p => p.ID_Users);

            builder. Property(p => p.UserName).IsRequired().HasColumnName("TenDN").HasColumnType("varchar(50)");

            builder. Property(p =>p.Name).IsRequired().IsUnicode(true).IsFixedLength().HasMaxLength(50);

            //builder.Property(p =>p.Name).IsRequired().HasColumnType("nvarchar(50)");
            // Đoạn cmt trên và đoạn treeb nữa có cùng ý nghĩa 
        }
    }
}
