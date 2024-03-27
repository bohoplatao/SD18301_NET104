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
    internal class UserRoleConfig : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(p=>p.Role).WithMany(p =>p.UserRoles).HasForeignKey(p => p.ID_Role).HasConstraintName("FK_ROLE_USERROLE");
            builder.HasOne(p => p.Users).WithMany(p => p.UserRoles).HasForeignKey(p => p.ID_Users).HasConstraintName("KF_User_UserRole");
        }
    }
}
