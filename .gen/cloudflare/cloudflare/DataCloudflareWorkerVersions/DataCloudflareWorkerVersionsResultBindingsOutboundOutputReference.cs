using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkerVersions
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultBindingsOutboundOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultBindingsOutboundOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkerVersionsResultBindingsOutboundOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkerVersionsResultBindingsOutboundOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkerVersionsResultBindingsOutboundOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkerVersionsResultBindingsOutboundOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "params", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultBindingsOutboundParamsList\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultBindingsOutboundParamsList Params
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultBindingsOutboundParamsList>()!;
        }

        [JsiiProperty(name: "worker", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultBindingsOutboundWorkerOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultBindingsOutboundWorkerOutputReference Worker
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultBindingsOutboundWorkerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultBindingsOutbound\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkerVersions.IDataCloudflareWorkerVersionsResultBindingsOutbound? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersions.IDataCloudflareWorkerVersionsResultBindingsOutbound?>();
            set => SetInstanceProperty(value);
        }
    }
}
