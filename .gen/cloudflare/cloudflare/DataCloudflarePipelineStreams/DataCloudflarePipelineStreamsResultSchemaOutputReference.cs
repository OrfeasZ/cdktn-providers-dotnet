using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePipelineStreams
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultSchemaOutputReference), fullyQualifiedName: "cloudflare.dataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultSchemaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflarePipelineStreamsResultSchemaOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflarePipelineStreamsResultSchemaOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflarePipelineStreamsResultSchemaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePipelineStreamsResultSchemaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "fields", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultSchemaFieldsList\"}")]
        public virtual cloudflare.DataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultSchemaFieldsList Fields
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultSchemaFieldsList>()!;
        }

        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultSchemaFormatOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultSchemaFormatOutputReference Format
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultSchemaFormatOutputReference>()!;
        }

        [JsiiProperty(name: "inferred", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Inferred
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultSchema\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflarePipelineStreams.IDataCloudflarePipelineStreamsResultSchema? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineStreams.IDataCloudflarePipelineStreamsResultSchema?>();
            set => SetInstanceProperty(value);
        }
    }
}
