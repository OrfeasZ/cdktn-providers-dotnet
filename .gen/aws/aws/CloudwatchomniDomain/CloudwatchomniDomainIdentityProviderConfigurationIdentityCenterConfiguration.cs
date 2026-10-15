using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchomniDomain.CloudwatchomniDomainIdentityProviderConfigurationIdentityCenterConfiguration")]
    public class CloudwatchomniDomainIdentityProviderConfigurationIdentityCenterConfiguration : aws.CloudwatchomniDomain.ICloudwatchomniDomainIdentityProviderConfigurationIdentityCenterConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.1/docs/resources/cloudwatchomni_domain#identity_center_instance_arn CloudwatchomniDomain#identity_center_instance_arn}.</summary>
        [JsiiProperty(name: "identityCenterInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
        public string IdentityCenterInstanceArn
        {
            get;
            set;
        }
    }
}
