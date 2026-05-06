using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkersScripts
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareWorkersScriptsResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareWorkersScriptsResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareWorkersScriptsResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkersScriptsResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compatibilityDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompatibilityDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compatibilityFlags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CompatibilityFlags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Etag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "handlers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Handlers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "hasAssets", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HasAssets
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "hasModules", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HasModules
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastDeployedFrom", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastDeployedFrom
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logpush", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Logpush
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "migrationTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MigrationTag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modifiedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "namedHandlers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultNamedHandlersList\"}")]
        public virtual cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultNamedHandlersList NamedHandlers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultNamedHandlersList>()!;
        }

        [JsiiProperty(name: "observability", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultObservabilityOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultObservabilityOutputReference Observability
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultObservabilityOutputReference>()!;
        }

        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultPlacementOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultPlacementOutputReference Placement
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultPlacementOutputReference>()!;
        }

        [JsiiProperty(name: "placementMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "placementStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routes", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultRoutesList\"}")]
        public virtual cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultRoutesList Routes
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultRoutesList>()!;
        }

        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tailConsumers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultTailConsumersList\"}")]
        public virtual cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultTailConsumersList TailConsumers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultTailConsumersList>()!;
        }

        [JsiiProperty(name: "usageModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkersScripts.IDataCloudflareWorkersScriptsResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkersScripts.IDataCloudflareWorkersScriptsResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
