using ImageEditor.Models;
using ImageEditor.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ImageEditor.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet("imagelist")]
        public IActionResult GetListImages([FromForm] List<IFormFile> images)
        {
            try
            {
                int i = 0;
                Image[] ListImages = new Image[images.Count()];

                foreach (var image in images)
                {
                    using (var ms = new MemoryStream())
                    {
                        image.CopyTo(ms);
                        ListImages[i] = new Image { Imagename = $"image_{i}", Actualimage = ms };
                    }  
                    i++;
                }

                return Ok(ListImages);
            }
            catch
            {
                return BadRequest();
            }           
        }

        [AllowAnonymous]
        [HttpGet("imageedit")]
        public IActionResult EditAnImage([FromBody] Image image)
        {
            try
            {
                ImageEditingService imageEditingService = new ImageEditingService(image);
                imageEditingService.ImageResize();
                imageEditingService.AddBlur();
                imageEditingService.ConvertToGrayscale();

                return Ok(imageEditingService._Image);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
