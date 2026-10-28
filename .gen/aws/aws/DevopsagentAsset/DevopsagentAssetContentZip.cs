using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsagentAsset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.devopsagentAsset.DevopsagentAssetContentZip")]
    public class DevopsagentAssetContentZip : aws.DevopsagentAsset.IDevopsagentAssetContentZip
    {
        /// <summary>Base64-encoded ZIP archive. Use filebase64() to load a local ZIP file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#zip_file DevopsagentAsset#zip_file}
        /// </remarks>
        [JsiiProperty(name: "zipFile", typeJson: "{\"primitive\":\"string\"}")]
        public string ZipFile
        {
            get;
            set;
        }
    }
}
