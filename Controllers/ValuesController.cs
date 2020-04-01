using DataModel.DAL;
using Repository.Interface;
using Repository.RepoImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using DataModel.Model_DTO;
using System.Web.Http;
using Task_Management_System.Filters;
using System.Web.Http.Description;

namespace Task_Management_System.Controllers
{
    [Authorize]
    [CustomExceptionFilter]
    public class ValuesController : ApiController
    {

        private IUnitofWork _unitwork;

        public ValuesController()
        {
            this._unitwork = new UnitofWork(new TaskManagementSystemEntities());

        }
        public ValuesController(IUnitofWork repo)
        {
            _unitwork = repo;
        }


        // GET api/values
        public IEnumerable<QuoteSchedule> GetAll()
        {
            return _unitwork.QuoteSchedules.GetAll();
        }

        [ResponseType(typeof(QuoteSchedule))]
        public IHttpActionResult GetUnique(int id)
        {
            var data = _unitwork.QuoteSchedules.GetbyID(id);
            if(data == null)
            {
                throw new ExceptionRepo("Record Not Found, It may be removed!");
            }
            return Ok(data);
        }

        // GET api/values/5
        public IEnumerable<QuoteDTO> Get()
        {
             return _unitwork.QuoteSchedules.Get();
            
           
        }

        // POST api/values
        public void Post([FromBody]QuoteSchedule QS)
        {
            _unitwork.QuoteSchedules.Post(QS);
            _unitwork.Complete();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]QuoteSchedule QS)
        {
            QS.QuoteID = id;
            _unitwork.QuoteSchedules.Put(QS);
            _unitwork.Complete();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            _unitwork.QuoteSchedules.Delete(id);
            _unitwork.Complete();
        }
    }
}
