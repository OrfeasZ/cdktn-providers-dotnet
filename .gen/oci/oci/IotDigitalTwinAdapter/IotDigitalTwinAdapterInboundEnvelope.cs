using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotDigitalTwinAdapter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelope")]
    public class IotDigitalTwinAdapterInboundEnvelope : oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#reference_endpoint IotDigitalTwinAdapter#reference_endpoint}.</summary>
        [JsiiProperty(name: "referenceEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string ReferenceEndpoint
        {
            get;
            set;
        }

        /// <summary>envelope_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#envelope_mapping IotDigitalTwinAdapter#envelope_mapping}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "envelopeMapping", typeJson: "{\"fqn\":\"oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping\"}", isOptional: true)]
        public oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping? EnvelopeMapping
        {
            get;
            set;
        }

        /// <summary>reference_payload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#reference_payload IotDigitalTwinAdapter#reference_payload}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "referencePayload", typeJson: "{\"fqn\":\"oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeReferencePayload\"}", isOptional: true)]
        public oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeReferencePayload? ReferencePayload
        {
            get;
            set;
        }
    }
}
