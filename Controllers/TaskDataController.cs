using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Repository.RepoImplementation;
using Repository.Interface;
using Repository;
using DataModel.DAL;

namespace Task_Management_System.Controllers  
{
    public class TaskDataController : ApiController
    {
        //TaskManagementSystemEntities dbContext = new TaskManagementSystemEntities();

       /* private IUnitofWork _unitwork;

        public TaskDataController()
        {
            this._unitwork = new UnitofWork(new TaskManagementSystemEntities());

        }
        public Tas

        
        /* public IEnumerable<QuoteSchedule> GetAll()
         {
             return 
         }

         [HttpGet]
         public IEnumerable<QuoteSchedule> Get()
         {
             List<QuoteSchedule> data = new List<QuoteSchedule>();
             return dbContext.QuoteSchedules.ToList();
         }

         [HttpPost]
         public void Post([FromBody] QuoteSchedule QS)
         {
             dbContext.QuoteSchedules.Add(QS);
             dbContext.SaveChanges();
         }

         [HttpPut]
         public void Put(int id, [FromBody]QuoteSchedule QS)
         {


             //var entity = dbContext.QuoteSchedules.FirstOrDefault(e => e.QuoteID == id);


             //entity.QuoteID = id;
             //entity.QuoteType = QS.QuoteType;
             //entity.Contact = QS.Contact;
             //entity.Task = QS.Task;
             //entity.DueDate = QS.DueDate;
             //entity.TaskType = QS.TaskType;

             dbContext.SaveChanges();
         }

         [HttpDelete]
         public void Delete(int id)
         {

         }
         */

    }
}
