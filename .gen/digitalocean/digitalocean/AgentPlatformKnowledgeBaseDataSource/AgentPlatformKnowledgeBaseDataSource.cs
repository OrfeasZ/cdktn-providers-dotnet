using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.AgentPlatformKnowledgeBaseDataSource
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_knowledge_base_data_source digitalocean_agent_platform_knowledge_base_data_source}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.AgentPlatformKnowledgeBaseDataSource.AgentPlatformKnowledgeBaseDataSource), fullyQualifiedName: "digitalocean.agentPlatformKnowledgeBaseDataSource.AgentPlatformKnowledgeBaseDataSource", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBaseDataSource.AgentPlatformKnowledgeBaseDataSourceConfig\"}}]")]
    public class AgentPlatformKnowledgeBaseDataSource : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_knowledge_base_data_source digitalocean_agent_platform_knowledge_base_data_source} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AgentPlatformKnowledgeBaseDataSource(Constructs.Construct scope, string id, digitalocean.AgentPlatformKnowledgeBaseDataSource.IAgentPlatformKnowledgeBaseDataSourceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.AgentPlatformKnowledgeBaseDataSource.IAgentPlatformKnowledgeBaseDataSourceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AgentPlatformKnowledgeBaseDataSource(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AgentPlatformKnowledgeBaseDataSource(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a AgentPlatformKnowledgeBaseDataSource resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AgentPlatformKnowledgeBaseDataSource to import.</param>
        /// <param name="importFromId">The id of the existing AgentPlatformKnowledgeBaseDataSource that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AgentPlatformKnowledgeBaseDataSource to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AgentPlatformKnowledgeBaseDataSource to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_knowledge_base_data_source#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AgentPlatformKnowledgeBaseDataSource that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AgentPlatformKnowledgeBaseDataSource to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.AgentPlatformKnowledgeBaseDataSource.AgentPlatformKnowledgeBaseDataSource), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putSpacesDataSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBaseDataSource.AgentPlatformKnowledgeBaseDataSourceSpacesDataSource\"}}]")]
        public virtual void PutSpacesDataSource(digitalocean.AgentPlatformKnowledgeBaseDataSource.IAgentPlatformKnowledgeBaseDataSourceSpacesDataSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.AgentPlatformKnowledgeBaseDataSource.IAgentPlatformKnowledgeBaseDataSourceSpacesDataSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWebCrawlerDataSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBaseDataSource.AgentPlatformKnowledgeBaseDataSourceWebCrawlerDataSource\"}}]")]
        public virtual void PutWebCrawlerDataSource(digitalocean.AgentPlatformKnowledgeBaseDataSource.IAgentPlatformKnowledgeBaseDataSourceWebCrawlerDataSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.AgentPlatformKnowledgeBaseDataSource.IAgentPlatformKnowledgeBaseDataSourceWebCrawlerDataSource)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(digitalocean.AgentPlatformKnowledgeBaseDataSource.AgentPlatformKnowledgeBaseDataSource))!;

        [JsiiProperty(name: "spacesDataSource", typeJson: "{\"fqn\":\"digitalocean.agentPlatformKnowledgeBaseDataSource.AgentPlatformKnowledgeBaseDataSourceSpacesDataSourceOutputReference\"}")]
        public virtual digitalocean.AgentPlatformKnowledgeBaseDataSource.AgentPlatformKnowledgeBaseDataSourceSpacesDataSourceOutputReference SpacesDataSource
        {
            get => GetInstanceProperty<digitalocean.AgentPlatformKnowledgeBaseDataSource.AgentPlatformKnowledgeBaseDataSourceSpacesDataSourceOutputReference>()!;
        }

        [JsiiProperty(name: "webCrawlerDataSource", typeJson: "{\"fqn\":\"digitalocean.agentPlatformKnowledgeBaseDataSource.AgentPlatformKnowledgeBaseDataSourceWebCrawlerDataSourceOutputReference\"}")]
        public virtual digitalocean.AgentPlatformKnowledgeBaseDataSource.AgentPlatformKnowledgeBaseDataSourceWebCrawlerDataSourceOutputReference WebCrawlerDataSource
        {
            get => GetInstanceProperty<digitalocean.AgentPlatformKnowledgeBaseDataSource.AgentPlatformKnowledgeBaseDataSourceWebCrawlerDataSourceOutputReference>()!;
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
        [JsiiProperty(name: "spacesDataSourceInput", typeJson: "{\"fqn\":\"digitalocean.agentPlatformKnowledgeBaseDataSource.AgentPlatformKnowledgeBaseDataSourceSpacesDataSource\"}", isOptional: true)]
        public virtual digitalocean.AgentPlatformKnowledgeBaseDataSource.IAgentPlatformKnowledgeBaseDataSourceSpacesDataSource? SpacesDataSourceInput
        {
            get => GetInstanceProperty<digitalocean.AgentPlatformKnowledgeBaseDataSource.IAgentPlatformKnowledgeBaseDataSourceSpacesDataSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webCrawlerDataSourceInput", typeJson: "{\"fqn\":\"digitalocean.agentPlatformKnowledgeBaseDataSource.AgentPlatformKnowledgeBaseDataSourceWebCrawlerDataSource\"}", isOptional: true)]
        public virtual digitalocean.AgentPlatformKnowledgeBaseDataSource.IAgentPlatformKnowledgeBaseDataSourceWebCrawlerDataSource? WebCrawlerDataSourceInput
        {
            get => GetInstanceProperty<digitalocean.AgentPlatformKnowledgeBaseDataSource.IAgentPlatformKnowledgeBaseDataSourceWebCrawlerDataSource?>();
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
