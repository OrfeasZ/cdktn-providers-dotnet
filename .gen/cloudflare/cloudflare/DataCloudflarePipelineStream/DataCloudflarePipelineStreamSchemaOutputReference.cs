using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePipelineStream
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflarePipelineStream.DataCloudflarePipelineStreamSchemaOutputReference), fullyQualifiedName: "cloudflare.dataCloudflarePipelineStream.DataCloudflarePipelineStreamSchemaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflarePipelineStreamSchemaOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflarePipelineStreamSchemaOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflarePipelineStreamSchemaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePipelineStreamSchemaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "fields", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineStream.DataCloudflarePipelineStreamSchemaFieldsList\"}")]
        public virtual cloudflare.DataCloudflarePipelineStream.DataCloudflarePipelineStreamSchemaFieldsList Fields
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineStream.DataCloudflarePipelineStreamSchemaFieldsList>()!;
        }

        [JsiiProperty(name: "format", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineStream.DataCloudflarePipelineStreamSchemaFormatOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePipelineStream.DataCloudflarePipelineStreamSchemaFormatOutputReference Format
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineStream.DataCloudflarePipelineStreamSchemaFormatOutputReference>()!;
        }

        [JsiiProperty(name: "inferred", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Inferred
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineStream.DataCloudflarePipelineStreamSchema\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflarePipelineStream.IDataCloudflarePipelineStreamSchema? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineStream.IDataCloudflarePipelineStreamSchema?>();
            set => SetInstanceProperty(value);
        }
    }
}
