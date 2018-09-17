using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SwaggerDemoApi.Enum;
using SwaggerDemoApi.Model;

namespace SwaggerDemoApi.Controllers
{
    /// <summary>
    /// Test
    /// </summary>
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        // GET api/employees
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }

        // GET api/employees/5
        /// <response code="200">Request completed Successfully</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Employee), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        [ProducesResponseType(500)]
        public IActionResult Get(Employee id)
        {
            // Get employee implementation
            return Ok(new Employee());
        }


        /// <summary>
        /// Creates a new employee
        /// </summary>
        /// <param name="employee">Employee Object</param>
        /// <param name="employeeType"></param>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /employee
        ///     {
        ///        "id": 007,
        ///        "name": "James Bond",
        ///        "isPermanant": true
        ///     }
        ///
        /// </remarks>
        // POST api/employees
        [HttpPost]
        public void Post([FromBody]Employee employee, EmployeeType employeeType)
        {
            // Create employee implementaion
        }

        // PUT api/employees/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }


        /// <summary>
        /// Deletes individual item by id.
        /// </summary>
        /// <param name="id">ID Value of the item</param>
        // DELETE api/employees/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            // Delete implementation
        }
    }
}
