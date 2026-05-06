using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCaptureFilter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRules")]
    public class CoreCaptureFilterVtapCaptureFilterRules : oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#traffic_direction CoreCaptureFilter#traffic_direction}.</summary>
        [JsiiProperty(name: "trafficDirection", typeJson: "{\"primitive\":\"string\"}")]
        public string TrafficDirection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#destination_cidr CoreCaptureFilter#destination_cidr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationCidr
        {
            get;
            set;
        }

        /// <summary>icmp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#icmp_options CoreCaptureFilter#icmp_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesIcmpOptions\"}", isOptional: true)]
        public oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesIcmpOptions? IcmpOptions
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
        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptions\"}", isOptional: true)]
        public oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptions? TcpOptions
        {
            get;
            set;
        }

        /// <summary>udp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#udp_options CoreCaptureFilter#udp_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesUdpOptions\"}", isOptional: true)]
        public oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesUdpOptions? UdpOptions
        {
            get;
            set;
        }
    }
}
