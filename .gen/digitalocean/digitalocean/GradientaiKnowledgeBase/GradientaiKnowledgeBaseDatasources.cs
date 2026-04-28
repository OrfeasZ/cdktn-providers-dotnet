using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiKnowledgeBase
{
    [JsiiByValue(fqn: "digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasources")]
    public class GradientaiKnowledgeBaseDatasources : digitalocean.GradientaiKnowledgeBase.IGradientaiKnowledgeBaseDatasources
    {
        private object? _fileUploadDataSource;

        /// <summary>file_upload_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base#file_upload_data_source GradientaiKnowledgeBase#file_upload_data_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileUploadDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasourcesFileUploadDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case digitalocean.GradientaiKnowledgeBase.IGradientaiKnowledgeBaseDatasourcesFileUploadDataSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.GradientaiKnowledgeBase.IGradientaiKnowledgeBaseDatasourcesFileUploadDataSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fileUploadDataSource = value;
            }
        }

        private object? _lastIndexingJob;

        /// <summary>last_indexing_job block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base#last_indexing_job GradientaiKnowledgeBase#last_indexing_job}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lastIndexingJob", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasourcesLastIndexingJob\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case digitalocean.GradientaiKnowledgeBase.IGradientaiKnowledgeBaseDatasourcesLastIndexingJob[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.GradientaiKnowledgeBase.IGradientaiKnowledgeBaseDatasourcesLastIndexingJob).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lastIndexingJob = value;
            }
        }

        private object? _spacesDataSource;

        /// <summary>spaces_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base#spaces_data_source GradientaiKnowledgeBase#spaces_data_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spacesDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasourcesSpacesDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case digitalocean.GradientaiKnowledgeBase.IGradientaiKnowledgeBaseDatasourcesSpacesDataSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.GradientaiKnowledgeBase.IGradientaiKnowledgeBaseDatasourcesSpacesDataSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _spacesDataSource = value;
            }
        }

        /// <summary>UUID of the Knowledge Base.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base#uuid GradientaiKnowledgeBase#uuid}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base#web_crawler_data_source GradientaiKnowledgeBase#web_crawler_data_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "webCrawlerDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasourcesWebCrawlerDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case digitalocean.GradientaiKnowledgeBase.IGradientaiKnowledgeBaseDatasourcesWebCrawlerDataSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.GradientaiKnowledgeBase.IGradientaiKnowledgeBaseDatasourcesWebCrawlerDataSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _webCrawlerDataSource = value;
            }
        }
    }
}
