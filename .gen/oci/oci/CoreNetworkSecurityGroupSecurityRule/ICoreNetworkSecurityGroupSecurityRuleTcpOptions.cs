using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreNetworkSecurityGroupSecurityRule
{
    [JsiiInterface(nativeType: typeof(ICoreNetworkSecurityGroupSecurityRuleTcpOptions), fullyQualifiedName: "oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptions")]
    public interface ICoreNetworkSecurityGroupSecurityRuleTcpOptions
    {
        /// <summary>destination_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_network_security_group_security_rule#destination_port_range CoreNetworkSecurityGroupSecurityRule#destination_port_range}
        /// </remarks>
        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptionsDestinationPortRange\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleTcpOptionsDestinationPortRange? DestinationPortRange
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_network_security_group_security_rule#source_port_range CoreNetworkSecurityGroupSecurityRule#source_port_range}
        /// </remarks>
        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptionsSourcePortRange\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleTcpOptionsSourcePortRange? SourcePortRange
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreNetworkSecurityGroupSecurityRuleTcpOptions), fullyQualifiedName: "oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptions")]
        internal sealed class _Proxy : DeputyBase, oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleTcpOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination_port_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_network_security_group_security_rule#destination_port_range CoreNetworkSecurityGroupSecurityRule#destination_port_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptionsDestinationPortRange\"}", isOptional: true)]
            public oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleTcpOptionsDestinationPortRange? DestinationPortRange
            {
                get => GetInstanceProperty<oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleTcpOptionsDestinationPortRange?>();
            }

            /// <summary>source_port_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_network_security_group_security_rule#source_port_range CoreNetworkSecurityGroupSecurityRule#source_port_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"oci.coreNetworkSecurityGroupSecurityRule.CoreNetworkSecurityGroupSecurityRuleTcpOptionsSourcePortRange\"}", isOptional: true)]
            public oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleTcpOptionsSourcePortRange? SourcePortRange
            {
                get => GetInstanceProperty<oci.CoreNetworkSecurityGroupSecurityRule.ICoreNetworkSecurityGroupSecurityRuleTcpOptionsSourcePortRange?>();
            }
        }
    }
}
