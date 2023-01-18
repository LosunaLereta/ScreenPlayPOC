using CoreFramework.PageObjects.Interactions;
using CoreFramework.PageObjects.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.PageObjects
{
    // This page initializes everything and you can access elements or methods from another PageObject classes without initializing
    public class PageObjects : Base
    {
        private WindowsInteractions _windowsInteractions;
        public WindowsInteractions WindowsInteractions => _windowsInteractions ?? (_windowsInteractions = new WindowsInteractions());

        private DashboardInteractions _dashboardInteractions;
        public DashboardInteractions DashboardInteractions => _dashboardInteractions ?? (_dashboardInteractions = new DashboardInteractions());

        private DashboardPage _dashboardPage;
        public DashboardPage DashboardPage => _dashboardPage ?? (_dashboardPage = new DashboardPage());


    }
}
