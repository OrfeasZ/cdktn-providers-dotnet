using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiKnowledgeBase
{
    [JsiiInterface(nativeType: typeof(IGradientaiKnowledgeBaseDatasources), fullyQualifiedName: "digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasources")]
    public interface IGradientaiKnowledgeBaseDatasources
    {
        /// <summary>file_upload_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#file_upload_data_source GradientaiKnowledgeBase#file_upload_data_source}
        /// </remarks>
        [JsiiProperty(name: "fileUploadDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasourcesFileUploadDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#last_indexing_job GradientaiKnowledgeBase#last_indexing_job}
        /// </remarks>
        [JsiiProperty(name: "lastIndexingJob", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasourcesLastIndexingJob\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#spaces_data_source GradientaiKnowledgeBase#spaces_data_source}
        /// </remarks>
        [JsiiProperty(name: "spacesDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasourcesSpacesDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#uuid GradientaiKnowledgeBase#uuid}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#web_crawler_data_source GradientaiKnowledgeBase#web_crawler_data_source}
        /// </remarks>
        [JsiiProperty(name: "webCrawlerDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasourcesWebCrawlerDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WebCrawlerDataSource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGradientaiKnowledgeBaseDatasources), fullyQualifiedName: "digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasources")]
        internal sealed class _Proxy : DeputyBase, digitalocean.GradientaiKnowledgeBase.IGradientaiKnowledgeBaseDatasources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>file_upload_data_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#file_upload_data_source GradientaiKnowledgeBase#file_upload_data_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileUploadDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasourcesFileUploadDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FileUploadDataSource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>last_indexing_job block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#last_indexing_job GradientaiKnowledgeBase#last_indexing_job}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lastIndexingJob", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasourcesLastIndexingJob\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LastIndexingJob
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>spaces_data_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#spaces_data_source GradientaiKnowledgeBase#spaces_data_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spacesDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasourcesSpacesDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SpacesDataSource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>UUID of the Knowledge Base.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#uuid GradientaiKnowledgeBase#uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>web_crawler_data_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#web_crawler_data_source GradientaiKnowledgeBase#web_crawler_data_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webCrawlerDataSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasourcesWebCrawlerDataSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? WebCrawlerDataSource
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
