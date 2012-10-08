using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareLib.Models
{
    public class CareConstants
    {

        public const bool IsDeleted = false;
        public static readonly DateTime CreatedDate = DateTime.Now;
    }

    public enum CareRules
    {
        SuperAdmin,
        Admin,
        Users
    }

}
