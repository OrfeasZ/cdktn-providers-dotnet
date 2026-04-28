using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiIndexingJob
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_indexing_job digitalocean_gradientai_indexing_job}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanGradientaiIndexingJob.DataDigitaloceanGradientaiIndexingJob), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiIndexingJob.DataDigitaloceanGradientaiIndexingJob", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiIndexingJob.DataDigitaloceanGradientaiIndexingJobConfig\"}}]")]
    public class DataDigitaloceanGradientaiIndexingJob : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_indexing_job digitalocean_gradientai_indexing_job} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataDigitaloceanGradientaiIndexingJob(Constructs.Construct scope, string id, digitalocean.DataDigitaloceanGradientaiIndexingJob.IDataDigitaloceanGradientaiIndexingJobConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.DataDigitaloceanGradientaiIndexingJob.IDataDigitaloceanGradientaiIndexingJobConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanGradientaiIndexingJob(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanGradientaiIndexingJob(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataDigitaloceanGradientaiIndexingJob resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataDigitaloceanGradientaiIndexingJob to import.</param>
        /// <param name="importFromId">The id of the existing DataDigitaloceanGradientaiIndexingJob that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataDigitaloceanGradientaiIndexingJob to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataDigitaloceanGradientaiIndexingJob to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_indexing_job#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataDigitaloceanGradientaiIndexingJob that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataDigitaloceanGradientaiIndexingJob to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.DataDigitaloceanGradientaiIndexingJob.DataDigitaloceanGradientaiIndexingJob), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(digitalocean.DataDigitaloceanGradientaiIndexingJob.DataDigitaloceanGradientaiIndexingJob))!;

        [JsiiProperty(name: "completedDatasources", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CompletedDatasources
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataSourceUuids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DataSourceUuids
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "finishedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FinishedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "knowledgeBaseUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KnowledgeBaseUuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "phase", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Phase
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tokens", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tokens
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalDatasources", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalDatasources
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalItemsFailed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalItemsFailed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalItemsIndexed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalItemsIndexed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalItemsSkipped", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalItemsSkipped
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uuidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UuidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uuid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
