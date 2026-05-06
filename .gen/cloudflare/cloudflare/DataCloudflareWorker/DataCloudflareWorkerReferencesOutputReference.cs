using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorker
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorker.DataCloudflareWorkerReferencesOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorker.DataCloudflareWorkerReferencesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkerReferencesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkerReferencesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkerReferencesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkerReferencesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dispatchNamespaceOutbounds", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorker.DataCloudflareWorkerReferencesDispatchNamespaceOutboundsList\"}")]
        public virtual cloudflare.DataCloudflareWorker.DataCloudflareWorkerReferencesDispatchNamespaceOutboundsList DispatchNamespaceOutbounds
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorker.DataCloudflareWorkerReferencesDispatchNamespaceOutboundsList>()!;
        }

        [JsiiProperty(name: "domains", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorker.DataCloudflareWorkerReferencesDomainsList\"}")]
        public virtual cloudflare.DataCloudflareWorker.DataCloudflareWorkerReferencesDomainsList Domains
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorker.DataCloudflareWorkerReferencesDomainsList>()!;
        }

        [JsiiProperty(name: "durableObjects", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorker.DataCloudflareWorkerReferencesDurableObjectsList\"}")]
        public virtual cloudflare.DataCloudflareWorker.DataCloudflareWorkerReferencesDurableObjectsList DurableObjects
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorker.DataCloudflareWorkerReferencesDurableObjectsList>()!;
        }

        [JsiiProperty(name: "queues", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorker.DataCloudflareWorkerReferencesQueuesList\"}")]
        public virtual cloudflare.DataCloudflareWorker.DataCloudflareWorkerReferencesQueuesList Queues
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorker.DataCloudflareWorkerReferencesQueuesList>()!;
        }

        [JsiiProperty(name: "workers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorker.DataCloudflareWorkerReferencesWorkersList\"}")]
        public virtual cloudflare.DataCloudflareWorker.DataCloudflareWorkerReferencesWorkersList Workers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorker.DataCloudflareWorkerReferencesWorkersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorker.DataCloudflareWorkerReferences\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorker.IDataCloudflareWorkerReferences? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorker.IDataCloudflareWorkerReferences?>();
            set => SetInstanceProperty(value);
        }
    }
}
