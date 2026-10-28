using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniOrganizationDomain
{
    [JsiiByValue(fqn: "aws.cloudwatchomniOrganizationDomain.CloudwatchomniOrganizationDomainIdentityProviderConfiguration")]
    public class CloudwatchomniOrganizationDomainIdentityProviderConfiguration : aws.CloudwatchomniOrganizationDomain.ICloudwatchomniOrganizationDomainIdentityProviderConfiguration
    {
        private object? _identityCenterConfiguration;

        /// <summary>identity_center_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_organization_domain#identity_center_configuration CloudwatchomniOrganizationDomain#identity_center_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudwatchomniOrganizationDomain.ICloudwatchomniOrganizationDomainIdentityProviderConfigurationIdentityCenterConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityCenterConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchomniOrganizationDomain.CloudwatchomniOrganizationDomainIdentityProviderConfigurationIdentityCenterConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IdentityCenterConfiguration
        {
            get => _identityCenterConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchomniOrganizationDomain.ICloudwatchomniOrganizationDomainIdentityProviderConfigurationIdentityCenterConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudwatchomniOrganizationDomain.ICloudwatchomniOrganizationDomainIdentityProviderConfigurationIdentityCenterConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _identityCenterConfiguration = value;
            }
        }
    }
}
