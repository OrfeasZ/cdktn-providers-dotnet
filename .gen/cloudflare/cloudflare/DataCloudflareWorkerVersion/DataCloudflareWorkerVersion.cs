using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkerVersion
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/worker_version cloudflare_worker_version}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersion), fullyQualifiedName: "cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersion", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionConfig\"}}]")]
    public class DataCloudflareWorkerVersion : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/worker_version cloudflare_worker_version} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareWorkerVersion(Constructs.Construct scope, string id, cloudflare.DataCloudflareWorkerVersion.IDataCloudflareWorkerVersionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareWorkerVersion.IDataCloudflareWorkerVersionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkerVersion(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkerVersion(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareWorkerVersion resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareWorkerVersion to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareWorkerVersion that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareWorkerVersion to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareWorkerVersion to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/worker_version#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareWorkerVersion that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareWorkerVersion to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersion), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetAccountId")]
        public virtual void ResetAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInclude")]
        public virtual void ResetInclude()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersion))!;

        [JsiiProperty(name: "annotations", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionAnnotationsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionAnnotationsOutputReference Annotations
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionAnnotationsOutputReference>()!;
        }

        [JsiiProperty(name: "assets", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionAssetsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionAssetsOutputReference Assets
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionAssetsOutputReference>()!;
        }

        [JsiiProperty(name: "bindings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionBindingsList\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionBindingsList Bindings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionBindingsList>()!;
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

        [JsiiProperty(name: "containers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionContainersList\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionContainersList Containers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionContainersList>()!;
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

        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionLimitsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionLimitsOutputReference Limits
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionLimitsOutputReference>()!;
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

        [JsiiProperty(name: "migrations", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionMigrationsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionMigrationsOutputReference Migrations
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionMigrationsOutputReference>()!;
        }

        [JsiiProperty(name: "migrationTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MigrationTag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modules", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionModulesList\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionModulesList Modules
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionModulesList>()!;
        }

        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Number
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionPlacementOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionPlacementOutputReference Placement
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionPlacementOutputReference>()!;
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
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IncludeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "include", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Include
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
