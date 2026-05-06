using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCaptureFilter
{
    [JsiiInterface(nativeType: typeof(ICoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions), fullyQualifiedName: "oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions")]
    public interface ICoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions
    {
        /// <summary>destination_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#destination_port_range CoreCaptureFilter#destination_port_range}
        /// </remarks>
        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesTcpOptionsDestinationPortRange\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesTcpOptionsDestinationPortRange? DestinationPortRange
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#source_port_range CoreCaptureFilter#source_port_range}
        /// </remarks>
        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesTcpOptionsSourcePortRange\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesTcpOptionsSourcePortRange? SourcePortRange
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions), fullyQualifiedName: "oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions")]
        internal sealed class _Proxy : DeputyBase, oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesTcpOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination_port_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#destination_port_range CoreCaptureFilter#destination_port_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesTcpOptionsDestinationPortRange\"}", isOptional: true)]
            public oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesTcpOptionsDestinationPortRange? DestinationPortRange
            {
                get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesTcpOptionsDestinationPortRange?>();
            }

            /// <summary>source_port_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#source_port_range CoreCaptureFilter#source_port_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterFlowLogCaptureFilterRulesTcpOptionsSourcePortRange\"}", isOptional: true)]
            public oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesTcpOptionsSourcePortRange? SourcePortRange
            {
                get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterFlowLogCaptureFilterRulesTcpOptionsSourcePortRange?>();
            }
        }
    }
}
