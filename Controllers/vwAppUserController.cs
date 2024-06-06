//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using System.Net.Http;
using X.PagedList;
using HJNKoyil.BusinessLogic;
using HJNKoyil.Models;



namespace HJNKoyil.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class vwAppUserController : ControllerBase
    {
        KoyilDbContext _dbContext = new KoyilDbContext();
        #region	GetDonations
        [HttpGet]
        [Route("Api/AppUser/List")]
        public IEnumerable<vwAppUsers> GetUsers()
        {
            //Write Logic to get Donation here
            return _dbContext.VwAppUsers.ToList();
        }
        #endregion

        #region	GetUser
        [HttpGet]
        [Route("Api/AppUser/Details")]
        public vwAppUsers GetUser(string pId)
        {
            //Write Logic to get Donation here
            return _dbContext.VwAppUsers.SingleOrDefault(x => x.Id == pId);
        }
        #endregion

    }

}

