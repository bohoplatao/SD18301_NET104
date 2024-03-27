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
    internal class GioHangConfig : IEntityTypeConfiguration<GIoHang>
    {
        public void Configure(EntityTypeBuilder<GIoHang> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(p =>p.GioHangCTs).WithOne(p=>p.GIoHang).HasForeignKey(p=>p.ID_GioHang).HasConstraintName("FK_GH_GHCT");

            
        }
    }
}
