using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc.Ajax;

namespace CareForU.Models.BaseClasses
{
    public class BaseAjax : AjaxOptions
    {

        public BaseAjax(string UpdateTargetID, string Method, string _OnSuccess,int LoadingDuration,string LoadingElementID)
        {
            UpdateTargetId = UpdateTargetID;
            HttpMethod = Method;
            InsertionMode = InsertionMode.Replace;
            OnSuccess = _OnSuccess;
            LoadingElementDuration = LoadingDuration;
            LoadingElementId = LoadingElementID;
        }
    }
}