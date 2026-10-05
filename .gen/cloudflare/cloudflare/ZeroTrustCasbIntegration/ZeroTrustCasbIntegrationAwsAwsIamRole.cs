using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAwsAwsIamRole")]
    public class ZeroTrustCasbIntegrationAwsAwsIamRole : cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAwsAwsIamRole
    {
        /// <summary>External ID required when assuming the IAM role.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#external_id ZeroTrustCasbIntegration#external_id}
        /// </remarks>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public string ExternalId
        {
            get;
            set;
        }

        /// <summary>ARN of the cross-account IAM role Cloudflare will assume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#role_arn ZeroTrustCasbIntegration#role_arn}
        /// </remarks>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }
    }
}
