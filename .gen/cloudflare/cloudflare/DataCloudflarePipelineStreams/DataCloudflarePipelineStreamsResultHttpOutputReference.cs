using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePipelineStreams
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultHttpOutputReference), fullyQualifiedName: "cloudflare.dataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultHttpOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflarePipelineStreamsResultHttpOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflarePipelineStreamsResultHttpOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflarePipelineStreamsResultHttpOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePipelineStreamsResultHttpOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authentication", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Authentication
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultHttpCorsOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultHttpCorsOutputReference Cors
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultHttpCorsOutputReference>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineStreams.DataCloudflarePipelineStreamsResultHttp\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflarePipelineStreams.IDataCloudflarePipelineStreamsResultHttp? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineStreams.IDataCloudflarePipelineStreamsResultHttp?>();
            set => SetInstanceProperty(value);
        }
    }
}
