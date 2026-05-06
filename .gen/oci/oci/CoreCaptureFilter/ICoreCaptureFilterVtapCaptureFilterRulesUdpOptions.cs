using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCaptureFilter
{
    [JsiiInterface(nativeType: typeof(ICoreCaptureFilterVtapCaptureFilterRulesUdpOptions), fullyQualifiedName: "oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesUdpOptions")]
    public interface ICoreCaptureFilterVtapCaptureFilterRulesUdpOptions
    {
        /// <summary>destination_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#destination_port_range CoreCaptureFilter#destination_port_range}
        /// </remarks>
        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesUdpOptionsDestinationPortRange\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesUdpOptionsDestinationPortRange? DestinationPortRange
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
        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesUdpOptionsSourcePortRange\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesUdpOptionsSourcePortRange? SourcePortRange
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreCaptureFilterVtapCaptureFilterRulesUdpOptions), fullyQualifiedName: "oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesUdpOptions")]
        internal sealed class _Proxy : DeputyBase, oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesUdpOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination_port_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#destination_port_range CoreCaptureFilter#destination_port_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesUdpOptionsDestinationPortRange\"}", isOptional: true)]
            public oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesUdpOptionsDestinationPortRange? DestinationPortRange
            {
                get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesUdpOptionsDestinationPortRange?>();
            }

            /// <summary>source_port_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#source_port_range CoreCaptureFilter#source_port_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesUdpOptionsSourcePortRange\"}", isOptional: true)]
            public oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesUdpOptionsSourcePortRange? SourcePortRange
            {
                get => GetInstanceProperty<oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesUdpOptionsSourcePortRange?>();
            }
        }
    }
}
