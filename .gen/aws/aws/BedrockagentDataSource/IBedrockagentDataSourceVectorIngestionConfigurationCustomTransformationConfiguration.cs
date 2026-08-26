using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentDataSource
{
    [JsiiInterface(nativeType: typeof(IBedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfiguration), fullyQualifiedName: "aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfiguration")]
    public interface IBedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfiguration
    {
        /// <summary>intermediate_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/bedrockagent_data_source#intermediate_storage BedrockagentDataSource#intermediate_storage}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfigurationIntermediateStorage" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "intermediateStorage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfigurationIntermediateStorage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IntermediateStorage
        {
            get
            {
                return null;
            }
        }

        /// <summary>transformation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/bedrockagent_data_source#transformation BedrockagentDataSource#transformation}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfigurationTransformation" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "transformation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfigurationTransformation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Transformation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfiguration), fullyQualifiedName: "aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>intermediate_storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/bedrockagent_data_source#intermediate_storage BedrockagentDataSource#intermediate_storage}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfigurationIntermediateStorage" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "intermediateStorage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfigurationIntermediateStorage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IntermediateStorage
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>transformation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/bedrockagent_data_source#transformation BedrockagentDataSource#transformation}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentDataSource.IBedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfigurationTransformation" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transformation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentDataSource.BedrockagentDataSourceVectorIngestionConfigurationCustomTransformationConfigurationTransformation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Transformation
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
