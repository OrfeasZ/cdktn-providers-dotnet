using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniOrganizationAccessGrant
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchomniOrganizationAccessGrant.CloudwatchomniOrganizationAccessGrantPrincipalPrincipalAttribute")]
    public class CloudwatchomniOrganizationAccessGrantPrincipalPrincipalAttribute : aws.CloudwatchomniOrganizationAccessGrant.ICloudwatchomniOrganizationAccessGrantPrincipalPrincipalAttribute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_organization_access_grant#key CloudwatchomniOrganizationAccessGrant#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/cloudwatchomni_organization_access_grant#value CloudwatchomniOrganizationAccessGrant#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
