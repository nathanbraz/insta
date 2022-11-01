using Insta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insta.API.Maps
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("tb_comment");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id");

            builder.Property(x => x.MomentId)
                .HasColumnName("moment_id");

            builder.Property(x => x.UserName)
                .HasColumnName("username");

            builder.Property(x => x.Text)
                .HasColumnName("text");

            builder.HasOne(x => x.Moment)
                .WithMany(p => p.Comments);
        }
    }
}
