using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCapability
{
    [JsiiInterface(nativeType: typeof(IEksCapabilityConfigurationArgoCdRbacRoleMapping), fullyQualifiedName: "aws.eksCapability.EksCapabilityConfigurationArgoCdRbacRoleMapping")]
    public interface IEksCapabilityConfigurationArgoCdRbacRoleMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_capability#role EksCapability#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        string Role
        {
            get;
        }

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_capability#identity EksCapability#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCapability.EksCapabilityConfigurationArgoCdRbacRoleMappingIdentity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Identity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksCapabilityConfigurationArgoCdRbacRoleMapping), fullyQualifiedName: "aws.eksCapability.EksCapabilityConfigurationArgoCdRbacRoleMapping")]
        internal sealed class _Proxy : DeputyBase, aws.EksCapability.IEksCapabilityConfigurationArgoCdRbacRoleMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_capability#role EksCapability#role}.</summary>
            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
            public string Role
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_capability#identity EksCapability#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCapability.EksCapabilityConfigurationArgoCdRbacRoleMappingIdentity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Identity
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
