using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisFirehoseDeliveryStream
{
    [JsiiByValue(fqn: "aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamHttpEndpointConfigurationProcessingConfiguration")]
    public class KinesisFirehoseDeliveryStreamHttpEndpointConfigurationProcessingConfiguration : aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamHttpEndpointConfigurationProcessingConfiguration
    {
        private object? _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/kinesis_firehose_delivery_stream#enabled KinesisFirehoseDeliveryStream#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        private object? _processors;

        /// <summary>processors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/kinesis_firehose_delivery_stream#processors KinesisFirehoseDeliveryStream#processors}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamHttpEndpointConfigurationProcessingConfigurationProcessors\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Processors
        {
            get => _processors;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamHttpEndpointConfigurationProcessingConfigurationProcessors[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamHttpEndpointConfigurationProcessingConfigurationProcessors).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _processors = value;
            }
        }
    }
}
