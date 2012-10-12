using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareLib.Repository
{
    public interface ICareDoctor
    {

        List<CareLib.ViewModel.DoctorViewModel> getAllDoctors();
        CareLib.Models.DoctorDetail GetDoctorDetailsByID(int DocID);
    }
}
