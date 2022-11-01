using Insta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insta.API.Maps
{
    public class MomentMap : IEntityTypeConfiguration<Moment>
    {
        public void Configure(EntityTypeBuilder<Moment> builder)
        {
            builder.ToTable("tb_moment");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id");

            builder.Property(x => x.Title)
                .HasColumnName("title");

            builder.Property(x => x.Description)
                .HasColumnName("description");

            builder.Property(x => x.Image)
                .HasColumnName("image");

            builder.HasMany(x => x.Comments)
                .WithOne(p => p.Moment)
                .HasForeignKey(c => c.MomentId);
        }
    }
}
