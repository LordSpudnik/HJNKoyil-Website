using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using System.Net.Http;
using X.PagedList;
using Microsoft.AspNetCore.Mvc;
using HJNKoyil.BusinessLogic;
using HJNKoyil.Models;

namespace HJNKoyil.Controllers
{
    public class CommonMasterDtlController : ControllerBase
    {
        private HJNKoyil.BusinessLogic.CommonMasterDtls objController = new HJNKoyil.BusinessLogic.CommonMasterDtls();
        #region	List
        [HttpGet]
        [Route("Api/CommonMasterDtl/List")]
        public PagedList<CommonMasterDtl> List(int pTypeID = 0, int page = 1, int pageSize = 10)
        {
            var data = objController.GetCommonMasterDtls(pTypeID).ToList();
            return (new PagedList<CommonMasterDtl>(data, page, pageSize));
        }
        #endregion


        #region	Create
        [HttpPost]
        [Route("Api/CommonMasterDtl/Create")]
        public CommonMasterDtl Create(CommonMasterDtl model)
        {
            if (model.Id == 0)
            {
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate= DateTime.Now;
                objController.CreateCommonMasterDtl(model);
            }
            else
            {
                model.ModifiedDate = DateTime.Now;
                objController.UpdateCommonMasterDtl(model);
            }
            return model;
        }
        #endregion


        #region	Details
        [HttpGet]
        [Route("Api/CommonMasterDtl/Details")]
        public CommonMasterDtl Details(System.Int32 pId)
        {
            CommonMasterDtl objCommonMasterDtl = new CommonMasterDtl();
            if (pId != 0)
            {
                objCommonMasterDtl = objController.GetCommonMasterDtl(pId);
            }
            return (objCommonMasterDtl);
        }




        #endregion
    }
}
