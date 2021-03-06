﻿using ApplicationCore.Entity.VulnModel;
using ApplicationCore.Interface;
using Dapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Areas.VulnManage.ViewModel;
using WebCore.Models;

namespace WebCore.Areas.VulnManage.Controllers
{
    [Area("VulnManage")]
    public class VulnManageController : Controller
    {
        private readonly ISystemCodeRepository _systemCodeRepository;
        private readonly IDapperHelper _dapperHelper;
        private readonly IAppLogger<VulnManageController> _logger;

        public VulnManageController(ISystemCodeRepository systemCodeRepository, IDapperHelper dapperHelper, IAppLogger<VulnManageController> logger)
        {
            this._systemCodeRepository = systemCodeRepository;
            this._dapperHelper = dapperHelper;
            this._logger = logger;
        }

        [HttpGet]
        public IActionResult VulnCreate()
        {
            //ViewData["GroupSeq"] = new SelectList(_context.TvulnGroup, "GroupSeq", "GroupType");
            return View();
        }

        // GET: VulnManage/Tvulns/Details/5
        [HttpGet]
        public IActionResult VulnDetail(long? id)
        {
            if (id == null || 1 > id)
            {
                return NotFound();
            }

            var param = new DynamicParameters();
            param.Add("@vuln_seq", id);
            param.Add("@comp_seq", 0);
            param.Add("@diag_kind", "");
            param.Add("@group_seq", 0);

            // 테이블 한개 리스트
            T_VULN t_VULN = _dapperHelper.Top1<T_VULN>("SP_VULN_INFO_VIW", param);

            //string m_UseYn = "Y";
            //string[] arrSearchCommonCodes = { "RATE", "SCORE", "EXCEPT_CD", "USE_YN", "DIAG_TYPE" };
            //List<TcommonCode> _ddlCommonCodes = systemCodeRepository.GetCommonCodeByArray(arrSearchCommonCodes, m_UseYn);

            //var vulnEditModel = new VulnEditModel
            //{
            //    tCommonCodes = _ddlCommonCodes,
            //    tCompInfos = vulnDbContext.TcompInfo.ToList(),
            //    tVulnGroup_kind = vulnDbContext.TvulnGroup.Where(x => x.CompSeq == vulnEditInfo.CompSeq && x.GroupType == "K").Distinct().ToList(),
            //    tVulnGroup_group = vulnDbContext.TvulnGroup.Where(x => x.DiagKind == vulnEditInfo.DiagKind && x.GroupType == "G").ToList(),
            //    tVulnEditInfo = vulnEditInfo
            //};

            return View(t_VULN);
        }

        [HttpGet]
        public IActionResult VulnList()
        {
            var _ddlDiagType = _systemCodeRepository.GetCommonCodeDropDownList("DIAG_TYPE", true);

            var vulnSearchModel = new VulnManageSearchModel
            {
                Diag_types = _ddlDiagType
            };

            //var initVulnModels = new List<T_VULN>
            //{
            //    new T_VULN()
            //};

            var param = new DynamicParameters();
            param.Add("@gubun", "");
            param.Add("@diag_type", "");
            param.Add("@diag_kind", "");
            param.Add("@comp_seq", 0);
            param.Add("@comp_name", "");
            param.Add("@group_seq", 0);
            param.Add("@group_name", "");
            param.Add("@vuln_seq", 0);
            param.Add("@vuln_name", "");
            param.Add("@manage_id", "");
            param.Add("@rate", 0);
            param.Add("@score", 0);
            param.Add("@use_yn", 1);
            param.Add("@exception_yn", 0);
            param.Add("@user_id", "");
            param.Add("@sort_field", "");
            param.Add("@is_desc", 1);
            param.Add("@pagesize", 10);
            param.Add("@pageindex", 1);
            //p.Add("@UserID", userId, DbType.String, null, 100);
            param.Add("@allCount", dbType: DbType.Int32, direction: ParameterDirection.Output, size: 50);

            // 테이블 한개 리스트
            //var initVulnModels = new List<T_VULN> { new T_VULN() }; //DapperHelper.GetList<T_VULN>("SP_VULN_LIST_TEST", param).ToList();
            var initVulnModels = _dapperHelper.GetList<T_VULN>("SP_VULN_LIST_02", param).ToList();

            // 메인 + 서브 모델
            //var Table = SqlHelper.MultiPleGetList<Schema_User, Address>(SqlHelper.localDB.ToString(), "sp_GetUser_List", param);

            //int resultParam = 0;// param.Get<int>("@allCount");

            VulnManagePageModel vulnViewModel = new VulnManagePageModel
            {
                pageDefaultVM = new PageDefaultVM(),
                t_VULNs = initVulnModels,
                vulnModesTotalCount = 0,
                vulnSearchModel = vulnSearchModel
            };

            return View(vulnViewModel);
        }
    }
}
