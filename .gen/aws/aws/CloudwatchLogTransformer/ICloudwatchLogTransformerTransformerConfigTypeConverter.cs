using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogTransformer
{
    [JsiiInterface(nativeType: typeof(ICloudwatchLogTransformerTransformerConfigTypeConverter), fullyQualifiedName: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigTypeConverter")]
    public interface ICloudwatchLogTransformerTransformerConfigTypeConverter
    {
        /// <summary>entry block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#entry CloudwatchLogTransformer#entry}
        /// </remarks>
        [JsiiProperty(name: "entry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigTypeConverterEntry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Entry
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchLogTransformerTransformerConfigTypeConverter), fullyQualifiedName: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigTypeConverter")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigTypeConverter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>entry block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#entry CloudwatchLogTransformer#entry}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "entry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigTypeConverterEntry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Entry
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
