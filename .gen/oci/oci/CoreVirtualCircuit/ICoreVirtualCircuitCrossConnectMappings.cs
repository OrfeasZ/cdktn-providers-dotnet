using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVirtualCircuit
{
    [JsiiInterface(nativeType: typeof(ICoreVirtualCircuitCrossConnectMappings), fullyQualifiedName: "oci.coreVirtualCircuit.CoreVirtualCircuitCrossConnectMappings")]
    public interface ICoreVirtualCircuitCrossConnectMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#bgp_md5auth_key CoreVirtualCircuit#bgp_md5auth_key}.</summary>
        [JsiiProperty(name: "bgpMd5AuthKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BgpMd5AuthKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#cross_connect_or_cross_connect_group_id CoreVirtualCircuit#cross_connect_or_cross_connect_group_id}.</summary>
        [JsiiProperty(name: "crossConnectOrCrossConnectGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CrossConnectOrCrossConnectGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#customer_bgp_peering_ip CoreVirtualCircuit#customer_bgp_peering_ip}.</summary>
        [JsiiProperty(name: "customerBgpPeeringIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomerBgpPeeringIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#customer_bgp_peering_ipv6 CoreVirtualCircuit#customer_bgp_peering_ipv6}.</summary>
        [JsiiProperty(name: "customerBgpPeeringIpv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomerBgpPeeringIpv6
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#oracle_bgp_peering_ip CoreVirtualCircuit#oracle_bgp_peering_ip}.</summary>
        [JsiiProperty(name: "oracleBgpPeeringIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OracleBgpPeeringIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#oracle_bgp_peering_ipv6 CoreVirtualCircuit#oracle_bgp_peering_ipv6}.</summary>
        [JsiiProperty(name: "oracleBgpPeeringIpv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OracleBgpPeeringIpv6
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#vlan CoreVirtualCircuit#vlan}.</summary>
        [JsiiProperty(name: "vlan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Vlan
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreVirtualCircuitCrossConnectMappings), fullyQualifiedName: "oci.coreVirtualCircuit.CoreVirtualCircuitCrossConnectMappings")]
        internal sealed class _Proxy : DeputyBase, oci.CoreVirtualCircuit.ICoreVirtualCircuitCrossConnectMappings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#bgp_md5auth_key CoreVirtualCircuit#bgp_md5auth_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bgpMd5AuthKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BgpMd5AuthKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#cross_connect_or_cross_connect_group_id CoreVirtualCircuit#cross_connect_or_cross_connect_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "crossConnectOrCrossConnectGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CrossConnectOrCrossConnectGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#customer_bgp_peering_ip CoreVirtualCircuit#customer_bgp_peering_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customerBgpPeeringIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerBgpPeeringIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#customer_bgp_peering_ipv6 CoreVirtualCircuit#customer_bgp_peering_ipv6}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customerBgpPeeringIpv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerBgpPeeringIpv6
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#oracle_bgp_peering_ip CoreVirtualCircuit#oracle_bgp_peering_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oracleBgpPeeringIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OracleBgpPeeringIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#oracle_bgp_peering_ipv6 CoreVirtualCircuit#oracle_bgp_peering_ipv6}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oracleBgpPeeringIpv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OracleBgpPeeringIpv6
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_circuit#vlan CoreVirtualCircuit#vlan}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vlan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Vlan
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
