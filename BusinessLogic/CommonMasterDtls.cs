using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HJNKoyil.Models;

namespace HJNKoyil.BusinessLogic
{
    public class CommonMasterDtls
    {
        KoyilDbContext _dbContext = new KoyilDbContext();
        #region	GetCommonMasterDtls
        public IEnumerable<CommonMasterDtl> GetCommonMasterDtls(int pTypeID=0)
        {
            //Write Logic to get CommonMasterDtl here
            if (pTypeID == 0)
                return _dbContext.CommonMasterDtl.ToList();
            else
                return _dbContext.CommonMasterDtl.Where(o => o.CommonMasterId == pTypeID).ToList();
        }
        #endregion

        #region	CreateCommonMasterDtl
        public void CreateCommonMasterDtl(CommonMasterDtl commonmasterdtl)
        {
            //Write Logic to Create CommonMasterDtlhere
            _dbContext.CommonMasterDtl.Add(commonmasterdtl);
            _dbContext.SaveChanges();
        }

        public void UpdateCommonMasterDtl(CommonMasterDtl commonmasterdtl)
        {
            //Write Logic to Update CommonMasterDtlhere
            _dbContext.Entry(commonmasterdtl).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
        #endregion

        #region	GetCommonMasterDtl
        public CommonMasterDtl GetCommonMasterDtl(System.Int32 pId)
        {
            //Write Logic to get CommonMasterDtl here
            return _dbContext.CommonMasterDtl.SingleOrDefault(x => x.Id == pId);
        }
        #endregion

        #region	DeleteCommonMasterDtl
        public void DeleteCommonMasterDtl(System.Int32 pId)
        {
            //Write Logic to Delete CommonMasterDtlhere
            CommonMasterDtl commonmasterdtl = _dbContext.CommonMasterDtl.SingleOrDefault(x => x.Id == pId);
            _dbContext.CommonMasterDtl.Remove(commonmasterdtl);
            _dbContext.SaveChanges();
        }
        #endregion
    }
}
