using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskChannel
{
    [JsiiInterface(nativeType: typeof(IMskChannelTopicConfiguration), fullyQualifiedName: "aws.mskChannel.MskChannelTopicConfiguration")]
    public interface IMskChannelTopicConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#topic_arn MskChannel#topic_arn}.</summary>
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
        string TopicArn
        {
            get;
        }

        /// <summary>record_converter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#record_converter MskChannel#record_converter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelTopicConfigurationRecordConverter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "recordConverter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelTopicConfigurationRecordConverter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecordConverter
        {
            get
            {
                return null;
            }
        }

        /// <summary>record_schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#record_schema MskChannel#record_schema}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelTopicConfigurationRecordSchema" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "recordSchema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelTopicConfigurationRecordSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecordSchema
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskChannelTopicConfiguration), fullyQualifiedName: "aws.mskChannel.MskChannelTopicConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.MskChannel.IMskChannelTopicConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#topic_arn MskChannel#topic_arn}.</summary>
            [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TopicArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>record_converter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#record_converter MskChannel#record_converter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelTopicConfigurationRecordConverter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recordConverter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelTopicConfigurationRecordConverter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RecordConverter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>record_schema block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#record_schema MskChannel#record_schema}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelTopicConfigurationRecordSchema" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recordSchema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelTopicConfigurationRecordSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RecordSchema
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
