using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreIpsec
{
    [JsiiByValue(fqn: "oci.coreIpsec.CoreIpsecTunnelConfiguration")]
    public class CoreIpsecTunnelConfiguration : oci.CoreIpsec.ICoreIpsecTunnelConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec#associated_virtual_circuits CoreIpsec#associated_virtual_circuits}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "associatedVirtualCircuits", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AssociatedVirtualCircuits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec#drg_route_table_id CoreIpsec#drg_route_table_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "drgRouteTableId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DrgRouteTableId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec#oracle_tunnel_ip CoreIpsec#oracle_tunnel_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oracleTunnelIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OracleTunnelIp
        {
            get;
            set;
        }
    }
}
