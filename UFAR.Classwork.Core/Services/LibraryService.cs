using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UFAR.Classwork.Data.DAO;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.Core.Services
{
    // This class is a public class
    // This class is a LibraryService class
    // This class is a LibraryService class that implements the ILibraryService interface
    // this is business logic layer class service for library 
    public class LibraryService : ILibraryService
    {
        // This is called Dependency Injection
        // This is a private field
        // This field is of type ApplicationDbContext
        // This field is used to connect to a database
        // This will create object when we'll do call 
        ApplicationDbContext context;
        public LibraryService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public void AddLibrary(LibraryEntity library)
        {
           context.Add(library);
           context.SaveChanges();
        }

        // Soft Delete
        public void RemoveLibrary(int libraryId)
        {
            context.Libraries.FirstOrDefault(x => x.Id == libraryId).isDeleted = true;
            context.SaveChanges();
        }

        public void UpdateLibrary(LibraryEntity entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }

        // Hard Delete
        public void DeleteLibrary(LibraryEntity entity)
        {
            context.Remove(entity);
            context.SaveChanges();
        }

        public List<LibraryEntity> GetLibraries()
        {
            return context.Libraries.ToList();
        }

        public LibraryEntity GetLibraryById(int libraryId)
        {
            return context.Libraries.FirstOrDefault(x => x.Id == libraryId);
        }

        public LibraryEntity GetLibraryByName(string libraryName)
        {
            return context.Libraries.FirstOrDefault(x => x.Name == libraryName);
        }

        public List<LibraryEntity> GetLibraryByAddress(string libraryAddress)
        {
            return context.Libraries.Where(x => x.Address == libraryAddress).ToList();
        }
    }
}
