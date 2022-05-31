﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Helper.FileHelper
{
    public interface IFileHelperService
    {
        public string Upload(IFormFile file, string root);
        public void Delete(string filePath);
        public string Update(IFormFile file, string filePath, string root);
    }
}
