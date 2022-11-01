using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insta.Models
{
    public class Moment
    {
        public Guid Id { get; set; } 
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public ICollection<Comment>? Comments { get; set; }
    }
}
