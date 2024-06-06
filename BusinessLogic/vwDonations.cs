using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HJNKoyil.Models;

namespace HJNKoyil.BusinessLogic
{
    public class vwDonations
    {
        KoyilDbContext _dbContext = new KoyilDbContext();
        #region	GetvwDonations
        public IEnumerable<VwDonation> GetvwDonations(int pDonatedBy=0)
        {
            //Write Logic to get vwDonation here
            if (pDonatedBy  !=0)
            {
                return _dbContext.VwDonation.Where (o=>o.DonatedBy == pDonatedBy) .ToList();
            }
            else
               return _dbContext.VwDonation.ToList();
        }

        #endregion

        #region	GetvwDonation
        public VwDonation GetvwDonation(System.Int32 pId)
        {
            //Write Logic to get vwDonation here
            return _dbContext.VwDonation.SingleOrDefault(x => x.Id == pId);
        }
        #endregion

        #region	DeletevwDonation
        public void DeletevwDonation(System.Int32 pId)
        {
            //Write Logic to Delete vwDonationhere
            VwDonation vwdonation = _dbContext.VwDonation.SingleOrDefault(x => x.Id == pId);
            _dbContext.VwDonation.Remove(vwdonation);
            _dbContext.SaveChanges();
        }
        #endregion
    }
}
