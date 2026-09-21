using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskChannel
{
    [JsiiInterface(nativeType: typeof(IMskChannelS3Destination), fullyQualifiedName: "aws.mskChannel.MskChannelS3Destination")]
    public interface IMskChannelS3Destination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#service_execution_role_arn MskChannel#service_execution_role_arn}.</summary>
        [JsiiProperty(name: "serviceExecutionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceExecutionRoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#data_freshness_in_seconds MskChannel#data_freshness_in_seconds}.</summary>
        [JsiiProperty(name: "dataFreshnessInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DataFreshnessInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>dead_letter_queue_s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#dead_letter_queue_s3 MskChannel#dead_letter_queue_s3}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelS3DestinationDeadLetterQueueS3" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "deadLetterQueueS3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelS3DestinationDeadLetterQueueS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeadLetterQueueS3
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#storage MskChannel#storage}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelS3DestinationStorage" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "storage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelS3DestinationStorage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Storage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskChannelS3Destination), fullyQualifiedName: "aws.mskChannel.MskChannelS3Destination")]
        internal sealed class _Proxy : DeputyBase, aws.MskChannel.IMskChannelS3Destination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#service_execution_role_arn MskChannel#service_execution_role_arn}.</summary>
            [JsiiProperty(name: "serviceExecutionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceExecutionRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#data_freshness_in_seconds MskChannel#data_freshness_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataFreshnessInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DataFreshnessInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>dead_letter_queue_s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#dead_letter_queue_s3 MskChannel#dead_letter_queue_s3}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelS3DestinationDeadLetterQueueS3" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deadLetterQueueS3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelS3DestinationDeadLetterQueueS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DeadLetterQueueS3
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#storage MskChannel#storage}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelS3DestinationStorage" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelS3DestinationStorage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Storage
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
