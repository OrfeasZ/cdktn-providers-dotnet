using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiKnowledgeBaseDataSource
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base_data_source digitalocean_gradientai_knowledge_base_data_source}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.GradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSource), fullyQualifiedName: "digitalocean.gradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSource", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"digitalocean.gradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceConfig\"}}]")]
    public class GradientaiKnowledgeBaseDataSource : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base_data_source digitalocean_gradientai_knowledge_base_data_source} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GradientaiKnowledgeBaseDataSource(Constructs.Construct scope, string id, digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GradientaiKnowledgeBaseDataSource(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GradientaiKnowledgeBaseDataSource(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a GradientaiKnowledgeBaseDataSource resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the GradientaiKnowledgeBaseDataSource to import.</param>
        /// <param name="importFromId">The id of the existing GradientaiKnowledgeBaseDataSource that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the GradientaiKnowledgeBaseDataSource to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the GradientaiKnowledgeBaseDataSource to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base_data_source#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing GradientaiKnowledgeBaseDataSource that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the GradientaiKnowledgeBaseDataSource to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.GradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSource), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putSpacesDataSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.gradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceSpacesDataSource\"}}]")]
        public virtual void PutSpacesDataSource(digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceSpacesDataSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceSpacesDataSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWebCrawlerDataSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.gradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceWebCrawlerDataSource\"}}]")]
        public virtual void PutWebCrawlerDataSource(digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceWebCrawlerDataSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceWebCrawlerDataSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpacesDataSource")]
        public virtual void ResetSpacesDataSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebCrawlerDataSource")]
        public virtual void ResetWebCrawlerDataSource()
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
        = GetStaticProperty<string>(typeof(digitalocean.GradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSource))!;

        [JsiiProperty(name: "spacesDataSource", typeJson: "{\"fqn\":\"digitalocean.gradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceSpacesDataSourceOutputReference\"}")]
        public virtual digitalocean.GradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceSpacesDataSourceOutputReference SpacesDataSource
        {
            get => GetInstanceProperty<digitalocean.GradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceSpacesDataSourceOutputReference>()!;
        }

        [JsiiProperty(name: "webCrawlerDataSource", typeJson: "{\"fqn\":\"digitalocean.gradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceWebCrawlerDataSourceOutputReference\"}")]
        public virtual digitalocean.GradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceWebCrawlerDataSourceOutputReference WebCrawlerDataSource
        {
            get => GetInstanceProperty<digitalocean.GradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceWebCrawlerDataSourceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "knowledgeBaseUuidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KnowledgeBaseUuidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spacesDataSourceInput", typeJson: "{\"fqn\":\"digitalocean.gradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceSpacesDataSource\"}", isOptional: true)]
        public virtual digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceSpacesDataSource? SpacesDataSourceInput
        {
            get => GetInstanceProperty<digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceSpacesDataSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webCrawlerDataSourceInput", typeJson: "{\"fqn\":\"digitalocean.gradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceWebCrawlerDataSource\"}", isOptional: true)]
        public virtual digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceWebCrawlerDataSource? WebCrawlerDataSourceInput
        {
            get => GetInstanceProperty<digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceWebCrawlerDataSource?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "knowledgeBaseUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KnowledgeBaseUuid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
