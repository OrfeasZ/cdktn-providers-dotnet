using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreIpsecConnectionTunnelManagement
{
    [JsiiByValue(fqn: "oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementBgpSessionInfo")]
    public class CoreIpsecConnectionTunnelManagementBgpSessionInfo : oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementBgpSessionInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#customer_bgp_asn CoreIpsecConnectionTunnelManagement#customer_bgp_asn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customerBgpAsn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomerBgpAsn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#customer_interface_ip CoreIpsecConnectionTunnelManagement#customer_interface_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customerInterfaceIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomerInterfaceIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#customer_interface_ipv6 CoreIpsecConnectionTunnelManagement#customer_interface_ipv6}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customerInterfaceIpv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomerInterfaceIpv6
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#oracle_interface_ip CoreIpsecConnectionTunnelManagement#oracle_interface_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oracleInterfaceIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OracleInterfaceIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#oracle_interface_ipv6 CoreIpsecConnectionTunnelManagement#oracle_interface_ipv6}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oracleInterfaceIpv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OracleInterfaceIpv6
        {
            get;
            set;
        }
    }
}
