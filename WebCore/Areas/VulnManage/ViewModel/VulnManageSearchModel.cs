using ApplicationCore.Entity.SystemModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore.Areas.VulnManage.ViewModel
{
    public class VulnManageSearchModel
    {
        [Display(Name = "점검 구분")]
        public string Diag_type { get; set; }

        public List<T_COMMON_CODE> Diag_types { get; set; }

        [Display(Name = "점검 유형")]
        public string Diag_kind { get; set; }

        [Display(Name = "컴플라이언스명")]
        public string Comp_name { get; set; }
        public Int64 Comp_seq { get; set; }

        [Display(Name = "항목그룹명")]
        public string Group_name { get; set; }
        public Int64 Group_seq { get; set; }

        [Display(Name = "항목명")]
        public string Vuln_name { get; set; }

        [Display(Name = "관리ID")]
        public string Manage_id { get; set; }

        [Display(Name = "위험도")]
        public string Rate { get; set; }

        [Display(Name = "위험수준")]
        public string Score { get; set; }

        [Display(Name = "예외여부")]
        public string Exception_yn { get; set; }

        public VulnManageSearchModel()
        {
            Diag_type = "";
            Diag_kind = "";
            Comp_name = "";
            Comp_seq = 0;
            Group_name = "";
            Group_seq = 0;
            Vuln_name = "";
            Manage_id = "";
            Rate = "";
            Score = "";
            Exception_yn = "";
            Diag_types = new List<T_COMMON_CODE>();
        }
    }
}
