using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCapability
{
    [JsiiByValue(fqn: "aws.eksCapability.EksCapabilityConfigurationArgoCd")]
    public class EksCapabilityConfigurationArgoCd : aws.EksCapability.IEksCapabilityConfigurationArgoCd
    {
        private object? _awsIdc;

        /// <summary>aws_idc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_capability#aws_idc EksCapability#aws_idc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsIdc", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCapability.EksCapabilityConfigurationArgoCdAwsIdc\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AwsIdc
        {
            get => _awsIdc;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EksCapability.IEksCapabilityConfigurationArgoCdAwsIdc[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EksCapability.IEksCapabilityConfigurationArgoCdAwsIdc).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _awsIdc = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_capability#namespace EksCapability#namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        private object? _networkAccess;

        /// <summary>network_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_capability#network_access EksCapability#network_access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkAccess", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCapability.EksCapabilityConfigurationArgoCdNetworkAccess\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkAccess
        {
            get => _networkAccess;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EksCapability.IEksCapabilityConfigurationArgoCdNetworkAccess[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EksCapability.IEksCapabilityConfigurationArgoCdNetworkAccess).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkAccess = value;
            }
        }

        private object? _rbacRoleMapping;

        /// <summary>rbac_role_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_capability#rbac_role_mapping EksCapability#rbac_role_mapping}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rbacRoleMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCapability.EksCapabilityConfigurationArgoCdRbacRoleMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RbacRoleMapping
        {
            get => _rbacRoleMapping;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EksCapability.IEksCapabilityConfigurationArgoCdRbacRoleMapping[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EksCapability.IEksCapabilityConfigurationArgoCdRbacRoleMapping).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rbacRoleMapping = value;
            }
        }
    }
}
