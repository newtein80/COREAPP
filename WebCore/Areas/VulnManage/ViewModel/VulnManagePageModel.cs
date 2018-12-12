using ApplicationCore.Entity.VulnModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Models;

namespace WebCore.Areas.VulnManage.ViewModel
{
    public class VulnManagePageModel
    {
        public List<T_VULN> t_VULNs { get; set; }
        public VulnManageSearchModel vulnSearchModel { get; set; }
        public PageDefaultVM pageDefaultVM { get; set; }
        public int vulnModesTotalCount { get; set; }
    }
}
