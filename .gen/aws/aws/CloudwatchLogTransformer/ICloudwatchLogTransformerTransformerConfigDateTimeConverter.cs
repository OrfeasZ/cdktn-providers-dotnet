using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogTransformer
{
    [JsiiInterface(nativeType: typeof(ICloudwatchLogTransformerTransformerConfigDateTimeConverter), fullyQualifiedName: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigDateTimeConverter")]
    public interface ICloudwatchLogTransformerTransformerConfigDateTimeConverter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#match_patterns CloudwatchLogTransformer#match_patterns}.</summary>
        [JsiiProperty(name: "matchPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] MatchPatterns
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#source CloudwatchLogTransformer#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        string Source
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#target CloudwatchLogTransformer#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
        string Target
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#locale CloudwatchLogTransformer#locale}.</summary>
        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Locale
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#source_timezone CloudwatchLogTransformer#source_timezone}.</summary>
        [JsiiProperty(name: "sourceTimezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceTimezone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#target_format CloudwatchLogTransformer#target_format}.</summary>
        [JsiiProperty(name: "targetFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#target_timezone CloudwatchLogTransformer#target_timezone}.</summary>
        [JsiiProperty(name: "targetTimezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetTimezone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchLogTransformerTransformerConfigDateTimeConverter), fullyQualifiedName: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigDateTimeConverter")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigDateTimeConverter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#match_patterns CloudwatchLogTransformer#match_patterns}.</summary>
            [JsiiProperty(name: "matchPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] MatchPatterns
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#source CloudwatchLogTransformer#source}.</summary>
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
            public string Source
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#target CloudwatchLogTransformer#target}.</summary>
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
            public string Target
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#locale CloudwatchLogTransformer#locale}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Locale
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#source_timezone CloudwatchLogTransformer#source_timezone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceTimezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceTimezone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#target_format CloudwatchLogTransformer#target_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#target_timezone CloudwatchLogTransformer#target_timezone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetTimezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetTimezone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
