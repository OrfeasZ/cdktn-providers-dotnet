using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccount), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccount")]
    public interface IZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccount
    {
        /// <summary>A Google Workspace super administrator email address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#administrator_email ZeroTrustCasbIntegration#administrator_email}
        /// </remarks>
        [JsiiProperty(name: "administratorEmail", typeJson: "{\"primitive\":\"string\"}")]
        string AdministratorEmail
        {
            get;
        }

        /// <summary>Contents of a Google service account JSON key file.</summary>
        /// <remarks>
        /// This value is write-only and is never persisted to Terraform state.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#service_account_key_json ZeroTrustCasbIntegration#service_account_key_json}
        /// </remarks>
        [JsiiProperty(name: "serviceAccountKeyJson", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceAccountKeyJson
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccount), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccount")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A Google Workspace super administrator email address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#administrator_email ZeroTrustCasbIntegration#administrator_email}
            /// </remarks>
            [JsiiProperty(name: "administratorEmail", typeJson: "{\"primitive\":\"string\"}")]
            public string AdministratorEmail
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Contents of a Google service account JSON key file.</summary>
            /// <remarks>
            /// This value is write-only and is never persisted to Terraform state.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#service_account_key_json ZeroTrustCasbIntegration#service_account_key_json}
            /// </remarks>
            [JsiiProperty(name: "serviceAccountKeyJson", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceAccountKeyJson
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
