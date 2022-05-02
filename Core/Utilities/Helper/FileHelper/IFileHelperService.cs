using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Helper.FileHelper
{
    public interface IFileHelperService
    {
        string Upload(IFormFile file, string root);
        void Delete(string filePath);
        string Update(IFormFile file, string filePath, string root);
    }
}
