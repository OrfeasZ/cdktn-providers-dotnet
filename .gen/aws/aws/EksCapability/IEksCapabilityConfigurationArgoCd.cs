using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCapability
{
    [JsiiInterface(nativeType: typeof(IEksCapabilityConfigurationArgoCd), fullyQualifiedName: "aws.eksCapability.EksCapabilityConfigurationArgoCd")]
    public interface IEksCapabilityConfigurationArgoCd
    {
        /// <summary>aws_idc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_capability#aws_idc EksCapability#aws_idc}
        /// </remarks>
        [JsiiProperty(name: "awsIdc", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCapability.EksCapabilityConfigurationArgoCdAwsIdc\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AwsIdc
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_capability#namespace EksCapability#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_capability#network_access EksCapability#network_access}
        /// </remarks>
        [JsiiProperty(name: "networkAccess", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCapability.EksCapabilityConfigurationArgoCdNetworkAccess\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkAccess
        {
            get
            {
                return null;
            }
        }

        /// <summary>rbac_role_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_capability#rbac_role_mapping EksCapability#rbac_role_mapping}
        /// </remarks>
        [JsiiProperty(name: "rbacRoleMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCapability.EksCapabilityConfigurationArgoCdRbacRoleMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RbacRoleMapping
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksCapabilityConfigurationArgoCd), fullyQualifiedName: "aws.eksCapability.EksCapabilityConfigurationArgoCd")]
        internal sealed class _Proxy : DeputyBase, aws.EksCapability.IEksCapabilityConfigurationArgoCd
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>aws_idc block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_capability#aws_idc EksCapability#aws_idc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsIdc", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCapability.EksCapabilityConfigurationArgoCdAwsIdc\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AwsIdc
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_capability#namespace EksCapability#namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>network_access block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_capability#network_access EksCapability#network_access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkAccess", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCapability.EksCapabilityConfigurationArgoCdNetworkAccess\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkAccess
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>rbac_role_mapping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_capability#rbac_role_mapping EksCapability#rbac_role_mapping}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rbacRoleMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCapability.EksCapabilityConfigurationArgoCdRbacRoleMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RbacRoleMapping
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
