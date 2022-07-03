using ImageEditor.Models;
using ImageEditor.Repositories;

namespace ImageEditor.Services
{
    public class ImageEditingService : IImageEditingRepository
    {
        public Image _Image;

        public ImageEditingService(Image image)
        {
            _Image = image;
        }

        public void ImageResize()
        {
            if (_Image.Resize > 0.0f)
            {
                // Apply Effect
            }
        }

        public void AddBlur()
        {
            if (_Image.Blursize > 0.0f)
            {
                // Apply Effect
            }
        }

        public void ConvertToGrayscale()
        {
            if (_Image.Grayscale)
            {
                // Apply Effect
            }
        }
    }
}
