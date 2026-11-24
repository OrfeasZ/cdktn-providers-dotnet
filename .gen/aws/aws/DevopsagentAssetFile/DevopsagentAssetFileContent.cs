using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsagentAssetFile
{
    [JsiiByValue(fqn: "aws.devopsagentAssetFile.DevopsagentAssetFileContent")]
    public class DevopsagentAssetFileContent : aws.DevopsagentAssetFile.IDevopsagentAssetFileContent
    {
        /// <summary>Base64-encoded binary file content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/devopsagent_asset_file#bytes DevopsagentAssetFile#bytes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bytes
        {
            get;
            set;
        }

        /// <summary>Text file content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.74.0/docs/resources/devopsagent_asset_file#text DevopsagentAssetFile#text}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Text
        {
            get;
            set;
        }
    }
}
