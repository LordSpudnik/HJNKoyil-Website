using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using System.Net.Http;
using X.PagedList;
using Microsoft.AspNetCore.Mvc;
using HJNKoyil.Models;

namespace HJNKoyil.Controllers
{
    public class vwCommonMasterDtlController : ControllerBase
    {
        private HJNKoyil.BusinessLogic.vwCommonMasterDtls objController = new HJNKoyil.BusinessLogic.vwCommonMasterDtls();
        #region	List
        [HttpGet]
        [Route("Api/vwCommonMasterDtl/List")]
        public PagedList<VwCommonMasterDtl> List(int pType =0, int page = 1, int pageSize = 10)
        {
            var data = objController.GetvwCommonMasterDtls(pType).ToList();
            return (new PagedList<VwCommonMasterDtl>(data, page, pageSize));
        }
        #endregion


        #region	Details
        [HttpGet]
        [Route("Api/vwCommonMasterDtl/Details")]
        public VwCommonMasterDtl Details(Int32 pCommonMasterId)
        {
            VwCommonMasterDtl objvwCommonMasterDtl = new VwCommonMasterDtl();
            if (pCommonMasterId != 0)
            {
                objvwCommonMasterDtl = objController.GetvwCommonMasterDtl(pCommonMasterId);
            }
            return (objvwCommonMasterDtl);
        }




        #endregion
    }
}
