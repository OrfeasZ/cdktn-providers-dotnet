using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskChannel.MskChannelS3Destination")]
    public class MskChannelS3Destination : aws.MskChannel.IMskChannelS3Destination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#service_execution_role_arn MskChannel#service_execution_role_arn}.</summary>
        [JsiiProperty(name: "serviceExecutionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceExecutionRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#data_freshness_in_seconds MskChannel#data_freshness_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataFreshnessInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DataFreshnessInSeconds
        {
            get;
            set;
        }

        private object? _deadLetterQueueS3;

        /// <summary>dead_letter_queue_s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#dead_letter_queue_s3 MskChannel#dead_letter_queue_s3}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelS3DestinationDeadLetterQueueS3" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deadLetterQueueS3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelS3DestinationDeadLetterQueueS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DeadLetterQueueS3
        {
            get => _deadLetterQueueS3;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.MskChannel.IMskChannelS3DestinationDeadLetterQueueS3[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MskChannel.IMskChannelS3DestinationDeadLetterQueueS3).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _deadLetterQueueS3 = value;
            }
        }

        private object? _storage;

        /// <summary>storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.66.0/docs/resources/msk_channel#storage MskChannel#storage}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskChannel.IMskChannelS3DestinationStorage" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskChannel.MskChannelS3DestinationStorage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Storage
        {
            get => _storage;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.MskChannel.IMskChannelS3DestinationStorage[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MskChannel.IMskChannelS3DestinationStorage).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _storage = value;
            }
        }
    }
}
