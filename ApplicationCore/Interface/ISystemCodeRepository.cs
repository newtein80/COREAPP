using ApplicationCore.Entity.SystemModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interface
{
    public interface ISystemCodeRepository
    {
        Task<List<T_COMMON_CODE>> GetCommonCodeDropDownListAsync(string CODE_TYPE, bool USE_YN);
        List<T_COMMON_CODE> GetCommonCodeDropDownList(string CODE_TYPE, bool USE_YN);
        List<T_COMMON_CODE> GetCommonCodeByArray(string[] arrCODE_TYPE, bool USE_YN);
    }
}
