using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.CockpitExporter
{
    [JsiiClass(nativeType: typeof(scaleway.CockpitExporter.CockpitExporterDatadogDestinationOutputReference), fullyQualifiedName: "scaleway.cockpitExporter.CockpitExporterDatadogDestinationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CockpitExporterDatadogDestinationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CockpitExporterDatadogDestinationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CockpitExporterDatadogDestinationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CockpitExporterDatadogDestinationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEndpoint")]
        public virtual void ResetEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.cockpitExporter.CockpitExporterDatadogDestination\"}", isOptional: true)]
        public virtual scaleway.CockpitExporter.ICockpitExporterDatadogDestination? InternalValue
        {
            get => GetInstanceProperty<scaleway.CockpitExporter.ICockpitExporterDatadogDestination?>();
            set => SetInstanceProperty(value);
        }
    }
}
