using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCapability
{
    [JsiiByValue(fqn: "aws.eksCapability.EksCapabilityConfiguration")]
    public class EksCapabilityConfiguration : aws.EksCapability.IEksCapabilityConfiguration
    {
        private object? _argoCd;

        /// <summary>argo_cd block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_capability#argo_cd EksCapability#argo_cd}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "argoCd", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCapability.EksCapabilityConfigurationArgoCd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ArgoCd
        {
            get => _argoCd;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EksCapability.IEksCapabilityConfigurationArgoCd[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EksCapability.IEksCapabilityConfigurationArgoCd).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _argoCd = value;
            }
        }
    }
}
