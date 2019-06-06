using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebApp.Models
{
    public interface IPhotoRepository
    {
        IEnumerable<Photo> GetAllPhotos();
        
    }
}
