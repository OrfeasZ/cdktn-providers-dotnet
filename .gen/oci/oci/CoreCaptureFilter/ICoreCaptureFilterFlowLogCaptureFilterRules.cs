using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCaptureFilter
{
    [JsiiInterface(nativeType: typeof(ICoreCaptureFilterFlowLogCaptureFilterRules), fullyQualifiedName: "oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRules")]
    public interface ICoreCaptureFilterFlowLogCaptureFilterRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#destination_cidr CoreCaptureFilter#destination_cidr}.</summary>
        [JsiiProperty(name: "destinationCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationCidr
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#flow_log_type CoreCaptureFilter#flow_log_type}.</summary>
        [JsiiProperty(name: "flowLogType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FlowLogType
        {
            get
            {
                return null;
            }
        }

        /// <summary>icmp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#icmp_options CoreCaptureFilter#icmp_options}
        /// </remarks>
        [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptions? IcmpOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#is_enabled CoreCaptureFilter#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#priority CoreCaptureFilter#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#protocol CoreCaptureFilter#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Protocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#rule_action CoreCaptureFilter#rule_action}.</summary>
        [JsiiProperty(name: "ruleAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RuleAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#sampling_rate CoreCaptureFilter#sampling_rate}.</summary>
        [JsiiProperty(name: "samplingRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SamplingRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#source_cidr CoreCaptureFilter#source_cidr}.</summary>
        [JsiiProperty(name: "sourceCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceCidr
        {
            get
            {
                return null;
            }
        }

        /// <summary>tcp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#tcp_options CoreCaptureFilter#tcp_options}
        /// </remarks>
        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions? TcpOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>udp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#udp_options CoreCaptureFilter#udp_options}
        /// </remarks>
        [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions? UdpOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreCaptureFilterFlowLogCaptureFilterRules), fullyQualifiedName: "oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRules")]
        internal sealed class _Proxy : DeputyBase, oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#destination_cidr CoreCaptureFilter#destination_cidr}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationCidr
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#flow_log_type CoreCaptureFilter#flow_log_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "flowLogType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FlowLogType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>icmp_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#icmp_options CoreCaptureFilter#icmp_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptions\"}", isOptional: true)]
            public oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptions? IcmpOptions
            {
                get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#is_enabled CoreCaptureFilter#is_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#priority CoreCaptureFilter#priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#protocol CoreCaptureFilter#protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Protocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#rule_action CoreCaptureFilter#rule_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ruleAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RuleAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#sampling_rate CoreCaptureFilter#sampling_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "samplingRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SamplingRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#source_cidr CoreCaptureFilter#source_cidr}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceCidr
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tcp_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#tcp_options CoreCaptureFilter#tcp_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions\"}", isOptional: true)]
            public oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions? TcpOptions
            {
                get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions?>();
            }

            /// <summary>udp_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#udp_options CoreCaptureFilter#udp_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions\"}", isOptional: true)]
            public oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions? UdpOptions
            {
                get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions?>();
            }
        }
    }
}
