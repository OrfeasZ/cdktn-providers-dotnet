using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkerVersion
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionBindingsOutboundOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionBindingsOutboundOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkerVersionBindingsOutboundOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkerVersionBindingsOutboundOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkerVersionBindingsOutboundOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkerVersionBindingsOutboundOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "params", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionBindingsOutboundParamsList\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionBindingsOutboundParamsList Params
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionBindingsOutboundParamsList>()!;
        }

        [JsiiProperty(name: "worker", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionBindingsOutboundWorkerOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionBindingsOutboundWorkerOutputReference Worker
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionBindingsOutboundWorkerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionBindingsOutbound\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkerVersion.IDataCloudflareWorkerVersionBindingsOutbound? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersion.IDataCloudflareWorkerVersionBindingsOutbound?>();
            set => SetInstanceProperty(value);
        }
    }
}
