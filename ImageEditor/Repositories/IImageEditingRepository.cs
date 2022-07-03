using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageEditor.Repositories
{
    public interface IImageEditingRepository
    {
        public void ImageResize();
        public void AddBlur();
        public void ConvertToGrayscale();
    }
}
