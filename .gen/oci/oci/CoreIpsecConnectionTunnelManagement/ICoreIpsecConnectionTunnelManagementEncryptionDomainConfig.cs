using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreIpsecConnectionTunnelManagement
{
    [JsiiInterface(nativeType: typeof(ICoreIpsecConnectionTunnelManagementEncryptionDomainConfig), fullyQualifiedName: "oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementEncryptionDomainConfig")]
    public interface ICoreIpsecConnectionTunnelManagementEncryptionDomainConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#cpe_traffic_selector CoreIpsecConnectionTunnelManagement#cpe_traffic_selector}.</summary>
        [JsiiProperty(name: "cpeTrafficSelector", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CpeTrafficSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#oracle_traffic_selector CoreIpsecConnectionTunnelManagement#oracle_traffic_selector}.</summary>
        [JsiiProperty(name: "oracleTrafficSelector", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OracleTrafficSelector
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreIpsecConnectionTunnelManagementEncryptionDomainConfig), fullyQualifiedName: "oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementEncryptionDomainConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementEncryptionDomainConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#cpe_traffic_selector CoreIpsecConnectionTunnelManagement#cpe_traffic_selector}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpeTrafficSelector", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CpeTrafficSelector
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#oracle_traffic_selector CoreIpsecConnectionTunnelManagement#oracle_traffic_selector}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oracleTrafficSelector", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OracleTrafficSelector
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
