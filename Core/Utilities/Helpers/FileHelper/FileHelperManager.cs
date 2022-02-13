using Microsoft.AspNetCore.Http;
using Core.Utilities.Helpers.GuidHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHelperManager : IFileHelper
    {
        public void Delete(string filePath)
        {
            if(File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public string Update(IFormFile file, string filePath, string root)
        {//IFormFile projemize bir dosya yüklemek için kulanılan yöntemdir, HttpRequest ile gönderilen bir dosyayı temsil eder.
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            return Upload(file, root);
        }

        public string Upload(IFormFile file, string root)
        {
           if(file.Length>0)//Dosya uzunluğunu byte olarak alır. Burada dosya gönderilip gönderilmediği kontrol ediliyor.
            {
                if(!Directory.Exists(root))//Directory=>System.IO'nun bir classı
                {//dosyanın kaydedileceği adres dizini var mı?
                    Directory.CreateDirectory(root);
                }
                string extension = Path.GetExtension(file.FileName);//seçilen dosyanın uzantısı elde edilir
                string guid = GuidHelperManager.CreateGuid();
                string filePath = guid + extension; //Dosyanın adı ve uzantısı yan yana=>...jpg

                using(FileStream fileStream=File.Create(root+filePath))
                {// FileStream, Stream ana soyut sınıfı kullanılarak genişletilmiş, belirtilen kaynak dosyalar üzerinde okuma/ yazma / atlama gibi operasyonları yapmamıza yardımcı olan bir sınıftır
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                    return filePath;
                }
            }
            return null;
        }
    }
}
