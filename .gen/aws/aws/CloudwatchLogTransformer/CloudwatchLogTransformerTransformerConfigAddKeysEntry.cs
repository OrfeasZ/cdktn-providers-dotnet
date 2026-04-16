using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogTransformer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigAddKeysEntry")]
    public class CloudwatchLogTransformerTransformerConfigAddKeysEntry : aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigAddKeysEntry
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#key CloudwatchLogTransformer#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#value CloudwatchLogTransformer#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        private object? _overwriteIfExists;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#overwrite_if_exists CloudwatchLogTransformer#overwrite_if_exists}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "overwriteIfExists", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? OverwriteIfExists
        {
            get => _overwriteIfExists;
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
                _overwriteIfExists = value;
            }
        }
    }
}
