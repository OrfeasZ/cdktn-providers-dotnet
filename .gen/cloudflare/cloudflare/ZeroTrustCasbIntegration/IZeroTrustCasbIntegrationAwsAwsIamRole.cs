using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCasbIntegrationAwsAwsIamRole), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAwsAwsIamRole")]
    public interface IZeroTrustCasbIntegrationAwsAwsIamRole
    {
        /// <summary>External ID required when assuming the IAM role.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#external_id ZeroTrustCasbIntegration#external_id}
        /// </remarks>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        string ExternalId
        {
            get;
        }

        /// <summary>ARN of the cross-account IAM role Cloudflare will assume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#role_arn ZeroTrustCasbIntegration#role_arn}
        /// </remarks>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCasbIntegrationAwsAwsIamRole), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationAwsAwsIamRole")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationAwsAwsIamRole
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>External ID required when assuming the IAM role.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#external_id ZeroTrustCasbIntegration#external_id}
            /// </remarks>
            [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
            public string ExternalId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ARN of the cross-account IAM role Cloudflare will assume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#role_arn ZeroTrustCasbIntegration#role_arn}
            /// </remarks>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
