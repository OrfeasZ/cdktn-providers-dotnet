using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MqBroker
{
    [JsiiByValue(fqn: "aws.mqBroker.MqBrokerEncryptionOptions")]
    public class MqBrokerEncryptionOptions : aws.MqBroker.IMqBrokerEncryptionOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/mq_broker#kms_key_id MqBroker#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        private object? _useAwsOwnedKey;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/mq_broker#use_aws_owned_key MqBroker#use_aws_owned_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useAwsOwnedKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UseAwsOwnedKey
        {
            get => _useAwsOwnedKey;
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
                _useAwsOwnedKey = value;
            }
        }
    }
}
