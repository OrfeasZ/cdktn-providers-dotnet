using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreIpsecConnectionTunnelManagement
{
    [JsiiInterface(nativeType: typeof(ICoreIpsecConnectionTunnelManagementBgpSessionInfo), fullyQualifiedName: "oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementBgpSessionInfo")]
    public interface ICoreIpsecConnectionTunnelManagementBgpSessionInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#customer_bgp_asn CoreIpsecConnectionTunnelManagement#customer_bgp_asn}.</summary>
        [JsiiProperty(name: "customerBgpAsn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomerBgpAsn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#customer_interface_ip CoreIpsecConnectionTunnelManagement#customer_interface_ip}.</summary>
        [JsiiProperty(name: "customerInterfaceIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomerInterfaceIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#customer_interface_ipv6 CoreIpsecConnectionTunnelManagement#customer_interface_ipv6}.</summary>
        [JsiiProperty(name: "customerInterfaceIpv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomerInterfaceIpv6
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#oracle_interface_ip CoreIpsecConnectionTunnelManagement#oracle_interface_ip}.</summary>
        [JsiiProperty(name: "oracleInterfaceIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OracleInterfaceIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#oracle_interface_ipv6 CoreIpsecConnectionTunnelManagement#oracle_interface_ipv6}.</summary>
        [JsiiProperty(name: "oracleInterfaceIpv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OracleInterfaceIpv6
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreIpsecConnectionTunnelManagementBgpSessionInfo), fullyQualifiedName: "oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementBgpSessionInfo")]
        internal sealed class _Proxy : DeputyBase, oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementBgpSessionInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#customer_bgp_asn CoreIpsecConnectionTunnelManagement#customer_bgp_asn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customerBgpAsn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerBgpAsn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#customer_interface_ip CoreIpsecConnectionTunnelManagement#customer_interface_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customerInterfaceIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerInterfaceIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#customer_interface_ipv6 CoreIpsecConnectionTunnelManagement#customer_interface_ipv6}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customerInterfaceIpv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerInterfaceIpv6
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#oracle_interface_ip CoreIpsecConnectionTunnelManagement#oracle_interface_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oracleInterfaceIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OracleInterfaceIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#oracle_interface_ipv6 CoreIpsecConnectionTunnelManagement#oracle_interface_ipv6}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oracleInterfaceIpv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OracleInterfaceIpv6
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
