using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAccessGrant
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchomniAccessGrant.CloudwatchomniAccessGrantPrincipalPrincipalAttribute")]
    public class CloudwatchomniAccessGrantPrincipalPrincipalAttribute : aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantPrincipalPrincipalAttribute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#key CloudwatchomniAccessGrant#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#value CloudwatchomniAccessGrant#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
