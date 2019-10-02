using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Models {
    public class CommentModel {
        public string Username { get; set; }
        [Required(ErrorMessage = "Comment body cannot be empty")]
        [MaxLength(length:140, ErrorMessage = "Comment length cannot exceed 140 symbols")]
        public string Body { get; set; }
        public string CategoryName { get; set; }
        public int ItemId { get; set; }
    }
}
