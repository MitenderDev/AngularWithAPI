using AngularApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AngularApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        private readonly mydbContext _context;
        private readonly ILogger<UserLoginController> _logger;

        public UserLoginController(ILogger<UserLoginController> logger, mydbContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpPost]
        [Route("login")]
        public IActionResult login(LoginModel loginModel)
    
        {
            try
            {
                _logger.LogInformation("Login is Working");
                var data = _context.TblUserdata.Where(x => x.UserName == loginModel.UserName && x.Password == loginModel.Password).FirstOrDefault();
                if (data != null) 
                {                   
                    return Ok(loginModel.Result = true);
                }
                else
                {
                    return Ok(loginModel.Result = false);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine($"Exception occurred during login: {Ex.Message}");                
                return StatusCode(500, "Internal server error");
            }
            return Ok(loginModel);
        }

        [HttpGet]
        [Route("UserData")]
        public IActionResult UserData() 
        {
            try
            {
                _logger.LogInformation("getting user data");
                var userdata = _context.TblUserdata;
                return Ok( userdata );  
            }
            catch (Exception ex)
            {

            }
            return BadRequest();
        }

        [HttpGet]
        [Route("getAllEmployee")]
        public IActionResult getAllEmployee()
        {
            try
            {
                _logger.LogInformation("getting user data");
                var userdata = _context.TblEmployeedata;
                return Ok(userdata);
            }
            catch (Exception ex)
            {

            }
            return BadRequest();
        }

        //[HttpPost]
        //[Route("saveEmployee")]
        //public async Task<TblEmployeedatum> saveEmployee(TblEmployeedatum employeedata)
        //{

        //        _context.TblEmployeedata.Add(employeedata);
        //        await _context.SaveChangesAsync();
        //        return employeedata;



        //}

        [HttpPost]
        [Route("saveEmployee")]
        public async Task<IActionResult> SaveEmployee(TblEmployeedatum employeedata)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TblEmployeedata.Add(employeedata);
            await _context.SaveChangesAsync();

            return Ok(employeedata);
        }

        [HttpDelete]
        [Route("deleteEmployeeById/{id}")]
        public async Task<IActionResult> deleteEmployeeById(int id) 
        {
            var data = await _context.TblEmployeedata.FindAsync(id);
            if(data == null)
            {
                return NotFound();
            }
             _context.TblEmployeedata.Remove(data);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
