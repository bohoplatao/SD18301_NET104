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
    internal class SanPhamCTConfig : IEntityTypeConfiguration<SanPhamCT>
    {
        public void Configure(EntityTypeBuilder<SanPhamCT> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasMany(p => p.GioHangCTs).WithOne(p => p.SanPhamCT).HasForeignKey(p => p.ID_SPCT).HasConstraintName("FK_SPCT_GHCT");
            builder.HasMany(p => p.HoaDonCTs).WithOne(p => p.SanPhamCT).HasForeignKey(p => p.ID_SPCT).HasConstraintName("FK_HDCT_SPCT");
        }
    }
}
