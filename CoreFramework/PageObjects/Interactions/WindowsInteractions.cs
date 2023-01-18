using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.PageObjects.Interactions
{
    public class WindowsInteractions : PageObjects
    {
        public void Method1() 
        {
            //you can access elements from another page/class without initalization or instances
            bool x = DashboardPage.element.Displayed;
        }
        public void Method2() { }
        public void Method3() { }
    }
}
