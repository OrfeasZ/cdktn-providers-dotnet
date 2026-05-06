using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotDigitalTwinAdapter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundRoutesReferencePayload")]
    public class IotDigitalTwinAdapterInboundRoutesReferencePayload : oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundRoutesReferencePayload
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#data IotDigitalTwinAdapter#data}.</summary>
        [JsiiProperty(name: "data", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, string> Data
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#data_format IotDigitalTwinAdapter#data_format}.</summary>
        [JsiiProperty(name: "dataFormat", typeJson: "{\"primitive\":\"string\"}")]
        public string DataFormat
        {
            get;
            set;
        }
    }
}
