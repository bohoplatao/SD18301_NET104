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
    internal class HoaDonCTConfig : IEntityTypeConfiguration<HoaDonCT>
    {
        public void Configure(EntityTypeBuilder<HoaDonCT> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(p=>p.Voucher).WithMany(p=>p.HoaDonCTs).HasForeignKey(p=>p.ID_Voucher).HasConstraintName("FK_VC_HDCT");
            builder.HasOne(p => p.HoaDon).WithMany(p => p.HoaDonCTs).HasForeignKey(p => p.ID_HD).HasConstraintName("FK_HD_HDCT");
        }
    }
}
