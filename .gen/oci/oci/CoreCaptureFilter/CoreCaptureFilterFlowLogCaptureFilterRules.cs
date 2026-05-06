using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCaptureFilter
{
    [JsiiByValue(fqn: "oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRules")]
    public class CoreCaptureFilterFlowLogCaptureFilterRules : oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#destination_cidr CoreCaptureFilter#destination_cidr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationCidr
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#flow_log_type CoreCaptureFilter#flow_log_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "flowLogType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FlowLogType
        {
            get;
            set;
        }

        /// <summary>icmp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#icmp_options CoreCaptureFilter#icmp_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptions\"}", isOptional: true)]
        public oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesIcmpOptions? IcmpOptions
        {
            get;
            set;
        }

        private object? _isEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#is_enabled CoreCaptureFilter#is_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsEnabled
        {
            get => _isEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#priority CoreCaptureFilter#priority}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#protocol CoreCaptureFilter#protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#rule_action CoreCaptureFilter#rule_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ruleAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RuleAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#sampling_rate CoreCaptureFilter#sampling_rate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "samplingRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SamplingRate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#source_cidr CoreCaptureFilter#source_cidr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceCidr
        {
            get;
            set;
        }

        /// <summary>tcp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#tcp_options CoreCaptureFilter#tcp_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions\"}", isOptional: true)]
        public oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions? TcpOptions
        {
            get;
            set;
        }

        /// <summary>udp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#udp_options CoreCaptureFilter#udp_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions\"}", isOptional: true)]
        public oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesUdpOptions? UdpOptions
        {
            get;
            set;
        }
    }
}
