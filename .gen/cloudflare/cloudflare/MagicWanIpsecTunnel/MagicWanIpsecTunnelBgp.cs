using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicWanIpsecTunnel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelBgp")]
    public class MagicWanIpsecTunnelBgp : cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelBgp
    {
        /// <summary>ASN used on the customer end of the BGP session.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_ipsec_tunnel#customer_asn MagicWanIpsecTunnel#customer_asn}
        /// </remarks>
        [JsiiProperty(name: "customerAsn", typeJson: "{\"primitive\":\"number\"}")]
        public double CustomerAsn
        {
            get;
            set;
        }

        /// <summary>Prefixes in this list will be advertised to the customer device, in addition to the routes in the Magic routing table.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_ipsec_tunnel#extra_prefixes MagicWanIpsecTunnel#extra_prefixes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extraPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExtraPrefixes
        {
            get;
            set;
        }

        /// <summary>MD5 key to use for session authentication.</summary>
        /// <remarks>
        /// Note that <em>this is not a security measure</em>. MD5 is not a valid security mechanism, and the
        /// key is not treated as a secret value. This is <em>only</em> supported for preventing
        /// misconfiguration, not for defending against malicious attacks.
        ///
        /// The MD5 key, if set, must be of non-zero length and consist only of the following types of
        /// character:
        ///
        /// <list type="bullet">
        /// <description>ASCII alphanumerics: <c>[a-zA-Z0-9]</c></description>
        /// <description>Special characters in the set <c>'!@#$%^&amp;*()+[]{}&lt;&gt;/.,;:_-~</c>= |`</description>
        /// </list>
        ///
        /// In other words, MD5 keys may contain any printable ASCII character aside from newline (0x0A),
        /// quotation mark (<c>"</c>), vertical tab (0x0B), carriage return (0x0D), tab (0x09), form feed
        /// (0x0C), and the question mark (<c>?</c>). Requests specifying an MD5 key with one or more of
        /// these disallowed characters will be rejected.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_wan_ipsec_tunnel#md5_key MagicWanIpsecTunnel#md5_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "md5Key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Md5Key
        {
            get;
            set;
        }
    }
}
