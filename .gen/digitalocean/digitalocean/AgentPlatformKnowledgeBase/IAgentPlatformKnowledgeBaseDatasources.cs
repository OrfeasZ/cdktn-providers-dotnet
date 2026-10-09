using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.AgentPlatformKnowledgeBase
{
    [JsiiInterface(nativeType: typeof(IAgentPlatformKnowledgeBaseDatasources), fullyQualifiedName: "digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasources")]
    public interface IAgentPlatformKnowledgeBaseDatasources
    {
        /// <summary>file_upload_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_knowledge_base#file_upload_data_source AgentPlatformKnowledgeBase#file_upload_data_source}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesFileUploadDataSource" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "fileUploadDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesFileUploadDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FileUploadDataSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>last_indexing_job block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_knowledge_base#last_indexing_job AgentPlatformKnowledgeBase#last_indexing_job}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesLastIndexingJob" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "lastIndexingJob", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesLastIndexingJob\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LastIndexingJob
        {
            get
            {
                return null;
            }
        }

        /// <summary>spaces_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_knowledge_base#spaces_data_source AgentPlatformKnowledgeBase#spaces_data_source}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesSpacesDataSource" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "spacesDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesSpacesDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SpacesDataSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>UUID of the Knowledge Base.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_knowledge_base#uuid AgentPlatformKnowledgeBase#uuid}
        /// </remarks>
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uuid
        {
            get
            {
                return null;
            }
        }

        /// <summary>web_crawler_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_knowledge_base#web_crawler_data_source AgentPlatformKnowledgeBase#web_crawler_data_source}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesWebCrawlerDataSource" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "webCrawlerDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesWebCrawlerDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WebCrawlerDataSource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAgentPlatformKnowledgeBaseDatasources), fullyQualifiedName: "digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasources")]
        internal sealed class _Proxy : DeputyBase, digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>file_upload_data_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_knowledge_base#file_upload_data_source AgentPlatformKnowledgeBase#file_upload_data_source}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesFileUploadDataSource" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileUploadDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesFileUploadDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FileUploadDataSource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>last_indexing_job block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_knowledge_base#last_indexing_job AgentPlatformKnowledgeBase#last_indexing_job}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesLastIndexingJob" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lastIndexingJob", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesLastIndexingJob\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LastIndexingJob
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>spaces_data_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_knowledge_base#spaces_data_source AgentPlatformKnowledgeBase#spaces_data_source}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesSpacesDataSource" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spacesDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesSpacesDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SpacesDataSource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>UUID of the Knowledge Base.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_knowledge_base#uuid AgentPlatformKnowledgeBase#uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>web_crawler_data_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_knowledge_base#web_crawler_data_source AgentPlatformKnowledgeBase#web_crawler_data_source}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesWebCrawlerDataSource" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webCrawlerDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesWebCrawlerDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? WebCrawlerDataSource
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
