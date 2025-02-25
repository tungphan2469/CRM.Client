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
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
namespace CRM.Client.Features.Home
{
    public partial class HomeViewModel : ObservableObject
    {
        [ObservableProperty]
        private DataTable data;

        [ObservableProperty]
        private Role selectedItem;

        [ObservableProperty]
        public ObservableCollection<string> items;

        [ObservableProperty]
        private bool isOpenConfirmSaveSettingPopup;

        [ObservableProperty]
        private string popupMessage;

        [ObservableProperty]
        private string title;

        private ObservableCollection<Role> roles;

        public ObservableCollection<Role> Roles => roles ?? (roles = CreateRoles());

        private ObservableCollection<Role> CreateRoles()
        {
            return new ObservableCollection<Role>
            {
                new Role()
                {
                    Logo = string.Format(FaBrands.Apple),
                    CompanyName = "Apple",
                    Position = "Visual designer",
                    Duration = "Full time",
                    JobId = "123123123",
                    Status = "Phone interview",
                    Activity = "",
                },
                new Role()
                {
                    Logo = string.Format(FaBrands.Amazon),
                    CompanyName = "Amazon",
                    Position = "Product designer",
                    Duration = "Full time",
                    JobId = "123123123",
                    Status = "Applied",
                    Activity = "",
                },
                new Role()
                {
                    Logo = string.Format(FaBrands.Google),
                    CompanyName = "Google",
                    Position = "Interactive designer",
                    Duration = "Full time",
                    JobId = "123123123",
                    Status = "Zoom call",
                    Activity = "",
                },
                new Role()
                {
                    Logo = string.Format(FaBrands.Instagram),
                    CompanyName = "Instagram",
                    Position = "Product designer",
                    Duration = "Full time",
                    JobId = "123123123",
                    Status = "Round 2 interview",
                    Activity = "",
                },
                new Role()
                {
                    Logo = string.Format(FaBrands.Skype),
                    CompanyName = "Skype",
                    Position = "UX/UI designer",
                    Duration = "Full time",
                    JobId = "123123123",
                    Status = "Phone interview",
                    Activity = "",
                },
                new Role()
                {
                    Logo = string.Format(FaBrands.Salesforce),
                    CompanyName = "Salesforce",
                    Position = "Visual designer",
                    Duration = "12 months",
                    JobId = "123123123",
                    Status = "Zoom call",
                    Activity = "",
                }
            };
        }

        [RelayCommand]
        private void OpenConfirmSaveSettingPopup(Role? item)
        {
            if (item is null)
                SelectedItem = new Role();
            else
                SelectedItem = item;
            Title = item is null ? "New Role" : "Edit Role";
            PopupMessage = $"{SelectedItem.CompanyName}?"; // Update message
            IsOpenConfirmSaveSettingPopup = true;
        }

      
        public void DeleteRoles(List<string> ids)
        {
            for (int i = Roles.Count - 1; i >= 0; i--)
            {
                if (ids.Contains(Roles[i].Id))
                {
                    Roles.RemoveAt(i);
                }
            }
        }

        [RelayCommand]
        private void CloseConfirmSaveSettingPopup()
        {
            IsOpenConfirmSaveSettingPopup = false;
        }

        [RelayCommand]
        private void ConfirmButtonClick(Role item)
        {
            if (Roles.Any(x => x.Id == item.Id))
            {
                int index = Roles.IndexOf(Roles.FirstOrDefault(x => x.Id == item.Id));
                if (index != -1)
                {
                    Roles[index] = item; // Replace the old item with the updated item
                }
            }
            else
            {
                Roles.Add(item); // Add the new item
            }
            IsOpenConfirmSaveSettingPopup = false;
        }
    }
}
