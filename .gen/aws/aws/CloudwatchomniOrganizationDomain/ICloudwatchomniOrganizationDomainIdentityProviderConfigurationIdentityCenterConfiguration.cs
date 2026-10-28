using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniOrganizationDomain
{
    [JsiiInterface(nativeType: typeof(ICloudwatchomniOrganizationDomainIdentityProviderConfigurationIdentityCenterConfiguration), fullyQualifiedName: "aws.cloudwatchomniOrganizationDomain.CloudwatchomniOrganizationDomainIdentityProviderConfigurationIdentityCenterConfiguration")]
    public interface ICloudwatchomniOrganizationDomainIdentityProviderConfigurationIdentityCenterConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_organization_domain#identity_center_instance_arn CloudwatchomniOrganizationDomain#identity_center_instance_arn}.</summary>
        [JsiiProperty(name: "identityCenterInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityCenterInstanceArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchomniOrganizationDomainIdentityProviderConfigurationIdentityCenterConfiguration), fullyQualifiedName: "aws.cloudwatchomniOrganizationDomain.CloudwatchomniOrganizationDomainIdentityProviderConfigurationIdentityCenterConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchomniOrganizationDomain.ICloudwatchomniOrganizationDomainIdentityProviderConfigurationIdentityCenterConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_organization_domain#identity_center_instance_arn CloudwatchomniOrganizationDomain#identity_center_instance_arn}.</summary>
            [JsiiProperty(name: "identityCenterInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityCenterInstanceArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
