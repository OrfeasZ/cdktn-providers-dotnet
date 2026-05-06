using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreIpsec
{
    [JsiiInterface(nativeType: typeof(ICoreIpsecTunnelConfiguration), fullyQualifiedName: "oci.coreIpsec.CoreIpsecTunnelConfiguration")]
    public interface ICoreIpsecTunnelConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec#associated_virtual_circuits CoreIpsec#associated_virtual_circuits}.</summary>
        [JsiiProperty(name: "associatedVirtualCircuits", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AssociatedVirtualCircuits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec#drg_route_table_id CoreIpsec#drg_route_table_id}.</summary>
        [JsiiProperty(name: "drgRouteTableId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DrgRouteTableId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec#oracle_tunnel_ip CoreIpsec#oracle_tunnel_ip}.</summary>
        [JsiiProperty(name: "oracleTunnelIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OracleTunnelIp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreIpsecTunnelConfiguration), fullyQualifiedName: "oci.coreIpsec.CoreIpsecTunnelConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.CoreIpsec.ICoreIpsecTunnelConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec#associated_virtual_circuits CoreIpsec#associated_virtual_circuits}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "associatedVirtualCircuits", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AssociatedVirtualCircuits
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec#drg_route_table_id CoreIpsec#drg_route_table_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "drgRouteTableId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DrgRouteTableId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec#oracle_tunnel_ip CoreIpsec#oracle_tunnel_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oracleTunnelIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OracleTunnelIp
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
