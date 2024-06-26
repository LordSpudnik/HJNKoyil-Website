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
using System.Net;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices.ObjectiveC;
using HJNKoyil.Pages.FileUploads;

namespace HJNKoyil.Controllers
{
    [ApiController]
    public class UploadFilesController : ControllerBase
    {
        KoyilDbContext _dbContext = new KoyilDbContext();

        private HJNKoyil.BusinessLogic.UploadFile objController = new HJNKoyil.BusinessLogic.UploadFile();
        #region	List
        [HttpGet]
        [Route("Api/UploadFiles/List")]
        public PagedList<Models.VwFileUpload> List(int page = 1, int pageSize = 100)
        {
            //string sConnection = _dbContext.Database.GetDbConnection().ConnectionString;
            //SqlConnection oConnection = new SqlConnection(sConnection);
            //oConnection.Open();
            //SqlCommand ocommand = oConnection.CreateCommand();
            //string sText = "SELECT TOP (1000) [Id], [FileName],[FileDescription],[IsActive],[CreatedBy],[CreatedDate],[ModifiedBy],[ModifiedDate] FROM [FileUploads]";
            //ocommand.CommandText = sText;
            //int nRows = ocommand.ExecuteNonQuery();
            
            var data = objController.GetUploadFiles().ToList();
            return (new PagedList<HJNKoyil.Models.VwFileUpload>(data, page, pageSize));
        }
        #endregion


        #region	Create
        [HttpPost]
        [Route("Api/UploadFiles/Create")]
        public Models.FileUpload Create(HJNKoyil.Models.FileUpload model)
        {
            if (model.Id == 0)
            {
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                objController.CreateUploadFiles(model);
            }
            else
            {
                model.ModifiedDate = DateTime.Now;
                objController.UpdateUploadFiles(model);
            }
            return model;
        }
        #endregion


        #region	Details
        [HttpGet]
        [Route("Api/UploadFiles/Details")]
        public Models.FileUpload Details(System.Int32 pId)
        {
            HJNKoyil.Models.FileUpload oModel = new HJNKoyil.Models.FileUpload();
            if (pId != 0)
            {
                oModel = objController.GetFileUpload(pId);
            }
            return (oModel);
        }




        #endregion
    }
}
