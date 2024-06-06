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
    public class ExpenseController : ControllerBase
    {
        private HJNKoyil.BusinessLogic.Expenses objController = new HJNKoyil.BusinessLogic.Expenses();
        #region	List
        [HttpGet]
        [Route("Api/Expense/List")]
        public PagedList<Expense> List(int page = 1, int pageSize = 20)
        {
            var data = objController.GetExpenses().OrderByDescending(o => o.ExpenseDate).ToList();
            return (new PagedList<Expense>(data, page, pageSize));
        }
        #endregion


        #region	Create
        [HttpPost]
        [Route("Api/Expense/Create")]
        public Expense Create(Expense model)
        {
            if (model.Id == 0)
            {
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                objController.CreateExpense(model);
            }
            else
            {
                model.ModifiedDate = DateTime.Now;
                objController.UpdateExpense(model);
            }
            return model;
        }
        #endregion


        #region	Details
        [HttpGet]
        [Route("Api/Expense/Details")]
        public Expense Details(System.Int32 pId)
        {
            Expense objExpense = new Expense();
            if (pId != 0)
            {
                objExpense = objController.GetExpense(pId);
            }
            return (objExpense);
        }




        #endregion
    }
}
