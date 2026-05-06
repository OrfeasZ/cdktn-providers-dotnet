using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreSecurityList
{
    [JsiiInterface(nativeType: typeof(ICoreSecurityListEgressSecurityRules), fullyQualifiedName: "oci.coreSecurityList.CoreSecurityListEgressSecurityRules")]
    public interface ICoreSecurityListEgressSecurityRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#destination CoreSecurityList#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        string Destination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#protocol CoreSecurityList#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#description CoreSecurityList#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#destination_type CoreSecurityList#destination_type}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#icmp_options CoreSecurityList#icmp_options}
        /// </remarks>
        [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesIcmpOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesIcmpOptions? IcmpOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#stateless CoreSecurityList#stateless}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#tcp_options CoreSecurityList#tcp_options}
        /// </remarks>
        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesTcpOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesTcpOptions? TcpOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>udp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#udp_options CoreSecurityList#udp_options}
        /// </remarks>
        [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesUdpOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesUdpOptions? UdpOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreSecurityListEgressSecurityRules), fullyQualifiedName: "oci.coreSecurityList.CoreSecurityListEgressSecurityRules")]
        internal sealed class _Proxy : DeputyBase, oci.CoreSecurityList.ICoreSecurityListEgressSecurityRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#destination CoreSecurityList#destination}.</summary>
            [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
            public string Destination
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#protocol CoreSecurityList#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#description CoreSecurityList#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#destination_type CoreSecurityList#destination_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>icmp_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#icmp_options CoreSecurityList#icmp_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesIcmpOptions\"}", isOptional: true)]
            public oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesIcmpOptions? IcmpOptions
            {
                get => GetInstanceProperty<oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesIcmpOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#stateless CoreSecurityList#stateless}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stateless", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Stateless
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tcp_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#tcp_options CoreSecurityList#tcp_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesTcpOptions\"}", isOptional: true)]
            public oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesTcpOptions? TcpOptions
            {
                get => GetInstanceProperty<oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesTcpOptions?>();
            }

            /// <summary>udp_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#udp_options CoreSecurityList#udp_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesUdpOptions\"}", isOptional: true)]
            public oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesUdpOptions? UdpOptions
            {
                get => GetInstanceProperty<oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesUdpOptions?>();
            }
        }
    }
}
