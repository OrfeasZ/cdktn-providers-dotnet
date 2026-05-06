using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreSecurityList
{
    [JsiiInterface(nativeType: typeof(ICoreSecurityListIngressSecurityRules), fullyQualifiedName: "oci.coreSecurityList.CoreSecurityListIngressSecurityRules")]
    public interface ICoreSecurityListIngressSecurityRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#protocol CoreSecurityList#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#source CoreSecurityList#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        string Source
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

        /// <summary>icmp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#icmp_options CoreSecurityList#icmp_options}
        /// </remarks>
        [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListIngressSecurityRulesIcmpOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesIcmpOptions? IcmpOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#source_type CoreSecurityList#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceType
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
        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListIngressSecurityRulesTcpOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesTcpOptions? TcpOptions
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
        [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListIngressSecurityRulesUdpOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesUdpOptions? UdpOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreSecurityListIngressSecurityRules), fullyQualifiedName: "oci.coreSecurityList.CoreSecurityListIngressSecurityRules")]
        internal sealed class _Proxy : DeputyBase, oci.CoreSecurityList.ICoreSecurityListIngressSecurityRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#protocol CoreSecurityList#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#source CoreSecurityList#source}.</summary>
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
            public string Source
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

            /// <summary>icmp_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#icmp_options CoreSecurityList#icmp_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListIngressSecurityRulesIcmpOptions\"}", isOptional: true)]
            public oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesIcmpOptions? IcmpOptions
            {
                get => GetInstanceProperty<oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesIcmpOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#source_type CoreSecurityList#source_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceType
            {
                get => GetInstanceProperty<string?>();
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
            [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListIngressSecurityRulesTcpOptions\"}", isOptional: true)]
            public oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesTcpOptions? TcpOptions
            {
                get => GetInstanceProperty<oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesTcpOptions?>();
            }

            /// <summary>udp_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#udp_options CoreSecurityList#udp_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListIngressSecurityRulesUdpOptions\"}", isOptional: true)]
            public oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesUdpOptions? UdpOptions
            {
                get => GetInstanceProperty<oci.CoreSecurityList.ICoreSecurityListIngressSecurityRulesUdpOptions?>();
            }
        }
    }
}
