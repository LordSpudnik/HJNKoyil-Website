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
    public class DonationController : ControllerBase
    {
        private HJNKoyil.BusinessLogic.Donations objController = new HJNKoyil.BusinessLogic.Donations();
        #region	List
        [HttpGet]
        [Route("Api/Donation/List")]
        public PagedList<Donation> List(int page = 1, int pageSize = 10)
        {
            var data = objController.GetDonations().ToList();
            return (new PagedList<Donation>(data, page, pageSize));
        }
        #endregion


        #region	Create
        [HttpPost]
        [Route("Api/Donation/Create")]
        public Donation Create(Donation model)
        {
            if (model.Id == 0)
            {
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                objController.CreateDonation(model);
            }
            else
            {
                model.ModifiedDate = DateTime.Now;
                objController.UpdateDonation(model);
            }
            return model;
        }
        #endregion


        #region	Details
        [HttpGet]
        [Route("Api/Donation/Details")]
        public Donation Details(System.Int32 pId)
        {
            Donation objDonation = new Donation();
            if (pId != 0)
            {
                objDonation = objController.GetDonation(pId);
            }
            return (objDonation);
        }




        #endregion
    }
}
