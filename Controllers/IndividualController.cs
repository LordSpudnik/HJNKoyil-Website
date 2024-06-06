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
    public class IndividualController : ControllerBase
    {
        private HJNKoyil.BusinessLogic.Individuals objController = new HJNKoyil.BusinessLogic.Individuals();
        #region	List
        [HttpGet]
        [Route("Api/Individual/List")]
        public PagedList<Individual> List(int page = 1, int pageSize = 10)
        {
            var data = objController.GetIndividuals().ToList().OrderBy (o=>o.FullName);
            return (new PagedList<Individual>(data, page, pageSize));
        }
        public PagedList<Individual> List(string sSearch, int page = 1, int pageSize = 20)
        {
            var data = objController.GetIndividuals(sSearch).ToList().OrderBy(o => o.FullName);
            return (new PagedList<Individual>(data, page, pageSize));
        }

        #endregion


        #region	Create
        [HttpPost]
        [Route("Api/Individual/Create")]
        public Individual Create(Individual model)
        {
            if (model.Id == 0)
            {
                objController.CreateIndividual(model);
            }
            else
            {
                objController.UpdateIndividual(model);
            }
            return model;
        }
        #endregion


        #region	Details
        [HttpGet]
        [Route("Api/Individual/Details")]
        public Individual Details(System.Int32 pID)
        {
            Individual objIndividual = new Individual();
            if (pID != 0)
            {
                objIndividual = objController.GetIndividual(pID);
            }
            return (objIndividual);
        }




        #endregion
    }
}
