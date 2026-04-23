using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockModelInvocationLoggingConfiguration
{
    [JsiiInterface(nativeType: typeof(IBedrockModelInvocationLoggingConfigurationLoggingConfig), fullyQualifiedName: "aws.bedrockModelInvocationLoggingConfiguration.BedrockModelInvocationLoggingConfigurationLoggingConfig")]
    public interface IBedrockModelInvocationLoggingConfigurationLoggingConfig
    {
        /// <summary>cloudwatch_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_model_invocation_logging_configuration#cloudwatch_config BedrockModelInvocationLoggingConfiguration#cloudwatch_config}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockModelInvocationLoggingConfiguration.BedrockModelInvocationLoggingConfigurationLoggingConfigCloudwatchConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CloudwatchConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_model_invocation_logging_configuration#embedding_data_delivery_enabled BedrockModelInvocationLoggingConfiguration#embedding_data_delivery_enabled}.</summary>
        [JsiiProperty(name: "embeddingDataDeliveryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EmbeddingDataDeliveryEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_model_invocation_logging_configuration#image_data_delivery_enabled BedrockModelInvocationLoggingConfiguration#image_data_delivery_enabled}.</summary>
        [JsiiProperty(name: "imageDataDeliveryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ImageDataDeliveryEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_model_invocation_logging_configuration#s3_config BedrockModelInvocationLoggingConfiguration#s3_config}
        /// </remarks>
        [JsiiProperty(name: "s3Config", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockModelInvocationLoggingConfiguration.BedrockModelInvocationLoggingConfigurationLoggingConfigS3Config\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3Config
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_model_invocation_logging_configuration#text_data_delivery_enabled BedrockModelInvocationLoggingConfiguration#text_data_delivery_enabled}.</summary>
        [JsiiProperty(name: "textDataDeliveryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TextDataDeliveryEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_model_invocation_logging_configuration#video_data_delivery_enabled BedrockModelInvocationLoggingConfiguration#video_data_delivery_enabled}.</summary>
        [JsiiProperty(name: "videoDataDeliveryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VideoDataDeliveryEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockModelInvocationLoggingConfigurationLoggingConfig), fullyQualifiedName: "aws.bedrockModelInvocationLoggingConfiguration.BedrockModelInvocationLoggingConfigurationLoggingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockModelInvocationLoggingConfiguration.IBedrockModelInvocationLoggingConfigurationLoggingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_model_invocation_logging_configuration#cloudwatch_config BedrockModelInvocationLoggingConfiguration#cloudwatch_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockModelInvocationLoggingConfiguration.BedrockModelInvocationLoggingConfigurationLoggingConfigCloudwatchConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CloudwatchConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_model_invocation_logging_configuration#embedding_data_delivery_enabled BedrockModelInvocationLoggingConfiguration#embedding_data_delivery_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "embeddingDataDeliveryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EmbeddingDataDeliveryEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_model_invocation_logging_configuration#image_data_delivery_enabled BedrockModelInvocationLoggingConfiguration#image_data_delivery_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageDataDeliveryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ImageDataDeliveryEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>s3_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_model_invocation_logging_configuration#s3_config BedrockModelInvocationLoggingConfiguration#s3_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Config", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockModelInvocationLoggingConfiguration.BedrockModelInvocationLoggingConfigurationLoggingConfigS3Config\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3Config
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_model_invocation_logging_configuration#text_data_delivery_enabled BedrockModelInvocationLoggingConfiguration#text_data_delivery_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "textDataDeliveryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? TextDataDeliveryEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrock_model_invocation_logging_configuration#video_data_delivery_enabled BedrockModelInvocationLoggingConfiguration#video_data_delivery_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "videoDataDeliveryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? VideoDataDeliveryEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
