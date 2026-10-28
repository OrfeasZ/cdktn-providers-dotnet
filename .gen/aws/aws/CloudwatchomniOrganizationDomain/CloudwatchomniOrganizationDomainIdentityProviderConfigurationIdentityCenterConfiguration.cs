using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniOrganizationDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchomniOrganizationDomain.CloudwatchomniOrganizationDomainIdentityProviderConfigurationIdentityCenterConfiguration")]
    public class CloudwatchomniOrganizationDomainIdentityProviderConfigurationIdentityCenterConfiguration : aws.CloudwatchomniOrganizationDomain.ICloudwatchomniOrganizationDomainIdentityProviderConfigurationIdentityCenterConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_organization_domain#identity_center_instance_arn CloudwatchomniOrganizationDomain#identity_center_instance_arn}.</summary>
        [JsiiProperty(name: "identityCenterInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
        public string IdentityCenterInstanceArn
        {
            get;
            set;
        }
    }
}
