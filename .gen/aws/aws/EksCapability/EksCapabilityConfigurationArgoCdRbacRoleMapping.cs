using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCapability
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eksCapability.EksCapabilityConfigurationArgoCdRbacRoleMapping")]
    public class EksCapabilityConfigurationArgoCdRbacRoleMapping : aws.EksCapability.IEksCapabilityConfigurationArgoCdRbacRoleMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_capability#role EksCapability#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public string Role
        {
            get;
            set;
        }

        private object? _identity;

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_capability#identity EksCapability#identity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCapability.EksCapabilityConfigurationArgoCdRbacRoleMappingIdentity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Identity
        {
            get => _identity;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EksCapability.IEksCapabilityConfigurationArgoCdRbacRoleMappingIdentity[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EksCapability.IEksCapabilityConfigurationArgoCdRbacRoleMappingIdentity).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _identity = value;
            }
        }
    }
}
