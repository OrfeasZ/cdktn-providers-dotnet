using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.S2SVpnConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.s2SVpnConnection.S2SVpnConnectionIkev2Ciphers")]
    public class S2SVpnConnectionIkev2Ciphers : scaleway.S2SVpnConnection.IS2SVpnConnectionIkev2Ciphers
    {
        /// <summary>The encryption algorithm.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#encryption S2SVpnConnection#encryption}
        /// </remarks>
        [JsiiProperty(name: "encryption", typeJson: "{\"primitive\":\"string\"}")]
        public string Encryption
        {
            get;
            set;
        }

        /// <summary>The Diffie-Hellman group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#dh_group S2SVpnConnection#dh_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dhGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DhGroup
        {
            get;
            set;
        }

        /// <summary>The integrity/hash algorithm.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#integrity S2SVpnConnection#integrity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "integrity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Integrity
        {
            get;
            set;
        }
    }
}
