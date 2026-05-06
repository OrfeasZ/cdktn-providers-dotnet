using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePipelineStream
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflarePipelineStream.DataCloudflarePipelineStreamHttpOutputReference), fullyQualifiedName: "cloudflare.dataCloudflarePipelineStream.DataCloudflarePipelineStreamHttpOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflarePipelineStreamHttpOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflarePipelineStreamHttpOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflarePipelineStreamHttpOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePipelineStreamHttpOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authentication", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Authentication
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineStream.DataCloudflarePipelineStreamHttpCorsOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePipelineStream.DataCloudflarePipelineStreamHttpCorsOutputReference Cors
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineStream.DataCloudflarePipelineStreamHttpCorsOutputReference>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePipelineStream.DataCloudflarePipelineStreamHttp\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflarePipelineStream.IDataCloudflarePipelineStreamHttp? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePipelineStream.IDataCloudflarePipelineStreamHttp?>();
            set => SetInstanceProperty(value);
        }
    }
}
