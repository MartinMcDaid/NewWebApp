using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebApp.Models
{
    public class PhotoService : IPhotoRepository
    {
        private List<Photo> _photos;

        public PhotoService()
        {
            if(_photos == null)
            {
                InitializePhotos();
            }
        }

        private void InitializePhotos()
        {
            _photos = new List<Photo>
            {
                new Photo {PhotoId = 1, Title ="Cirque", Description = "Cirque de mafat", Location = "Ile de la Reunion", PhotoUrl="https://www.flickr.com/photos/martymcdaidphotography/13039257904/", Special = false },
                new Photo {PhotoId = 2, Title = "Spray", Description = "WaterFall", Location = "Austria", PhotoUrl = "https://www.flickr.com/photos/martymcdaidphotography/14265315951/", Special = false}
            };
        }

        public IEnumerable<Photo> GetAllPhotos()
        {
            return _photos;
        }
    }
}
