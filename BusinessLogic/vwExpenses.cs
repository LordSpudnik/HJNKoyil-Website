using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HJNKoyil.Models;

namespace HJNKoyil.BusinessLogic
{
    public class vwExpenses
    {
        KoyilDbContext _dbContext = new KoyilDbContext();
        #region	GetvwExpenses
        public IEnumerable<HJNKoyil.Models.VwExpense> GetvwExpenses(int pPaidTo=0)
        {
            //Write Logic to get vwExpense here
            if (pPaidTo !=0)
                return _dbContext.VwExpense.Where (o=>o.ServiceProviderId == pPaidTo).ToList();
            else
               return _dbContext.VwExpense.ToList();
        }
        #endregion

        #region	GetvwExpense
        public HJNKoyil.Models.VwExpense? GetvwExpense(System.Int32 pId)
        {
            //Write Logic to get vwExpense here
            return _dbContext.VwExpense.SingleOrDefault(x => x.Id == pId);
        }
        #endregion

        #region	DeletevwExpense
        public void DeletevwExpense(System.Int32 pId)
        {
            //Write Logic to Delete vwExpensehere
            VwExpense vwexpense = _dbContext.VwExpense.SingleOrDefault(x => x.Id == pId);
            _dbContext.VwExpense.Remove(vwexpense);
            _dbContext.SaveChanges();
        }
        #endregion
    }
}
