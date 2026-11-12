using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCwsDomainAcl
{
    [JsiiInterface(nativeType: typeof(IZeroTrustCwsDomainAclEntries), fullyQualifiedName: "cloudflare.zeroTrustCwsDomainAcl.ZeroTrustCwsDomainAclEntries")]
    public interface IZeroTrustCwsDomainAclEntries
    {
        /// <summary>Per-domain decision overriding the parent ACL's default_action Available values: "ALLOW", "BLOCK".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_domain_acl#action ZeroTrustCwsDomainAcl#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>Hostname or domain pattern, capped at 255 UTF-8 bytes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_domain_acl#domain ZeroTrustCwsDomainAcl#domain}
        /// </remarks>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        string Domain
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustCwsDomainAclEntries), fullyQualifiedName: "cloudflare.zeroTrustCwsDomainAcl.ZeroTrustCwsDomainAclEntries")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustCwsDomainAcl.IZeroTrustCwsDomainAclEntries
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Per-domain decision overriding the parent ACL's default_action Available values: "ALLOW", "BLOCK".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_domain_acl#action ZeroTrustCwsDomainAcl#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Hostname or domain pattern, capped at 255 UTF-8 bytes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_domain_acl#domain ZeroTrustCwsDomainAcl#domain}
            /// </remarks>
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
            public string Domain
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
