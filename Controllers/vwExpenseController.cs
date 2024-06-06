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
    public class vwExpenseController : ControllerBase
    {
        private HJNKoyil.BusinessLogic.vwExpenses objController = new HJNKoyil.BusinessLogic.vwExpenses();
        #region	List
        [HttpGet]
        [Route("Api/vwExpense/List")]
        public PagedList<VwExpense> List(int page = 1, int pageSize = 20)
        {
            var data = objController.GetvwExpenses().OrderByDescending (o=>o.ExpenseDate).ToList();
            return (new PagedList<VwExpense>(data, page, pageSize));
        }
        [Route("Api/vwExpense/ListPaidTo")]
        public PagedList<VwExpense> ListPaidTo(int pPaidTo, int page = 1, int pageSize = 20)
        {
            var data = objController.GetvwExpenses(pPaidTo).OrderByDescending(o => o.ExpenseDate).ToList();
            return (new PagedList<VwExpense>(data, page, pageSize));
        }

        #endregion


        #region	Details
        [HttpGet]
        [Route("Api/vwExpense/Details")]
        public VwExpense Details(System.Int32 pId)
        {
            VwExpense objvwExpense = new VwExpense();
            if (pId != 0)
            {
                objvwExpense = objController.GetvwExpense(pId);
            }
            return (objvwExpense);
        }




        #endregion
    }
}
