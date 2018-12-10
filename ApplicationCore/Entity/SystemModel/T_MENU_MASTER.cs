using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationCore.Entity.SystemModel
{
    public partial class T_MENU_MASTER : BaseEntity
    {
        [Key]
        public int MENU_IDENTITY { get; set; }
        public string MENU_ID { get; set; }
        public string MENU_NAME { get; set; }
        public string PARENT_MENUID { get; set; }
        public string USER_ROLL { get; set; }
        public int? USER_AUTH { get; set; }
        public int? USER_DUTY { get; set; }
        public string MENU_AREA { get; set; }
        public string MENU_CONTROLLER { get; set; }
        public string MENU_ACTION { get; set; }
        public bool? USE_YN { get; set; }
        public int SORT_ORDER { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public string CSS_CLASS { get; set; }
    }
}
