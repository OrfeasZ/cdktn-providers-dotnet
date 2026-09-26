using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiClass(nativeType: typeof(cloudflare.WorkerVersion.WorkerVersionExportsReconciliationOutputReference), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionExportsReconciliationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WorkerVersionExportsReconciliationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WorkerVersionExportsReconciliationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WorkerVersionExportsReconciliationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkerVersionExportsReconciliationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "created", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Created
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "deleted", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Deleted
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "info", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionExportsReconciliationInfoList\"}")]
        public virtual cloudflare.WorkerVersion.WorkerVersionExportsReconciliationInfoList Info
        {
            get => GetInstanceProperty<cloudflare.WorkerVersion.WorkerVersionExportsReconciliationInfoList>()!;
        }

        [JsiiProperty(name: "removableEntries", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RemovableEntries
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "renamed", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionExportsReconciliationRenamedList\"}")]
        public virtual cloudflare.WorkerVersion.WorkerVersionExportsReconciliationRenamedList Renamed
        {
            get => GetInstanceProperty<cloudflare.WorkerVersion.WorkerVersionExportsReconciliationRenamedList>()!;
        }

        [JsiiProperty(name: "transferPending", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionExportsReconciliationTransferPendingList\"}")]
        public virtual cloudflare.WorkerVersion.WorkerVersionExportsReconciliationTransferPendingList TransferPending
        {
            get => GetInstanceProperty<cloudflare.WorkerVersion.WorkerVersionExportsReconciliationTransferPendingList>()!;
        }

        [JsiiProperty(name: "transferred", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionExportsReconciliationTransferredList\"}")]
        public virtual cloudflare.WorkerVersion.WorkerVersionExportsReconciliationTransferredList Transferred
        {
            get => GetInstanceProperty<cloudflare.WorkerVersion.WorkerVersionExportsReconciliationTransferredList>()!;
        }

        [JsiiProperty(name: "updated", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Updated
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "warnings", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionExportsReconciliationWarningsList\"}")]
        public virtual cloudflare.WorkerVersion.WorkerVersionExportsReconciliationWarningsList Warnings
        {
            get => GetInstanceProperty<cloudflare.WorkerVersion.WorkerVersionExportsReconciliationWarningsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionExportsReconciliation\"}", isOptional: true)]
        public virtual cloudflare.WorkerVersion.IWorkerVersionExportsReconciliation? InternalValue
        {
            get => GetInstanceProperty<cloudflare.WorkerVersion.IWorkerVersionExportsReconciliation?>();
            set => SetInstanceProperty(value);
        }
    }
}
