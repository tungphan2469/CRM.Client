using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CRM.Library.Entities
{
    public partial class Role
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string? Logo { get; set; }   
        public string? CompanyName { get; set; }
        public string? Position { get; set; }  
        public string? Duration { get; set; }  
        public string? JobId { get; set; }  
        public string? Status { get; set; }  
        public string? Activity { get; set; }

        public Role RoleMapping(Role role)
        {
            return new Role
            {
                Id = role.Id,
                Logo = role.Logo,
                CompanyName = role.CompanyName,
                Position = role.Position,
                Duration = role.Duration,
                JobId = role.JobId,
                Status = role.Status,
                Activity = role.Activity
            };
        }
    }
}
