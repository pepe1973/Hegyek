using System.Text;
using System.IO;

namespace Hegyek.FileKezeles
{
    class FileKiiras
    {
        public string FileNev { get; set; }

        public FileKiiras(string fileNev)
        {
            this.FileNev = fileNev;
        }

        public void Kiiras(string kiir)
        {
            using (StreamWriter sw = new StreamWriter(this.FileNev, false, Encoding.UTF8))
            {
                sw.Write(kiir);
            }
        }
    }
}
