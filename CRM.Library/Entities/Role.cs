using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CRM.Library.Entities
{
    public class Role
    {
        public string Id { get; private set; } = Guid.NewGuid().ToString();
        public string? Logo { get; set; }   
        public string? CompanyName { get; set; }
        public string? Position { get; set; }  
        public string? Duration { get; set; }  
        public string? JobId { get; set; }  
        public string? Status { get; set; }  
        public string? Activity { get; set; }  
    }
}
