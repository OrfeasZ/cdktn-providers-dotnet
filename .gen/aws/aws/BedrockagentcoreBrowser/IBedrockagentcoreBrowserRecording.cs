using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreBrowser
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreBrowserRecording), fullyQualifiedName: "aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserRecording")]
    public interface IBedrockagentcoreBrowserRecording
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_browser#enabled BedrockagentcoreBrowser#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_browser#s3_location BedrockagentcoreBrowser#s3_location}
        /// </remarks>
        [JsiiProperty(name: "s3Location", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserRecordingS3Location\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3Location
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreBrowserRecording), fullyQualifiedName: "aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserRecording")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserRecording
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_browser#enabled BedrockagentcoreBrowser#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>s3_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_browser#s3_location BedrockagentcoreBrowser#s3_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Location", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserRecordingS3Location\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3Location
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
