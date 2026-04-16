using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreBrowser
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreBrowserRecordingS3Location), fullyQualifiedName: "aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserRecordingS3Location")]
    public interface IBedrockagentcoreBrowserRecordingS3Location
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_browser#bucket BedrockagentcoreBrowser#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_browser#prefix BedrockagentcoreBrowser#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        string Prefix
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreBrowserRecordingS3Location), fullyQualifiedName: "aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserRecordingS3Location")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserRecordingS3Location
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_browser#bucket BedrockagentcoreBrowser#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_browser#prefix BedrockagentcoreBrowser#prefix}.</summary>
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
            public string Prefix
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
