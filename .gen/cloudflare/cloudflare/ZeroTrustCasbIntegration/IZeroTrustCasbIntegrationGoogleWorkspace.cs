using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCasbIntegration
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCasbIntegrationGoogleWorkspace), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspace")]
    public interface IZeroTrustCasbIntegrationGoogleWorkspace
    {
        /// <summary>Authenticate with a service account granted domain-wide delegation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#google_domain_wide_delegation_service_account ZeroTrustCasbIntegration#google_domain_wide_delegation_service_account}
        /// </remarks>
        [JsiiProperty(name: "googleDomainWideDelegationServiceAccount", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccount? GoogleDomainWideDelegationServiceAccount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCasbIntegrationGoogleWorkspace), fullyQualifiedName: "cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspace")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleWorkspace
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Authenticate with a service account granted domain-wide delegation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zero_trust_casb_integration#google_domain_wide_delegation_service_account ZeroTrustCasbIntegration#google_domain_wide_delegation_service_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "googleDomainWideDelegationServiceAccount", typeJson: "{\"fqn\":\"cloudflare.zeroTrustCasbIntegration.ZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccount\"}", isOptional: true)]
            public cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccount? GoogleDomainWideDelegationServiceAccount
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustCasbIntegration.IZeroTrustCasbIntegrationGoogleWorkspaceGoogleDomainWideDelegationServiceAccount?>();
            }
        }
    }
}
