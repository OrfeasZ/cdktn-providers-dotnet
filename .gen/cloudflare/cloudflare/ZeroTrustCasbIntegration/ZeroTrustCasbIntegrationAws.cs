using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAws")]
    public class ZeroTrustCasbIntegrationAws : cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAws
    {
        /// <summary>Authenticate by delegating to a cross-account IAM role.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#aws_iam_role ZeroTrustCasbIntegration#aws_iam_role}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsIamRole", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAwsAwsIamRole\"}", isOptional: true)]
        public cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAwsAwsIamRole? AwsIamRole
        {
            get;
            set;
        }
    }
}
