using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace webApi.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }=string.Empty;
        public String  Description { get; set; }=String.Empty;

        public List<Comment> MyProperty { get; set; }=new List<Comment>();
    }
}