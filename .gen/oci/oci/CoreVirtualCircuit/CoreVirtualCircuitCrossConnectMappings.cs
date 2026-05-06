using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVirtualCircuit
{
    [JsiiByValue(fqn: "oci.coreVirtualCircuit.CoreVirtualCircuitCrossConnectMappings")]
    public class CoreVirtualCircuitCrossConnectMappings : oci.CoreVirtualCircuit.ICoreVirtualCircuitCrossConnectMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#bgp_md5auth_key CoreVirtualCircuit#bgp_md5auth_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bgpMd5AuthKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BgpMd5AuthKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#cross_connect_or_cross_connect_group_id CoreVirtualCircuit#cross_connect_or_cross_connect_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "crossConnectOrCrossConnectGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CrossConnectOrCrossConnectGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#customer_bgp_peering_ip CoreVirtualCircuit#customer_bgp_peering_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customerBgpPeeringIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomerBgpPeeringIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#customer_bgp_peering_ipv6 CoreVirtualCircuit#customer_bgp_peering_ipv6}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customerBgpPeeringIpv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomerBgpPeeringIpv6
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#oracle_bgp_peering_ip CoreVirtualCircuit#oracle_bgp_peering_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oracleBgpPeeringIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OracleBgpPeeringIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#oracle_bgp_peering_ipv6 CoreVirtualCircuit#oracle_bgp_peering_ipv6}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oracleBgpPeeringIpv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OracleBgpPeeringIpv6
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#vlan CoreVirtualCircuit#vlan}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vlan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Vlan
        {
            get;
            set;
        }
    }
}
