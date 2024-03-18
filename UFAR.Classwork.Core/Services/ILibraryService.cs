using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.Core.Services
{
    public interface ILibraryService
    {
          void AddLibrary(LibraryEntity library);
          void RemoveLibrary(int libraryId);
          void UpdateLibrary(LibraryEntity entity);
          void DeleteLibrary(LibraryEntity entity);
          List<LibraryEntity> GetLibraries();
          LibraryEntity GetLibraryById(int libraryId);
          LibraryEntity GetLibraryByName(string libraryName);
    }
}
