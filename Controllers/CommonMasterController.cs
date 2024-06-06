using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using System.Net.Http;
using X.PagedList;
using Microsoft.AspNetCore.Mvc;
using HJNKoyil.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HJNKoyil.Controllers
{
    public class CommonMasterController : ControllerBase
    {
        private HJNKoyil.BusinessLogic.CommonMasters objController = new HJNKoyil.BusinessLogic.CommonMasters();
        #region	List
        [HttpGet]
        [Route("Api/CommonMaster/List")]
        public PagedList<CommonMaster> List(int page = 1, int pageSize = 10)
        {
            var data = objController.GetCommonMasters().ToList();
            return (new PagedList<HJNKoyil.Models.CommonMaster>(data, page, pageSize));
        }
        #endregion


        #region	Create
        [HttpPost]
        [Route("Api/CommonMaster/Create")]
        public CommonMaster Create(HJNKoyil.Models.CommonMaster model)
        {
            if (model.Id == 0)
            {
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                objController.CreateCommonMaster(model);
            }
            else
            {
                model.ModifiedDate = DateTime.Now;
                objController.UpdateCommonMaster(model);
            }
            return model;
        }
        #endregion


        #region	Details
        [HttpGet]
        [Route("Api/CommonMaster/Details")]
        public CommonMaster Details(System.Int32 pId)
        {
            HJNKoyil.Models.CommonMaster objCommonMaster = new HJNKoyil.Models.CommonMaster();
            if (pId != 0)
            {
                objCommonMaster = objController.GetCommonMaster(pId);
            }
            return (objCommonMaster);
        }




        #endregion
    }
}
