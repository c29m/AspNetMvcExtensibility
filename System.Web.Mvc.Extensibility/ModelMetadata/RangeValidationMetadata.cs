#region Copyright
/// Copyright (c) 2009, Kazi Manzur Rashid <kazimanzurrashid@gmail.com>.
/// This source is subject to the Microsoft Public License. 
/// See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL. 
/// All other rights reserved.
#endregion

namespace System.Web.Mvc.Extensibility
{
    public class RangeValidationMetadata<TNumeric> : ModelValidationMetadataBase
    {
        public TNumeric Minimum
        {
            get;
            set;
        }

        public TNumeric Maximum
        {
            get;
            set;
        }

        protected override ModelValidator CreateValidatorCore(ExtendedModelMetadata modelMetadata, ControllerContext context)
        {
            return new ExtendedRangeValidator<TNumeric>(modelMetadata, context, this);
        }
    }
}