using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoRepository.ViewModels
{
    public class TodoViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public bool Remove { get; set; }
        public DateTime? SchadulaDate { get; set; }
    }
}
