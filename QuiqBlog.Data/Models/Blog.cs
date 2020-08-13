﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuiqBlog.Data.Models {
    public class Blog {
        public int Id { get; set; }
        public ApplicationUser Creator { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Published { get; set; }

        public bool Approved { get; set; }
        public ApplicationUser Approver { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
    }
}