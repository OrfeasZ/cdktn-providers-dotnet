using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogTransformer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigDateTimeConverter")]
    public class CloudwatchLogTransformerTransformerConfigDateTimeConverter : aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigDateTimeConverter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#match_patterns CloudwatchLogTransformer#match_patterns}.</summary>
        [JsiiProperty(name: "matchPatterns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] MatchPatterns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#source CloudwatchLogTransformer#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public string Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#target CloudwatchLogTransformer#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
        public string Target
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#locale CloudwatchLogTransformer#locale}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Locale
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#source_timezone CloudwatchLogTransformer#source_timezone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceTimezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceTimezone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#target_format CloudwatchLogTransformer#target_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#target_timezone CloudwatchLogTransformer#target_timezone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetTimezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetTimezone
        {
            get;
            set;
        }
    }
}
