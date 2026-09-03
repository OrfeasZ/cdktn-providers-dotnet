using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentKnowledgeBase
{
    [JsiiInterface(nativeType: typeof(IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration), fullyQualifiedName: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration")]
    public interface IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration
    {
        /// <summary>audio block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_knowledge_base#audio BedrockagentKnowledgeBase#audio}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudio" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "audio", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudio\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Audio
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_knowledge_base#dimensions BedrockagentKnowledgeBase#dimensions}.</summary>
        [JsiiProperty(name: "dimensions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Dimensions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_knowledge_base#embedding_data_type BedrockagentKnowledgeBase#embedding_data_type}.</summary>
        [JsiiProperty(name: "embeddingDataType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmbeddingDataType
        {
            get
            {
                return null;
            }
        }

        /// <summary>video block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_knowledge_base#video BedrockagentKnowledgeBase#video}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideo" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "video", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Video
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration), fullyQualifiedName: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>audio block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_knowledge_base#audio BedrockagentKnowledgeBase#audio}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudio" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "audio", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationAudio\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Audio
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_knowledge_base#dimensions BedrockagentKnowledgeBase#dimensions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dimensions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Dimensions
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_knowledge_base#embedding_data_type BedrockagentKnowledgeBase#embedding_data_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "embeddingDataType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmbeddingDataType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>video block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_knowledge_base#video BedrockagentKnowledgeBase#video}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideo" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "video", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfigurationBedrockEmbeddingModelConfigurationVideo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Video
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
