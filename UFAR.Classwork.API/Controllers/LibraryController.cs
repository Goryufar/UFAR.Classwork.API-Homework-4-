using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UFAR.Classwork.Core.Services;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        // DONT Forget to install nuget packages
        // Microsoft.EntityFrameworkCore
        // Microsoft.EntityFrameworkCore.SqlServer
        // Microsoft.EntityFrameworkCore.Tools
        // Microsoft.EntityFrameworkCore.Design



        // Dependency Injection
        // This is a private field
        // This field is of type ILibraryService
        // This field is used to call the methods of the LibraryService class
        // This field is used to call the methods of the ILibraryService interface
        // This field is used to call the methods of the LibraryService class that implements the ILibraryService interface
        public ILibraryService libraryService;

        // Injecting the ILibraryService interface into the LibraryController class
        // This is called Dependency Injection
        // This is a public constructor
        // This constructor takes in a parameter of type ILibraryService
        // This constructor is used to inject the ILibraryService interface into the LibraryController class
        // This constructor is used to inject the LibraryService class into the LibraryController class
        // We'll get access to LibraryService Object within LibraryController class constructor
        public LibraryController(ILibraryService _libraryService)
        {
            libraryService = _libraryService;
        }

        [HttpGet("List")]
        public IActionResult GetLibraries()
        {
            return Ok(libraryService.GetLibraries());
        }

        [HttpGet("GetLibraryById")]
        public IActionResult GetLibraryById(int libraryId)
        {
            return Ok(libraryService.GetLibraryById(libraryId));
        }


        // Calling Service layer method to get library by name
        [HttpGet("GetLibraryByName")]
        public IActionResult GetLibraryByName(string libraryName)
        {
            return Ok(libraryService.GetLibraryByName(libraryName));
        }

        [HttpPost("AddLibrary")]
        public IActionResult AddLibrary(LibraryEntity library)
        {
            libraryService.AddLibrary(library);
            return Ok();
        }

        [HttpDelete("RemoveLibrary")]
        public IActionResult RemoveLibrary(int libraryId)
        {
            libraryService.RemoveLibrary(libraryId);
            return Ok();
        }

        [HttpPut("UpdateLibrary")]  
        public IActionResult UpdateLibrary(LibraryEntity library)
        {
            libraryService.UpdateLibrary(library);
            return Ok();
        }

        [HttpDelete("DeleteLibrary")]
        public IActionResult DeleteLibrary(LibraryEntity library)
        {
            libraryService.DeleteLibrary(library);
            return Ok();
        }
    }
}
