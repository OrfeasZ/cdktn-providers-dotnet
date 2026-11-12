using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustCwsDomainAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustCwsDomainAcl.ZeroTrustCwsDomainAclEntries")]
    public class ZeroTrustCwsDomainAclEntries : cloudflare.ZeroTrustCwsDomainAcl.IZeroTrustCwsDomainAclEntries
    {
        /// <summary>Per-domain decision overriding the parent ACL's default_action Available values: "ALLOW", "BLOCK".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_domain_acl#action ZeroTrustCwsDomainAcl#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Hostname or domain pattern, capped at 255 UTF-8 bytes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/zero_trust_cws_domain_acl#domain ZeroTrustCwsDomainAcl#domain}
        /// </remarks>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public string Domain
        {
            get;
            set;
        }
    }
}
