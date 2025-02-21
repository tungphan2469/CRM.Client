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

namespace CRM.Client.Features.Home
{
    public partial class HomeViewModel : ObservableObject
    {
        [ObservableProperty]
        private DataTable data;

        private ObservableCollection<Flight> roles;

        public ObservableCollection<Flight> Roles => roles ?? (roles = CreateRoles());

        private ObservableCollection<Flight> CreateRoles()
        {
            return new ObservableCollection<Flight>
            {
                new Flight()
                {
                    Logo = "",
                    CompanyName = "Apple",
                    Position = "A",
                    Duration = "A",
                    JobId = "S",
                    Status = "S",
                    Activity = "S",
                }
            };
        }
    }
}
