using System;

namespace Core.Utilities.Helper.FileHelper
{
    public class GuidHelper
    {
        public static string CreateNewGuid()
        {
            return Guid.NewGuid().ToString();
        }

    }
}
