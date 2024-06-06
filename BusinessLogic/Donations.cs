using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HJNKoyil.Models;
using HJNKoyil.BusinessLogic;


namespace HJNKoyil.BusinessLogic
{
    public class Donations
    {
        KoyilDbContext _dbContext = new KoyilDbContext();
        #region	GetDonations
        public IEnumerable<Donation> GetDonations()
        {
            //Write Logic to get Donation here
            return _dbContext.Donation.ToList();
        }
        #endregion

        #region	CreateDonation
        public void CreateDonation(Donation donation)
        {
            //Write Logic to Create Donationhere
            _dbContext.Donation.Add(donation);
            _dbContext.SaveChanges();
        }

        public void UpdateDonation(Donation donation)
        {
            //Write Logic to Update Donationhere
            _dbContext.Entry(donation).State = EntityState.Modified;
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

        #region	GetDonation
        public Donation GetDonation(System.Int32 pId)
        {
            //Write Logic to get Donation here
            return _dbContext.Donation.SingleOrDefault(x => x.Id == pId);
        }
        #endregion

        #region	DeleteDonation
        public void DeleteDonation(System.Int32 pId)
        {
            //Write Logic to Delete Donationhere
            Donation donation = _dbContext.Donation.SingleOrDefault(x => x.Id == pId);
            _dbContext.Donation.Remove(donation);
            _dbContext.SaveChanges();
        }
        #endregion
    }
}
