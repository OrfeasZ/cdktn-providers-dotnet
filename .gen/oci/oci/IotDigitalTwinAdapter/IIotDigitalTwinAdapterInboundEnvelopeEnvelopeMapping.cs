using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotDigitalTwinAdapter
{
    [JsiiInterface(nativeType: typeof(IIotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping), fullyQualifiedName: "oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping")]
    public interface IIotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#time_observed IotDigitalTwinAdapter#time_observed}.</summary>
        [JsiiProperty(name: "timeObserved", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeObserved
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping), fullyQualifiedName: "oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping")]
        internal sealed class _Proxy : DeputyBase, oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/iot_digital_twin_adapter#time_observed IotDigitalTwinAdapter#time_observed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeObserved", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeObserved
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
