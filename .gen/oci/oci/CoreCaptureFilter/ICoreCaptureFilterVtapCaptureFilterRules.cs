using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCaptureFilter
{
    [JsiiInterface(nativeType: typeof(ICoreCaptureFilterVtapCaptureFilterRules), fullyQualifiedName: "oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRules")]
    public interface ICoreCaptureFilterVtapCaptureFilterRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#traffic_direction CoreCaptureFilter#traffic_direction}.</summary>
        [JsiiProperty(name: "trafficDirection", typeJson: "{\"primitive\":\"string\"}")]
        string TrafficDirection
        {
            get;
        }

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

        /// <summary>icmp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#icmp_options CoreCaptureFilter#icmp_options}
        /// </remarks>
        [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesIcmpOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesIcmpOptions? IcmpOptions
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
        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptions? TcpOptions
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
        [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesUdpOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesUdpOptions? UdpOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreCaptureFilterVtapCaptureFilterRules), fullyQualifiedName: "oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRules")]
        internal sealed class _Proxy : DeputyBase, oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#traffic_direction CoreCaptureFilter#traffic_direction}.</summary>
            [JsiiProperty(name: "trafficDirection", typeJson: "{\"primitive\":\"string\"}")]
            public string TrafficDirection
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#destination_cidr CoreCaptureFilter#destination_cidr}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationCidr
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>icmp_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#icmp_options CoreCaptureFilter#icmp_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesIcmpOptions\"}", isOptional: true)]
            public oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesIcmpOptions? IcmpOptions
            {
                get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesIcmpOptions?>();
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
            [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptions\"}", isOptional: true)]
            public oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptions? TcpOptions
            {
                get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptions?>();
            }

            /// <summary>udp_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#udp_options CoreCaptureFilter#udp_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesUdpOptions\"}", isOptional: true)]
            public oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesUdpOptions? UdpOptions
            {
                get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesUdpOptions?>();
            }
        }
    }
}
