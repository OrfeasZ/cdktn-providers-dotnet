using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiKnowledgeBase
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanGradientaiKnowledgeBaseLastIndexingJob), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiKnowledgeBase.DataDigitaloceanGradientaiKnowledgeBaseLastIndexingJob")]
    public interface IDataDigitaloceanGradientaiKnowledgeBaseLastIndexingJob
    {
        /// <summary>Number of completed datasources in the last indexing job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#completed_datasources DataDigitaloceanGradientaiKnowledgeBase#completed_datasources}
        /// </remarks>
        [JsiiProperty(name: "completedDatasources", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CompletedDatasources
        {
            get
            {
                return null;
            }
        }

        /// <summary>Datasource UUIDs for the last indexing job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#data_source_uuids DataDigitaloceanGradientaiKnowledgeBase#data_source_uuids}
        /// </remarks>
        [JsiiProperty(name: "dataSourceUuids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DataSourceUuids
        {
            get
            {
                return null;
            }
        }

        /// <summary>Phase of the last indexing job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#phase DataDigitaloceanGradientaiKnowledgeBase#phase}
        /// </remarks>
        [JsiiProperty(name: "phase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Phase
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of tokens processed in the last indexing job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#tokens DataDigitaloceanGradientaiKnowledgeBase#tokens}
        /// </remarks>
        [JsiiProperty(name: "tokens", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Tokens
        {
            get
            {
                return null;
            }
        }

        /// <summary>Total number of datasources in the last indexing job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#total_datasources DataDigitaloceanGradientaiKnowledgeBase#total_datasources}
        /// </remarks>
        [JsiiProperty(name: "totalDatasources", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TotalDatasources
        {
            get
            {
                return null;
            }
        }

        /// <summary>UUID  of the last indexing job.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanGradientaiKnowledgeBaseLastIndexingJob), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiKnowledgeBase.DataDigitaloceanGradientaiKnowledgeBaseLastIndexingJob")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanGradientaiKnowledgeBase.IDataDigitaloceanGradientaiKnowledgeBaseLastIndexingJob
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Number of completed datasources in the last indexing job.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#completed_datasources DataDigitaloceanGradientaiKnowledgeBase#completed_datasources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "completedDatasources", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CompletedDatasources
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Datasource UUIDs for the last indexing job.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#data_source_uuids DataDigitaloceanGradientaiKnowledgeBase#data_source_uuids}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataSourceUuids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DataSourceUuids
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Phase of the last indexing job.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#phase DataDigitaloceanGradientaiKnowledgeBase#phase}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "phase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Phase
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Number of tokens processed in the last indexing job.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#tokens DataDigitaloceanGradientaiKnowledgeBase#tokens}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tokens", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Tokens
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Total number of datasources in the last indexing job.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#total_datasources DataDigitaloceanGradientaiKnowledgeBase#total_datasources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalDatasources", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalDatasources
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>UUID  of the last indexing job.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_knowledge_base#uuid DataDigitaloceanGradientaiKnowledgeBase#uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uuid
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
