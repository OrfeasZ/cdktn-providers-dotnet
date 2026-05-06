using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotDigitalTwinAdapter
{
    [JsiiClass(nativeType: typeof(oci.IotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeOutputReference), fullyQualifiedName: "oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IotDigitalTwinAdapterInboundEnvelopeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IotDigitalTwinAdapterInboundEnvelopeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotDigitalTwinAdapterInboundEnvelopeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotDigitalTwinAdapterInboundEnvelopeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEnvelopeMapping", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping\"}}]")]
        public virtual void PutEnvelopeMapping(oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReferencePayload", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeReferencePayload\"}}]")]
        public virtual void PutReferencePayload(oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeReferencePayload @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeReferencePayload)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnvelopeMapping")]
        public virtual void ResetEnvelopeMapping()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReferencePayload")]
        public virtual void ResetReferencePayload()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "envelopeMapping", typeJson: "{\"fqn\":\"oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeEnvelopeMappingOutputReference\"}")]
        public virtual oci.IotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeEnvelopeMappingOutputReference EnvelopeMapping
        {
            get => GetInstanceProperty<oci.IotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeEnvelopeMappingOutputReference>()!;
        }

        [JsiiProperty(name: "referencePayload", typeJson: "{\"fqn\":\"oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeReferencePayloadOutputReference\"}")]
        public virtual oci.IotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeReferencePayloadOutputReference ReferencePayload
        {
            get => GetInstanceProperty<oci.IotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeReferencePayloadOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "envelopeMappingInput", typeJson: "{\"fqn\":\"oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping\"}", isOptional: true)]
        public virtual oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping? EnvelopeMappingInput
        {
            get => GetInstanceProperty<oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeEnvelopeMapping?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "referenceEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReferenceEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "referencePayloadInput", typeJson: "{\"fqn\":\"oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelopeReferencePayload\"}", isOptional: true)]
        public virtual oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeReferencePayload? ReferencePayloadInput
        {
            get => GetInstanceProperty<oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelopeReferencePayload?>();
        }

        [JsiiProperty(name: "referenceEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReferenceEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.iotDigitalTwinAdapter.IotDigitalTwinAdapterInboundEnvelope\"}", isOptional: true)]
        public virtual oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelope? InternalValue
        {
            get => GetInstanceProperty<oci.IotDigitalTwinAdapter.IIotDigitalTwinAdapterInboundEnvelope?>();
            set => SetInstanceProperty(value);
        }
    }
}
