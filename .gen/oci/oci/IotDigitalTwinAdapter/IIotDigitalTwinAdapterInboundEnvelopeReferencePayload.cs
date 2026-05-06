using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotDigitalTwinAdapter
{
    [JsiiInterface(nativeType: typeof(IIotDigitalTwinAdapterInboundEnvelopeReferencePayload), fullyQualifiedName: "oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeReferencePayload")]
    public interface IIotDigitalTwinAdapterInboundEnvelopeReferencePayload
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#data IotDigitalTwinAdapter#data}.</summary>
        [JsiiProperty(name: "data", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, string> Data
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#data_format IotDigitalTwinAdapter#data_format}.</summary>
        [JsiiProperty(name: "dataFormat", typeJson: "{\"primitive\":\"string\"}")]
        string DataFormat
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIotDigitalTwinAdapterInboundEnvelopeReferencePayload), fullyQualifiedName: "oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeReferencePayload")]
        internal sealed class _Proxy : DeputyBase, oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeReferencePayload
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#data IotDigitalTwinAdapter#data}.</summary>
            [JsiiProperty(name: "data", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, string> Data
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#data_format IotDigitalTwinAdapter#data_format}.</summary>
            [JsiiProperty(name: "dataFormat", typeJson: "{\"primitive\":\"string\"}")]
            public string DataFormat
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
