using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiKnowledgeBaseDataSource
{
    [JsiiInterface(nativeType: typeof(IGradientaiKnowledgeBaseDataSourceConfig), fullyQualifiedName: "digitalocean.gradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceConfig")]
    public interface IGradientaiKnowledgeBaseDataSourceConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>UUID of the Knowledge Base.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base_data_source#knowledge_base_uuid GradientaiKnowledgeBaseDataSource#knowledge_base_uuid}
        /// </remarks>
        [JsiiProperty(name: "knowledgeBaseUuid", typeJson: "{\"primitive\":\"string\"}")]
        string KnowledgeBaseUuid
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base_data_source#id GradientaiKnowledgeBaseDataSource#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>spaces_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base_data_source#spaces_data_source GradientaiKnowledgeBaseDataSource#spaces_data_source}
        /// </remarks>
        [JsiiProperty(name: "spacesDataSource", typeJson: "{\"fqn\":\"digitalocean.gradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceSpacesDataSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceSpacesDataSource? SpacesDataSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>web_crawler_data_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base_data_source#web_crawler_data_source GradientaiKnowledgeBaseDataSource#web_crawler_data_source}
        /// </remarks>
        [JsiiProperty(name: "webCrawlerDataSource", typeJson: "{\"fqn\":\"digitalocean.gradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceWebCrawlerDataSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceWebCrawlerDataSource? WebCrawlerDataSource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGradientaiKnowledgeBaseDataSourceConfig), fullyQualifiedName: "digitalocean.gradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceConfig")]
        internal sealed class _Proxy : DeputyBase, digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>UUID of the Knowledge Base.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base_data_source#knowledge_base_uuid GradientaiKnowledgeBaseDataSource#knowledge_base_uuid}
            /// </remarks>
            [JsiiProperty(name: "knowledgeBaseUuid", typeJson: "{\"primitive\":\"string\"}")]
            public string KnowledgeBaseUuid
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base_data_source#id GradientaiKnowledgeBaseDataSource#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>spaces_data_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base_data_source#spaces_data_source GradientaiKnowledgeBaseDataSource#spaces_data_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spacesDataSource", typeJson: "{\"fqn\":\"digitalocean.gradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceSpacesDataSource\"}", isOptional: true)]
            public digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceSpacesDataSource? SpacesDataSource
            {
                get => GetInstanceProperty<digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceSpacesDataSource?>();
            }

            /// <summary>web_crawler_data_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base_data_source#web_crawler_data_source GradientaiKnowledgeBaseDataSource#web_crawler_data_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webCrawlerDataSource", typeJson: "{\"fqn\":\"digitalocean.gradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceWebCrawlerDataSource\"}", isOptional: true)]
            public digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceWebCrawlerDataSource? WebCrawlerDataSource
            {
                get => GetInstanceProperty<digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceWebCrawlerDataSource?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
