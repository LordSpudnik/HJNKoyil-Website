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
    public class vwDonationController : ControllerBase
    {
        private HJNKoyil.BusinessLogic.vwDonations objController = new HJNKoyil.BusinessLogic.vwDonations();
        #region	List
        [HttpGet]
        [Route("Api/vwDonation/List")]
        public PagedList<VwDonation> List(int page = 1, int pageSize = 20)
        {
            var data = objController.GetvwDonations().OrderByDescending(o => o.DonatedDate).ToList();
            return (new PagedList<HJNKoyil.Models.VwDonation>(data, page, pageSize));
        }

        [HttpGet]
        [Route("Api/vwDonation/List1")]
        public PagedList<VwDonation> ListDonatedBy(int pDonatedBy, int page = 1, int pageSize = 20)
        {
            var data = objController.GetvwDonations(pDonatedBy).OrderByDescending(o => o.DonatedDate).ToList();
            return (new PagedList<HJNKoyil.Models.VwDonation>(data, page, pageSize));
        }

        #endregion


        #region	Details
        [HttpGet]
        [Route("Api/vwDonation/Details")]
        public VwDonation Details(System.Int32 pId)
        {
            VwDonation objvwDonation = new VwDonation();
            if (pId != 0)
            {
                objvwDonation = objController.GetvwDonation(pId);
            }
            return (objvwDonation);
        }




        #endregion
    }
}
