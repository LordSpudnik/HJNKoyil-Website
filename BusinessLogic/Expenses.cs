using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HJNKoyil.Models;

namespace HJNKoyil.BusinessLogic
{
    public class Expenses
    {
        KoyilDbContext  _dbContext = new KoyilDbContext();
        #region	GetExpenses
        public IEnumerable<Expense> GetExpenses()
        {
            //Write Logic to get Expense here
            return _dbContext.Expense.ToList();
        }
        #endregion

        #region	CreateExpense
        public void CreateExpense(Expense expense)
        {
            //Write Logic to Create Expensehere
            _dbContext.Expense.Add(expense);
            _dbContext.SaveChanges();
        }

        public void UpdateExpense(Expense expense)
        {
            //Write Logic to Update Expensehere
            _dbContext.Entry(expense).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
        #endregion

        #region	GetCommonMasterDtls
        public IEnumerable<CommonMasterDtl> GetCommonMasterDtls()
        {
            //Write Logic to get CommonMasterDtl here

            return _dbContext.CommonMasterDtl.ToList();
        }
        #endregion

        #region	GetExpense
        public Expense GetExpense(System.Int32 pId)
        {
            //Write Logic to get Expense here
            return _dbContext.Expense.SingleOrDefault(x => x.Id == pId);
        }
        #endregion

        #region	DeleteExpense
        public void DeleteExpense(System.Int32 pId)
        {
            //Write Logic to Delete Expensehere
            Expense expense = _dbContext.Expense.SingleOrDefault(x => x.Id == pId);
            _dbContext.Expense.Remove(expense);
            _dbContext.SaveChanges();
        }
        #endregion
    }
}
