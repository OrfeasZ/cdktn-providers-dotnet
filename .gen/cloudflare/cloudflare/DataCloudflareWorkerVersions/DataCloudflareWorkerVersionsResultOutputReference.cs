using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkerVersions
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareWorkerVersionsResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareWorkerVersionsResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareWorkerVersionsResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkerVersionsResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "annotations", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultAnnotationsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultAnnotationsOutputReference Annotations
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultAnnotationsOutputReference>()!;
        }

        [JsiiProperty(name: "assets", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultAssetsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultAssetsOutputReference Assets
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultAssetsOutputReference>()!;
        }

        [JsiiProperty(name: "bindings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultBindingsList\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultBindingsList Bindings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultBindingsList>()!;
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

        [JsiiProperty(name: "containers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultContainersList\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultContainersList Containers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultContainersList>()!;
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

        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultLimitsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultLimitsOutputReference Limits
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultLimitsOutputReference>()!;
        }

        [JsiiProperty(name: "mainModule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MainModule
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mainScriptBase64", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MainScriptBase64
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "migrations", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultMigrationsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultMigrationsOutputReference Migrations
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultMigrationsOutputReference>()!;
        }

        [JsiiProperty(name: "migrationTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MigrationTag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modules", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultModulesList\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultModulesList Modules
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultModulesList>()!;
        }

        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Number
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultPlacementOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultPlacementOutputReference Placement
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultPlacementOutputReference>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startupTimeMs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartupTimeMs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "urls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Urls
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "usageModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkerVersions.IDataCloudflareWorkerVersionsResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersions.IDataCloudflareWorkerVersionsResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
