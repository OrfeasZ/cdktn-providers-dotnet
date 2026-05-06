using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotDigitalTwinAdapter
{
    [JsiiInterface(nativeType: typeof(IIotDigitalTwinAdapterInboundEnvelope), fullyQualifiedName: "oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelope")]
    public interface IIotDigitalTwinAdapterInboundEnvelope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#reference_endpoint IotDigitalTwinAdapter#reference_endpoint}.</summary>
        [JsiiProperty(name: "referenceEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string ReferenceEndpoint
        {
            get;
        }

        /// <summary>envelope_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#envelope_mapping IotDigitalTwinAdapter#envelope_mapping}
        /// </remarks>
        [JsiiProperty(name: "envelopeMapping", typeJson: "{\"fqn\":\"oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping? EnvelopeMapping
        {
            get
            {
                return null;
            }
        }

        /// <summary>reference_payload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#reference_payload IotDigitalTwinAdapter#reference_payload}
        /// </remarks>
        [JsiiProperty(name: "referencePayload", typeJson: "{\"fqn\":\"oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeReferencePayload\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeReferencePayload? ReferencePayload
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotDigitalTwinAdapterInboundEnvelope), fullyQualifiedName: "oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelope")]
        internal sealed class _Proxy : DeputyBase, oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelope
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#reference_endpoint IotDigitalTwinAdapter#reference_endpoint}.</summary>
            [JsiiProperty(name: "referenceEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string ReferenceEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>envelope_mapping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#envelope_mapping IotDigitalTwinAdapter#envelope_mapping}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "envelopeMapping", typeJson: "{\"fqn\":\"oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping\"}", isOptional: true)]
            public oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping? EnvelopeMapping
            {
                get => GetInstanceProperty<oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping?>();
            }

            /// <summary>reference_payload block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#reference_payload IotDigitalTwinAdapter#reference_payload}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "referencePayload", typeJson: "{\"fqn\":\"oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeReferencePayload\"}", isOptional: true)]
            public oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeReferencePayload? ReferencePayload
            {
                get => GetInstanceProperty<oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeReferencePayload?>();
            }
        }
    }
}
