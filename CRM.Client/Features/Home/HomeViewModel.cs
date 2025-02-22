using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CRM.Library.Entities;
using Telerik.Windows.Documents.Fixed.Model.Data;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;
using CRM.UI;
namespace CRM.Client.Features.Home
{
    public partial class HomeViewModel : ObservableObject
    {
        [ObservableProperty]
        private DataTable data;

        private ObservableCollection<Role> roles;

        public ObservableCollection<Role> Roles => roles ?? (roles = CreateRoles());

        private ObservableCollection<Role> CreateRoles()
        {
            return new ObservableCollection<Role>
            {
                new Role()
                {
                    Logo = string.Format(FaRegModels.AppleCore),
                    CompanyName = "Apple",
                    Position = "Visual designer",
                    Duration = "Full time",
                    JobId = "123123123",
                    Status = "Phone interview",
                    Activity = "",
                },
                new Role()
                {
                    Logo = "",
                    CompanyName = "Booster",
                    Position = "Product designer",
                    Duration = "Full time",
                    JobId = "123123123",
                    Status = "Applied",
                    Activity = "",
                },
                new Role()
                {
                    Logo = "",
                    CompanyName = "Goodle",
                    Position = "Interactive designer",
                    Duration = "Full time",
                    JobId = "123123123",
                    Status = "Zoom call",
                    Activity = "",
                },
                new Role()
                {
                    Logo = "",
                    CompanyName = "Instagram",
                    Position = "Product designer",
                    Duration = "Full time",
                    JobId = "123123123",
                    Status = "Round 2 interview",
                    Activity = "",
                },
                new Role()
                {
                    Logo = "",
                    CompanyName = "Omada Health",
                    Position = "UX/UI designer",
                    Duration = "Full time",
                    JobId = "123123123",
                    Status = "Phone interview",
                    Activity = "",
                },
                new Role()
                {
                    Logo = "",
                    CompanyName = "Salesforce",
                    Position = "Visual designer",
                    Duration = "12 months",
                    JobId = "123123123",
                    Status = "Zoom call",
                    Activity = "",
                }
            };
        }
    }
}
