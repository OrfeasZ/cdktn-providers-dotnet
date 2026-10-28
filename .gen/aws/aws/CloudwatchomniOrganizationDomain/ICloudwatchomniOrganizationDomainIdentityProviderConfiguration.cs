using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniOrganizationDomain
{
    [JsiiInterface(nativeType: typeof(ICloudwatchomniOrganizationDomainIdentityProviderConfiguration), fullyQualifiedName: "aws.cloudwatchomniOrganizationDomain.CloudwatchomniOrganizationDomainIdentityProviderConfiguration")]
    public interface ICloudwatchomniOrganizationDomainIdentityProviderConfiguration
    {
        /// <summary>identity_center_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_organization_domain#identity_center_configuration CloudwatchomniOrganizationDomain#identity_center_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniOrganizationDomain.ICloudwatchomniOrganizationDomainIdentityProviderConfigurationIdentityCenterConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "identityCenterConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniOrganizationDomain.CloudwatchomniOrganizationDomainIdentityProviderConfigurationIdentityCenterConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IdentityCenterConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchomniOrganizationDomainIdentityProviderConfiguration), fullyQualifiedName: "aws.cloudwatchomniOrganizationDomain.CloudwatchomniOrganizationDomainIdentityProviderConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchomniOrganizationDomain.ICloudwatchomniOrganizationDomainIdentityProviderConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>identity_center_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_organization_domain#identity_center_configuration CloudwatchomniOrganizationDomain#identity_center_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniOrganizationDomain.ICloudwatchomniOrganizationDomainIdentityProviderConfigurationIdentityCenterConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityCenterConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniOrganizationDomain.CloudwatchomniOrganizationDomainIdentityProviderConfigurationIdentityCenterConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IdentityCenterConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
