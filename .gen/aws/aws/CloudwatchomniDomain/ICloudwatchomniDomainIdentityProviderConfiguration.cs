using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniDomain
{
    [JsiiInterface(nativeType: typeof(ICloudwatchomniDomainIdentityProviderConfiguration), fullyQualifiedName: "aws.cloudwatchomniDomain.CloudwatchomniDomainIdentityProviderConfiguration")]
    public interface ICloudwatchomniDomainIdentityProviderConfiguration
    {
        /// <summary>identity_center_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/cloudwatchomni_domain#identity_center_configuration CloudwatchomniDomain#identity_center_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniDomain.ICloudwatchomniDomainIdentityProviderConfigurationIdentityCenterConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "identityCenterConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniDomain.CloudwatchomniDomainIdentityProviderConfigurationIdentityCenterConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IdentityCenterConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchomniDomainIdentityProviderConfiguration), fullyQualifiedName: "aws.cloudwatchomniDomain.CloudwatchomniDomainIdentityProviderConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchomniDomain.ICloudwatchomniDomainIdentityProviderConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>identity_center_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/cloudwatchomni_domain#identity_center_configuration CloudwatchomniDomain#identity_center_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniDomain.ICloudwatchomniDomainIdentityProviderConfigurationIdentityCenterConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityCenterConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniDomain.CloudwatchomniDomainIdentityProviderConfigurationIdentityCenterConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IdentityCenterConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
