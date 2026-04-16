using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkers
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultReferencesOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultReferencesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkersResultReferencesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkersResultReferencesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkersResultReferencesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkersResultReferencesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dispatchNamespaceOutbounds", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultReferencesDispatchNamespaceOutboundsList\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultReferencesDispatchNamespaceOutboundsList DispatchNamespaceOutbounds
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultReferencesDispatchNamespaceOutboundsList>()!;
        }

        [JsiiProperty(name: "domains", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultReferencesDomainsList\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultReferencesDomainsList Domains
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultReferencesDomainsList>()!;
        }

        [JsiiProperty(name: "durableObjects", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultReferencesDurableObjectsList\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultReferencesDurableObjectsList DurableObjects
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultReferencesDurableObjectsList>()!;
        }

        [JsiiProperty(name: "queues", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultReferencesQueuesList\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultReferencesQueuesList Queues
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultReferencesQueuesList>()!;
        }

        [JsiiProperty(name: "workers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultReferencesWorkersList\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultReferencesWorkersList Workers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultReferencesWorkersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultReferences\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkers.IDataCloudflareWorkersResultReferences? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.IDataCloudflareWorkersResultReferences?>();
            set => SetInstanceProperty(value);
        }
    }
}
