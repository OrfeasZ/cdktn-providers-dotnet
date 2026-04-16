using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreBrowser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreBrowser.BedrockagentcoreBrowserRecordingS3Location")]
    public class BedrockagentcoreBrowserRecordingS3Location : aws.BedrockagentcoreBrowser.IBedrockagentcoreBrowserRecordingS3Location
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_browser#bucket BedrockagentcoreBrowser#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_browser#prefix BedrockagentcoreBrowser#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public string Prefix
        {
            get;
            set;
        }
    }
}
