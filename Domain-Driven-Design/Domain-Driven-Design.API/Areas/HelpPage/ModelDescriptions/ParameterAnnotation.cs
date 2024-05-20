using System;

namespace Domain_Driven_Design.API.Areas.HelpPage.ModelDescriptions
{
    public class ParameterAnnotation
    {
        public Attribute AnnotationAttribute { get; set; }

        public string Documentation { get; set; }
    }
}