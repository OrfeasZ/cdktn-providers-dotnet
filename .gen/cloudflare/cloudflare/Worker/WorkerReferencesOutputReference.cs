using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Worker
{
    [JsiiClass(nativeType: typeof(cloudflare.Worker.WorkerReferencesOutputReference), fullyQualifiedName: "cloudflare.worker.WorkerReferencesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WorkerReferencesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WorkerReferencesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WorkerReferencesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkerReferencesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dispatchNamespaceOutbounds", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerReferencesDispatchNamespaceOutboundsList\"}")]
        public virtual cloudflare.Worker.WorkerReferencesDispatchNamespaceOutboundsList DispatchNamespaceOutbounds
        {
            get => GetInstanceProperty<cloudflare.Worker.WorkerReferencesDispatchNamespaceOutboundsList>()!;
        }

        [JsiiProperty(name: "domains", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerReferencesDomainsList\"}")]
        public virtual cloudflare.Worker.WorkerReferencesDomainsList Domains
        {
            get => GetInstanceProperty<cloudflare.Worker.WorkerReferencesDomainsList>()!;
        }

        [JsiiProperty(name: "durableObjects", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerReferencesDurableObjectsList\"}")]
        public virtual cloudflare.Worker.WorkerReferencesDurableObjectsList DurableObjects
        {
            get => GetInstanceProperty<cloudflare.Worker.WorkerReferencesDurableObjectsList>()!;
        }

        [JsiiProperty(name: "queues", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerReferencesQueuesList\"}")]
        public virtual cloudflare.Worker.WorkerReferencesQueuesList Queues
        {
            get => GetInstanceProperty<cloudflare.Worker.WorkerReferencesQueuesList>()!;
        }

        [JsiiProperty(name: "workers", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerReferencesWorkersList\"}")]
        public virtual cloudflare.Worker.WorkerReferencesWorkersList Workers
        {
            get => GetInstanceProperty<cloudflare.Worker.WorkerReferencesWorkersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.worker.WorkerReferences\"}", isOptional: true)]
        public virtual cloudflare.Worker.IWorkerReferences? InternalValue
        {
            get => GetInstanceProperty<cloudflare.Worker.IWorkerReferences?>();
            set => SetInstanceProperty(value);
        }
    }
}
