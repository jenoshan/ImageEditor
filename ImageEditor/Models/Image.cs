using System.IO;

namespace ImageEditor.Models
{
    public class Image
    {
        public string Imagename { get; set; }
        public MemoryStream Actualimage { get; set; }
        public float Resize { get; set; }
        public float Blursize { get; set; }
        public bool Grayscale { get; set; }
    }
}
