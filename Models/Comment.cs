using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApi.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public String Body { get; set; }=String.Empty;
    }
}