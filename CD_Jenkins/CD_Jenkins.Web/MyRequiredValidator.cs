using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CD_Jenkins.Web
{
    public class CustomizedRequiredValidatorAdapter: RequiredAttributeAdapter
    {
        public CustomizedRequiredValidatorAdapter(ModelMetadata metadata,
                                    ControllerContext context,
                                    RequiredAttribute attribute)
            : base(metadata, context, attribute)
        {
            attribute.ErrorMessage = "Please enter value in {0}.";
            //attribute.ErrorMessageResourceType = typeof(Messages);
            //attribute.ErrorMessageResourceName = "PropertyValueRequired";
        }
    }
}