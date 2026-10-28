using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchomniAccessGrant
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchomniAccessGrant.CloudwatchomniAccessGrantScopedActionResourceRowScopeGroupRowScope")]
    public class CloudwatchomniAccessGrantScopedActionResourceRowScopeGroupRowScope : aws.CloudwatchomniAccessGrant.ICloudwatchomniAccessGrantScopedActionResourceRowScopeGroupRowScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#field CloudwatchomniAccessGrant#field}.</summary>
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
        public string Field
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#operator CloudwatchomniAccessGrant#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public string Operator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatchomni_access_grant#values CloudwatchomniAccessGrant#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
