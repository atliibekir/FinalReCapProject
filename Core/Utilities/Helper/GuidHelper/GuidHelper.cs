using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Helper.GuidHelper
{
    public class GuidHelper
    {
        public static string CreateNewGuid()
        {
            return Guid.NewGuid().ToString();
        }

    }
}
