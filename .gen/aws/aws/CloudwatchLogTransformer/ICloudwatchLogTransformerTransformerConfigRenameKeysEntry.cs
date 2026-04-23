using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogTransformer
{
    [JsiiInterface(nativeType: typeof(ICloudwatchLogTransformerTransformerConfigRenameKeysEntry), fullyQualifiedName: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigRenameKeysEntry")]
    public interface ICloudwatchLogTransformerTransformerConfigRenameKeysEntry
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#key CloudwatchLogTransformer#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#rename_to CloudwatchLogTransformer#rename_to}.</summary>
        [JsiiProperty(name: "renameTo", typeJson: "{\"primitive\":\"string\"}")]
        string RenameTo
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

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchLogTransformerTransformerConfigRenameKeysEntry), fullyQualifiedName: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigRenameKeysEntry")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigRenameKeysEntry
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#rename_to CloudwatchLogTransformer#rename_to}.</summary>
            [JsiiProperty(name: "renameTo", typeJson: "{\"primitive\":\"string\"}")]
            public string RenameTo
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
