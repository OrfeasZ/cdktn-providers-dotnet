using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareFlagshipFlag
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareFlagshipFlag.DataCloudflareFlagshipFlagFilter")]
    public class DataCloudflareFlagshipFlagFilter : cloudflare.DataCloudflareFlagshipFlag.IDataCloudflareFlagshipFlagFilter
    {
        /// <summary>Max items to return (1–200).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/data-sources/flagship_flag#limit DataCloudflareFlagshipFlag#limit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Limit
        {
            get;
            set;
        }
    }
}
