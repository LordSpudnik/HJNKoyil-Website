using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HJNKoyil.Models;

namespace HJNKoyil.BusinessLogic
{
    public class CommonMasters
    {
        KoyilDbContext _dbContext = new KoyilDbContext();
        #region	GetCommonMasters
        public IEnumerable<CommonMaster> GetCommonMasters()
        {
            //Write Logic to get CommonMaster here
            return _dbContext.CommonMaster.ToList();
        }
        #endregion

        #region	CreateCommonMaster
        public void CreateCommonMaster(CommonMaster commonmaster)
        {
            //Write Logic to Create CommonMasterhere
            _dbContext.CommonMaster.Add(commonmaster);
            _dbContext.SaveChanges();
        }

        public void UpdateCommonMaster(CommonMaster commonmaster)
        {
            //Write Logic to Update CommonMasterhere
            _dbContext.Entry(commonmaster).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
        #endregion

        #region	GetCommonMaster
        public CommonMaster GetCommonMaster(System.Int32 pId)
        {
            //Write Logic to get CommonMaster here
            return _dbContext.CommonMaster.SingleOrDefault(x => x.Id == pId);
        }
        #endregion

        #region	DeleteCommonMaster
        public void DeleteCommonMaster(System.Int32 pId)
        {
            //Write Logic to Delete CommonMasterhere
            CommonMaster commonmaster = _dbContext.CommonMaster.SingleOrDefault(x => x.Id == pId);
            _dbContext.CommonMaster.Remove(commonmaster);
            _dbContext.SaveChanges();
        }
        #endregion
    }
}
