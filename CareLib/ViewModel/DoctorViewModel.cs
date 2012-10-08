using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CareLib.Models;

namespace CareLib.ViewModel
{
    public class DoctorViewModel
    {
        public int DocID { get; set; }
        public string  DoctorFullName { get; set; }
        public DateTime? DoctorDob { get; set; }
        public string Sex { get; set; }
        public string DocPhoto { get; set; }
        public string DocEmail { get; set; }
        public string DocDescription { get; set; }
        public string Docfbacc { get; set; }
        public string Docgoogleacc { get; set; }
        public string Doctwitteracc { get; set; }
        public string Doclinkdnacc { get; set; }

    }
}
