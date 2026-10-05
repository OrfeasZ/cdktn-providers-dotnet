using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCasbIntegrationAws), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAws")]
    public interface IZeroTrustCasbIntegrationAws
    {
        /// <summary>Authenticate by delegating to a cross-account IAM role.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#aws_iam_role ZeroTrustCasbIntegration#aws_iam_role}
        /// </remarks>
        [JsiiProperty(name: "awsIamRole", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAwsAwsIamRole\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAwsAwsIamRole? AwsIamRole
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCasbIntegrationAws), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAws")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAws
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Authenticate by delegating to a cross-account IAM role.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#aws_iam_role ZeroTrustCasbIntegration#aws_iam_role}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsIamRole", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAwsAwsIamRole\"}", isOptional: true)]
            public cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAwsAwsIamRole? AwsIamRole
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAwsAwsIamRole?>();
            }
        }
    }
}
