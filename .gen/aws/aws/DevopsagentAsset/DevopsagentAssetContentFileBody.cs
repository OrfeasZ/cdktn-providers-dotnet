using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsagentAsset
{
    [JsiiByValue(fqn: "aws.devopsagentAsset.DevopsagentAssetContentFileBody")]
    public class DevopsagentAssetContentFileBody : aws.DevopsagentAsset.IDevopsagentAssetContentFileBody
    {
        /// <summary>Base64-encoded binary file content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#bytes DevopsagentAsset#bytes}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#text DevopsagentAsset#text}
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
