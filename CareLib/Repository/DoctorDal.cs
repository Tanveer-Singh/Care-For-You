using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CareLib.Models;

namespace CareLib.Repository
{
    public class DoctorDal : ICareDoctor
    {
        CareForYouEntities _db;

        public DoctorDal(CareForYouEntities db)
        {
            _db = db;
        }
        public List<CareLib.ViewModel.DoctorViewModel> getAllDoctors()
        {

            var getallDocs = (from doc in _db.doctors
                              join docDetails in _db.DoctorDetails
                              on doc.docid equals docDetails.docid
                              select new CareLib.ViewModel.DoctorViewModel()
                              {

                                  DoctorDob = doc.Dob,
                                  DocEmail = doc.DocEmail,
                                  DocID = doc.docid,
                                  DocPhoto = (doc.DocPhoto ?? "nophoto.jpg"),
                                  DoctorFullName = doc.DoctorName + " " + (doc.DoctorMiddleName ?? "") + " " + doc.DoctorLastName,
                                  Sex = doc.sex,
                                  DocDescription = docDetails.docDescription,
                                  Docfbacc = docDetails.fbaccount,
                                  Docgoogleacc = docDetails.googleacc,
                                  Doctwitteracc = docDetails.twitteracc,
                                  Doclinkdnacc = docDetails.linkdn
                              }).ToList();

            //var getallDocs = (from doc in _db.doctors
            //                  join docdetails in _db.DoctorDetails
            //                  on doc.docid equals docdetails.id
            //                  select doc).ToList();

            //var getallDocs = (from doc in _db.doctors
            //                  join docDetails in _db.DoctorDetails
            //                  on doc.docid equals docDetails.docid
            //                  select new
            //                  {
            //                      Doc = new List<doctor>(){new doctor(){
            //                          Dob = doc.Dob,
            //                          DocEmail = doc.DocEmail,
            //                          docid = doc.docid,
            //                          DocPhoto = doc.DocPhoto,
            //                          DoctorName = doc.DoctorName + " " + doc.DoctorMiddleName + " " + doc.DoctorLastName,
            //                          sex = doc.sex

            //                      }},
            //                      DocDetails = new List<DoctorDetail>() {
            //                          new DoctorDetail(){
            //                              docDescription=docDetails.docDescription,
            //                              fbaccount=docDetails.fbaccount,
            //                              googleacc=docDetails.googleacc,
            //                              twitteracc=docDetails.twitteracc,
            //                              linkdn=docDetails.linkdn
            //                          } }
            //                  }).AsQueryable();

            return getallDocs;

        }
    }
}
