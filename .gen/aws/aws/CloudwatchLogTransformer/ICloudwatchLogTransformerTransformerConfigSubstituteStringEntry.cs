using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogTransformer
{
    [JsiiInterface(nativeType: typeof(ICloudwatchLogTransformerTransformerConfigSubstituteStringEntry), fullyQualifiedName: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigSubstituteStringEntry")]
    public interface ICloudwatchLogTransformerTransformerConfigSubstituteStringEntry
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#from CloudwatchLogTransformer#from}.</summary>
        [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"string\"}")]
        string From
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#source CloudwatchLogTransformer#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        string Source
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#to CloudwatchLogTransformer#to}.</summary>
        [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"string\"}")]
        string To
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchLogTransformerTransformerConfigSubstituteStringEntry), fullyQualifiedName: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigSubstituteStringEntry")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigSubstituteStringEntry
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#from CloudwatchLogTransformer#from}.</summary>
            [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"string\"}")]
            public string From
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#source CloudwatchLogTransformer#source}.</summary>
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
            public string Source
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#to CloudwatchLogTransformer#to}.</summary>
            [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"string\"}")]
            public string To
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
