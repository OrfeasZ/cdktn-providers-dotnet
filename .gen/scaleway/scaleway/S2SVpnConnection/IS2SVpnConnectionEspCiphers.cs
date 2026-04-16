using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.S2SVpnConnection
{
    [JsiiInterface(nativeType: typeof(IS2SVpnConnectionEspCiphers), fullyQualifiedName: "scaleway.s2SVpnConnection.S2SVpnConnectionEspCiphers")]
    public interface IS2SVpnConnectionEspCiphers
    {
        /// <summary>The encryption algorithm.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#encryption S2SVpnConnection#encryption}
        /// </remarks>
        [JsiiProperty(name: "encryption", typeJson: "{\"primitive\":\"string\"}")]
        string Encryption
        {
            get;
        }

        /// <summary>The Diffie-Hellman group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#dh_group S2SVpnConnection#dh_group}
        /// </remarks>
        [JsiiProperty(name: "dhGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DhGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>The integrity/hash algorithm.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#integrity S2SVpnConnection#integrity}
        /// </remarks>
        [JsiiProperty(name: "integrity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Integrity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS2SVpnConnectionEspCiphers), fullyQualifiedName: "scaleway.s2SVpnConnection.S2SVpnConnectionEspCiphers")]
        internal sealed class _Proxy : DeputyBase, scaleway.S2SVpnConnection.IS2SVpnConnectionEspCiphers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The encryption algorithm.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#encryption S2SVpnConnection#encryption}
            /// </remarks>
            [JsiiProperty(name: "encryption", typeJson: "{\"primitive\":\"string\"}")]
            public string Encryption
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The Diffie-Hellman group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#dh_group S2SVpnConnection#dh_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dhGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DhGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The integrity/hash algorithm.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/s2s_vpn_connection#integrity S2SVpnConnection#integrity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "integrity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Integrity
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
