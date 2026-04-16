using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiKnowledgeBase
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanGradientaiKnowledgeBaseConfig), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiKnowledgeBase.DataDigitaloceanGradientaiKnowledgeBaseConfig")]
    public interface IDataDigitaloceanGradientaiKnowledgeBaseConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Timestamp when the Knowledge Base was added to the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#added_to_agent_at DataDigitaloceanGradientaiKnowledgeBase#added_to_agent_at}
        /// </remarks>
        [JsiiProperty(name: "addedToAgentAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AddedToAgentAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Database ID of the Knowledge Base.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#database_id DataDigitaloceanGradientaiKnowledgeBase#database_id}
        /// </remarks>
        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Embedding model UUID for the Knowledge Base.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#embedding_model_uuid DataDigitaloceanGradientaiKnowledgeBase#embedding_model_uuid}
        /// </remarks>
        [JsiiProperty(name: "embeddingModelUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmbeddingModelUuid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#id DataDigitaloceanGradientaiKnowledgeBase#id}.</summary>
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

        /// <summary>Indicates if the Knowledge Base is public.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#is_public DataDigitaloceanGradientaiKnowledgeBase#is_public}
        /// </remarks>
        [JsiiProperty(name: "isPublic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsPublic
        {
            get
            {
                return null;
            }
        }

        /// <summary>last_indexing_job block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#last_indexing_job DataDigitaloceanGradientaiKnowledgeBase#last_indexing_job}
        /// </remarks>
        [JsiiProperty(name: "lastIndexingJob", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiKnowledgeBase.DataDigitaloceanGradientaiKnowledgeBaseLastIndexingJob\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LastIndexingJob
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the Knowledge Base.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#name DataDigitaloceanGradientaiKnowledgeBase#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Project ID of the Knowledge Base.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#project_id DataDigitaloceanGradientaiKnowledgeBase#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region of the Knowledge Base.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#region DataDigitaloceanGradientaiKnowledgeBase#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of tags.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#tags DataDigitaloceanGradientaiKnowledgeBase#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>User ID of the Knowledge Base.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#user_id DataDigitaloceanGradientaiKnowledgeBase#user_id}
        /// </remarks>
        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserId
        {
            get
            {
                return null;
            }
        }

        /// <summary>UUID of the Knowledge Base.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#uuid DataDigitaloceanGradientaiKnowledgeBase#uuid}
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

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanGradientaiKnowledgeBaseConfig), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiKnowledgeBase.DataDigitaloceanGradientaiKnowledgeBaseConfig")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanGradientaiKnowledgeBase.IDataDigitaloceanGradientaiKnowledgeBaseConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Timestamp when the Knowledge Base was added to the Agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#added_to_agent_at DataDigitaloceanGradientaiKnowledgeBase#added_to_agent_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addedToAgentAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AddedToAgentAt
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Database ID of the Knowledge Base.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#database_id DataDigitaloceanGradientaiKnowledgeBase#database_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Embedding model UUID for the Knowledge Base.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#embedding_model_uuid DataDigitaloceanGradientaiKnowledgeBase#embedding_model_uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "embeddingModelUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmbeddingModelUuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#id DataDigitaloceanGradientaiKnowledgeBase#id}.</summary>
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

            /// <summary>Indicates if the Knowledge Base is public.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#is_public DataDigitaloceanGradientaiKnowledgeBase#is_public}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isPublic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsPublic
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>last_indexing_job block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#last_indexing_job DataDigitaloceanGradientaiKnowledgeBase#last_indexing_job}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lastIndexingJob", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiKnowledgeBase.DataDigitaloceanGradientaiKnowledgeBaseLastIndexingJob\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LastIndexingJob
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Name of the Knowledge Base.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#name DataDigitaloceanGradientaiKnowledgeBase#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Project ID of the Knowledge Base.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#project_id DataDigitaloceanGradientaiKnowledgeBase#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region of the Knowledge Base.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#region DataDigitaloceanGradientaiKnowledgeBase#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>List of tags.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#tags DataDigitaloceanGradientaiKnowledgeBase#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>User ID of the Knowledge Base.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#user_id DataDigitaloceanGradientaiKnowledgeBase#user_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>UUID of the Knowledge Base.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#uuid DataDigitaloceanGradientaiKnowledgeBase#uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uuid
            {
                get => GetInstanceProperty<string?>();
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
