using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotDigitalTwinAdapter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundRoutes")]
    public class IotDigitalTwinAdapterInboundRoutes : oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundRoutes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#condition IotDigitalTwinAdapter#condition}.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
        public string Condition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#description IotDigitalTwinAdapter#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#payload_mapping IotDigitalTwinAdapter#payload_mapping}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "payloadMapping", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? PayloadMapping
        {
            get;
            set;
        }

        /// <summary>reference_payload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#reference_payload IotDigitalTwinAdapter#reference_payload}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "referencePayload", typeJson: "{\"fqn\":\"oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundRoutesReferencePayload\"}", isOptional: true)]
        public oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundRoutesReferencePayload? ReferencePayload
        {
            get;
            set;
        }
    }
}
