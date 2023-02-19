using ePizza.UI.Helpers.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace ePizza.UI.Helpers
{
    public class FileHelper : IFileHelper
    {
        private IWebHostEnvironment _env; //bizim için dosya alıp verme işlemlerini gerçekleştirmektedir. sadece core tarafında mevcuttur. 

        public FileHelper(IWebHostEnvironment env)
        {
            _env = env;
        }

        private string GenerateFileName(string fileName)
        {
            string[]strName = fileName.Split('.');
            string strFileName = DateTime.Now.ToUniversalTime().ToString("yyyyMMdd\\THmmssfff") + "." + strName.Length;
            return strFileName;
        }

        public void DeleteFile(string imageUrl)
        {
            if (File.Exists(_env.WebRootPath + imageUrl))
            {
                File.Delete(_env.WebRootPath + imageUrl);
            }
        }

        public string UploadFile(IFormFile file)
        {
            throw new System.NotImplementedException();
        }
    }
}
