﻿using System;
using System.Collections.Generic;

namespace Infrastructure.CustomDataContext
{
    public partial class T_COMP_INFO
    {
        public T_COMP_INFO()
        {
            T_VULN_GROUP = new HashSet<T_VULN_GROUP>();
        }

        public long COMP_SEQ { get; set; }
        public string COMP_NAME { get; set; }
        public string COMP_DESCRIPTION { get; set; }
        public string COMP_REF { get; set; }
        public string STANDARD_YEAR { get; set; }
        public string DIAG_TYPE { get; set; }
        public bool? CONFIRM_YN { get; set; }
        public bool? USE_YN { get; set; }
        public string CREATE_USER_ID { get; set; }
        public DateTime? CREATE_DT { get; set; }
        public string UPDATE_USER_ID { get; set; }
        public DateTime? UPDATE_DT { get; set; }
        public string COMP_DETAIL_GUBUN { get; set; }

        public ICollection<T_VULN_GROUP> T_VULN_GROUP { get; set; }
    }
}
