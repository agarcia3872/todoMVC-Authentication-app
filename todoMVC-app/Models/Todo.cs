using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace todoMVC_app.Models
{
    public class Todo
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public bool IsDone { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}