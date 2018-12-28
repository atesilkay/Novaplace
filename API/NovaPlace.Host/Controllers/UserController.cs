using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPlace.Host.Controllers
{


    [Route("novaplacehost/users")]
    [ApiController]
    public class UserController: ControllerBase
    {
        //private IDomainService domainService;
       public UserController()
        {
        }

        [Route("")]
        [HttpGet]
        public string Get()
        {

            //domainService.CreateSegment(segment);
            return "1v2";

        }

        [Route("")]
        [HttpPost]
        public void Create([FromBody] int request)
        {
            
            //domainService.CreateSegment(segment);
            
            
        }

        [Route("{id}")]
        [HttpPut]
        public void Update(int id, [FromBody] int request)
        {

            //domainService.CreateSegment(segment);
        }


        [Route("{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
           // domainService.DeleteSegment(id, 1);
        }
    }
}

