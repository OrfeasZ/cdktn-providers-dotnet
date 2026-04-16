using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCapability
{
    [JsiiInterface(nativeType: typeof(IEksCapabilityConfiguration), fullyQualifiedName: "aws.eksCapability.EksCapabilityConfiguration")]
    public interface IEksCapabilityConfiguration
    {
        /// <summary>argo_cd block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_capability#argo_cd EksCapability#argo_cd}
        /// </remarks>
        [JsiiProperty(name: "argoCd", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCapability.EksCapabilityConfigurationArgoCd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ArgoCd
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksCapabilityConfiguration), fullyQualifiedName: "aws.eksCapability.EksCapabilityConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EksCapability.IEksCapabilityConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>argo_cd block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_capability#argo_cd EksCapability#argo_cd}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "argoCd", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCapability.EksCapabilityConfigurationArgoCd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ArgoCd
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
