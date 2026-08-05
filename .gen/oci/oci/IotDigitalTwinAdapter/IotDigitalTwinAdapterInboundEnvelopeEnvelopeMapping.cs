using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotDigitalTwinAdapter
{
    [JsiiByValue(fqn: "oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping")]
    public class IotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping : oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/iot_digital_twin_adapter#content_root IotDigitalTwinAdapter#content_root}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contentRoot", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContentRoot
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/iot_digital_twin_adapter#target IotDigitalTwinAdapter#target}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Target
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/iot_digital_twin_adapter#time_observed IotDigitalTwinAdapter#time_observed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeObserved", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeObserved
        {
            get;
            set;
        }
    }
}
