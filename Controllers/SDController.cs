using StudentDatabase.Services.Students;
using StudentDatabase.Models;
using Microsoft.AspNetCore.Mvc;

namespace StudentDatabase.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class SDController : ControllerBase
    {
    private readonly ISDServices _sDServices;

    public SDController(ISDServices sDServices)
    {
        _sDServices = sDServices;
    }

    [HttpGet]
    [Route("GetList")]

    public List<Student> GetList()
    {
        return _sDServices.GetList();
    }

    [HttpGet]
    [Route("AddStudent/{firstN}/{lastN}/{urHobby}")]

    public List<Student> AddStudent(string firstN, string lastN, string urHobby)
    {
        return _sDServices.AddStudent(firstN, lastN, urHobby);
    }

    [HttpGet]
    [Route("RemoveStudent/{firstN}/{lastN}/{urHobby}")]

    public List<Student> RemoveStudent(string firstN, string lastN, string urHobby)
    {
        return _sDServices.RemoveStudent(firstN, lastN, urHobby);
    }

}
