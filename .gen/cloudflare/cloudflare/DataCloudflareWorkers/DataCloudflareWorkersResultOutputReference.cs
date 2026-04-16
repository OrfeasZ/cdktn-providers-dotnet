using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkers
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareWorkersResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareWorkersResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkersResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkersResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logpush", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Logpush
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "observability", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultObservabilityOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultObservabilityOutputReference Observability
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultObservabilityOutputReference>()!;
        }

        [JsiiProperty(name: "references", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultReferencesOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultReferencesOutputReference References
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultReferencesOutputReference>()!;
        }

        [JsiiProperty(name: "subdomain", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultSubdomainOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultSubdomainOutputReference Subdomain
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultSubdomainOutputReference>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tailConsumers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultTailConsumersList\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultTailConsumersList TailConsumers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultTailConsumersList>()!;
        }

        [JsiiProperty(name: "updatedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkers.IDataCloudflareWorkersResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.IDataCloudflareWorkersResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
