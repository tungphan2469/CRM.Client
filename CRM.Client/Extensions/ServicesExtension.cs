using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Utilities.MVVM;
using CRM.Utilities.Navigation;

namespace CRM.Client.Extensions
{
    public static class ServicesExtension
    {
        public static MauiAppBuilder RegisterCore(this MauiAppBuilder builder)
        {
            return builder;
        }

        public static MauiAppBuilder RegisterFeatures(this MauiAppBuilder builder)
        {
           
            return builder;
        }

        public static void RegisterRoute()
        {
            //Routing.RegisterRoute("homePage", typeof(HomePageView));
            //Routing.RegisterRoute("archive", typeof(ArchiveView));

        }

        /// <summary>
        ///     Đăng ký một số page/view không phải kế thừa từ các lớp base trong MVVM
        /// </summary>
        public static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
        {
            var pageTypes = typeof(MauiProgram).Assembly
                .GetTypes()
                .Where(x =>
                    !x.IsAbstract && x != typeof(BasePage) && x.IsAssignableTo(typeof(BasePage))
                );

            foreach (var pageType in pageTypes) builder.Services.AddTransient(pageType);

            var viewModelTypes = typeof(MauiProgram).Assembly
                .GetTypes()
                .Where(x =>
                    !x.IsAbstract && x != typeof(BaseViewModel) &&
                    x != typeof(NavigationAwareBaseViewModel) &&
                    (
                        x.IsAssignableTo(typeof(BaseViewModel)) ||
                        x.IsAssignableTo(typeof(NavigationAwareBaseViewModel))
                    )
                )
                .ToList();

            foreach (var vmType in viewModelTypes) builder.Services.AddTransient(vmType);

            return builder;
        }
    }
}
