using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogTransformer
{
    [JsiiInterface(nativeType: typeof(ICloudwatchLogTransformerTransformerConfigAddKeysEntry), fullyQualifiedName: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigAddKeysEntry")]
    public interface ICloudwatchLogTransformerTransformerConfigAddKeysEntry
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#key CloudwatchLogTransformer#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#value CloudwatchLogTransformer#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#overwrite_if_exists CloudwatchLogTransformer#overwrite_if_exists}.</summary>
        [JsiiProperty(name: "overwriteIfExists", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OverwriteIfExists
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchLogTransformerTransformerConfigAddKeysEntry), fullyQualifiedName: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigAddKeysEntry")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigAddKeysEntry
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#key CloudwatchLogTransformer#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#value CloudwatchLogTransformer#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#overwrite_if_exists CloudwatchLogTransformer#overwrite_if_exists}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "overwriteIfExists", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OverwriteIfExists
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
