using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using CareLib.Repository;


namespace CareLib.Models
{
    [MetadataType(typeof(DoctorMetaData))]
    public partial class doctor
    { }


    public class DoctorMetaData
    {
        public string DoctorName { get; set; }
        public string DoctorMiddleName { get; set; }
        public string DoctorLastName { get; set; }

        public virtual List<DoctorDetail> DocDetails { get; set; }
        public string DoctorFullName
        {
            get
            {
                return DoctorName + " " + DoctorMiddleName + " " + DoctorLastName;
            }
        }
    }

    [MetadataType(typeof(HomeContentMetaData))]    
    public partial class HomeContent
    {
        //assigning default values
        public HomeContent()
        {
            IsDeleted = CareConstants.IsDeleted;
            CreatedDate = CareConstants.CreatedDate;

        }
    }
    

    public class HomeContentMetaData
    {
        [Required(ErrorMessage = "Please Enter Home Header")]
        [StringLength(30)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", 
            ErrorMessage ="Numbers and special characters are not allowed in the name.")]
        public string HomeHeader { get; set; }
        [Required(ErrorMessage = "Please Enter Home Content Text"),
        StringLength(100)]
        [DataType(DataType.MultilineText)]
        public string HomeText { get; set; }
        public string HomeImage { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",ErrorMessage="Not a valid email")]
        public string HomeEmail { get; set; }
        [Required(ErrorMessage="Please enter valid url")]
        [RegularExpression(@"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$",
            ErrorMessage="Please enter valid url")]
        public string HomeUrl { get; set; }


    }
}
