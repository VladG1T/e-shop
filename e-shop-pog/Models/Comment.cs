using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Models {
    public class Comment {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public string CategoryName { get; set; }
        public int ItemId { get; set; }
    }
}
