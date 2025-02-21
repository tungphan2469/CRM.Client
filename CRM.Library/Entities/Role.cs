using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CRM.Library.Entities
{
    public partial class Role : ObservableObject
    {
        [ObservableProperty]
        public string? logo;
        [ObservableProperty]
        public string? companyName;
        [ObservableProperty]
        public string? position;
        [ObservableProperty]
        public string? duration;
        [ObservableProperty]
        public string? jobId;
        [ObservableProperty]
        public string? status;
        [ObservableProperty]
        public string? activity;

        //public Role(string companyName, string position, string duration, string jobId,string status, string activity = "")
        //{
        //    this.companyName = companyName;
        //    this.position = position;
        //    this.duration = duration;
        //    this.jobId = jobId;
        //    this.activity = activity;
        //}
    }
}
