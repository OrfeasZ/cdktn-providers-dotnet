using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CleanroomsMembership
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cleanroomsMembership.CleanroomsMembershipPaymentConfigurationQueryCompute")]
    public class CleanroomsMembershipPaymentConfigurationQueryCompute : aws.CleanroomsMembership.ICleanroomsMembershipPaymentConfigurationQueryCompute
    {
        private object _isResponsible;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cleanrooms_membership#is_responsible CleanroomsMembership#is_responsible}.</summary>
        [JsiiProperty(name: "isResponsible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsResponsible
        {
            get => _isResponsible;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isResponsible = value;
            }
        }
    }
}
