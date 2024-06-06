using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HJNKoyil.Models;

namespace HJNKoyil.BusinessLogic
{
    public class vwCommonMasterDtls
    {
        KoyilDbContext _dbContext = new KoyilDbContext();
        #region	GetvwCommonMasterDtls
        public IEnumerable<VwCommonMasterDtl> GetvwCommonMasterDtls(int pType = 0)
        {
            //Write Logic to get vwCommonMasterDtl here
            if (pType != 0)
                return _dbContext.VwCommonMasterDtl.Where (o=>o.CommonMasterId == pType) .ToList();
            else
                return _dbContext.VwCommonMasterDtl.ToList();
        }
        #endregion

        #region	GetvwCommonMasterDtl
        public VwCommonMasterDtl GetvwCommonMasterDtl(Int32 pCommonMasterId)
        {
            //Write Logic to get vwCommonMasterDtl here
            return _dbContext.VwCommonMasterDtl.SingleOrDefault(x => x.CommonMasterId == pCommonMasterId);
        }
        #endregion

        #region	DeletevwCommonMasterDtl
        public void DeletevwCommonMasterDtl(Int32 pCommonMasterId)
        {
            //Write Logic to Delete vwCommonMasterDtlhere
            VwCommonMasterDtl vwcommonmasterdtl = _dbContext.VwCommonMasterDtl.SingleOrDefault(x => x.CommonMasterId == pCommonMasterId);
            _dbContext.VwCommonMasterDtl.Remove(vwcommonmasterdtl);
            _dbContext.SaveChanges();
        }
        #endregion
    }
}
