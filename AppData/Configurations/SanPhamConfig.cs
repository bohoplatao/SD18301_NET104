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
    internal class SanPhamConfig : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasOne(p => p.DanhMuc).WithMany(p => p.SanPhams).HasForeignKey(p =>p.ID_DanhMuc).HasConstraintName("FK_DM_SP");
            builder.HasMany(p => p.SanPhamCTs).WithOne(p => p.SanPham).HasForeignKey(p => p.ID_SP).HasConstraintName("FK_SP_SPCT");
        }
    }
}
