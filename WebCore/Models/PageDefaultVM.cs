using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore.Models
{
    public class PageDefaultVM
    {
        public string Theme { get; set; }
        public string Setting { get; set; }
        public string Title { get; set; }

        public PageDefaultVM()
        {
            Theme = "metro";
            Setting = "Controller Setting";
            Title = "VulnManage";
        }

        public PageDefaultVM(string theme, string setting, string title)
        {
            Theme = theme;
            Setting = setting;
            Title = title;
        }
    }
}
