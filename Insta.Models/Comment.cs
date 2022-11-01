using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insta.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Guid MomentId { get; set; }
        public string? UserName { get; set; }
        public string? Text { get; set; }
        public Moment? Moment { get; set; }
    }
}