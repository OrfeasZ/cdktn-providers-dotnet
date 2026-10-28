using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsagentAsset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.devopsagentAsset.DevopsagentAssetContentSourceUrl")]
    public class DevopsagentAssetContentSourceUrl : aws.DevopsagentAsset.IDevopsagentAssetContentSourceUrl
    {
        /// <summary>Source URL from which to import asset content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#url DevopsagentAsset#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }
    }
}
