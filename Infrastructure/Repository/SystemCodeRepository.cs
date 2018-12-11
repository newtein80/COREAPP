using ApplicationCore.Entity.SystemModel;
using ApplicationCore.Interface;
using Infrastructure.SystemDataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class SystemCodeRepository : ISystemCodeRepository
    {
        private readonly SystemDbContext _context;

        public SystemCodeRepository(SystemDbContext context)
        {
            _context = context;
        }

        public List<T_COMMON_CODE> GetCommonCodeByArray(string[] arrCODE_TYPE, bool USE_YN)
        {
            return _context.T_COMMON_CODE.Where(r => arrCODE_TYPE.Contains(r.CODE_TYPE) && r.USE_YN == USE_YN).ToList();
        }

        public List<T_COMMON_CODE> GetCommonCodeDropDownList(string CODE_TYPE, bool USE_YN)
        {
            return _context.T_COMMON_CODE.Where(r => r.CODE_TYPE == CODE_TYPE).ToList();
        }

        public async Task<List<T_COMMON_CODE>> GetCommonCodeDropDownListAsync(string CODE_TYPE, bool USE_YN)
        {
            //return await _context.TcommonCode.Where(r => r.CodeType == codeType).;
            return await _context.T_COMMON_CODE.Where(r => r.CODE_TYPE == CODE_TYPE).ToListAsync();
        }
    }
}
