using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDefaultSecurityList
{
    [JsiiInterface(nativeType: typeof(ICoreDefaultSecurityListEgressSecurityRules), fullyQualifiedName: "oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRules")]
    public interface ICoreDefaultSecurityListEgressSecurityRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#destination CoreDefaultSecurityList#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        string Destination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#protocol CoreDefaultSecurityList#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#description CoreDefaultSecurityList#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#destination_type CoreDefaultSecurityList#destination_type}.</summary>
        [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationType
        {
            get
            {
                return null;
            }
        }

        /// <summary>icmp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#icmp_options CoreDefaultSecurityList#icmp_options}
        /// </remarks>
        [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesIcmpOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesIcmpOptions? IcmpOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#stateless CoreDefaultSecurityList#stateless}.</summary>
        [JsiiProperty(name: "stateless", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Stateless
        {
            get
            {
                return null;
            }
        }

        /// <summary>tcp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#tcp_options CoreDefaultSecurityList#tcp_options}
        /// </remarks>
        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesTcpOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesTcpOptions? TcpOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>udp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#udp_options CoreDefaultSecurityList#udp_options}
        /// </remarks>
        [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesUdpOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesUdpOptions? UdpOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreDefaultSecurityListEgressSecurityRules), fullyQualifiedName: "oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRules")]
        internal sealed class _Proxy : DeputyBase, oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#destination CoreDefaultSecurityList#destination}.</summary>
            [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
            public string Destination
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#protocol CoreDefaultSecurityList#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#description CoreDefaultSecurityList#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#destination_type CoreDefaultSecurityList#destination_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>icmp_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#icmp_options CoreDefaultSecurityList#icmp_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesIcmpOptions\"}", isOptional: true)]
            public oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesIcmpOptions? IcmpOptions
            {
                get => GetInstanceProperty<oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesIcmpOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#stateless CoreDefaultSecurityList#stateless}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stateless", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Stateless
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tcp_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#tcp_options CoreDefaultSecurityList#tcp_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesTcpOptions\"}", isOptional: true)]
            public oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesTcpOptions? TcpOptions
            {
                get => GetInstanceProperty<oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesTcpOptions?>();
            }

            /// <summary>udp_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#udp_options CoreDefaultSecurityList#udp_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesUdpOptions\"}", isOptional: true)]
            public oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesUdpOptions? UdpOptions
            {
                get => GetInstanceProperty<oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesUdpOptions?>();
            }
        }
    }
}
