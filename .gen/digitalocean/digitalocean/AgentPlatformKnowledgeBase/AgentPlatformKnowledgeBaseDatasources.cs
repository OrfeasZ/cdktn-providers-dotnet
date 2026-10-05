using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.AgentPlatformKnowledgeBase
{
    [JsiiByValue(fqn: "digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasources")]
    public class AgentPlatformKnowledgeBaseDatasources : digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasources
    {
        private object? _fileUploadDataSource;

        /// <summary>file_upload_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/resources/agent_platform_knowledge_base#file_upload_data_source AgentPlatformKnowledgeBase#file_upload_data_source}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesFileUploadDataSource" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileUploadDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesFileUploadDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FileUploadDataSource
        {
            get => _fileUploadDataSource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesFileUploadDataSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesFileUploadDataSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fileUploadDataSource = value;
            }
        }

        private object? _lastIndexingJob;

        /// <summary>last_indexing_job block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/resources/agent_platform_knowledge_base#last_indexing_job AgentPlatformKnowledgeBase#last_indexing_job}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesLastIndexingJob" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lastIndexingJob", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesLastIndexingJob\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LastIndexingJob
        {
            get => _lastIndexingJob;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesLastIndexingJob[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesLastIndexingJob).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lastIndexingJob = value;
            }
        }

        private object? _spacesDataSource;

        /// <summary>spaces_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/resources/agent_platform_knowledge_base#spaces_data_source AgentPlatformKnowledgeBase#spaces_data_source}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesSpacesDataSource" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spacesDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesSpacesDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SpacesDataSource
        {
            get => _spacesDataSource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesSpacesDataSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesSpacesDataSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _spacesDataSource = value;
            }
        }

        /// <summary>UUID of the Knowledge Base.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/resources/agent_platform_knowledge_base#uuid AgentPlatformKnowledgeBase#uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uuid
        {
            get;
            set;
        }

        private object? _webCrawlerDataSource;

        /// <summary>web_crawler_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/resources/agent_platform_knowledge_base#web_crawler_data_source AgentPlatformKnowledgeBase#web_crawler_data_source}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesWebCrawlerDataSource" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "webCrawlerDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformKnowledgeBase.AgentPlatformKnowledgeBaseDatasourcesWebCrawlerDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? WebCrawlerDataSource
        {
            get => _webCrawlerDataSource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesWebCrawlerDataSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformKnowledgeBase.IAgentPlatformKnowledgeBaseDatasourcesWebCrawlerDataSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _webCrawlerDataSource = value;
            }
        }
    }
}
