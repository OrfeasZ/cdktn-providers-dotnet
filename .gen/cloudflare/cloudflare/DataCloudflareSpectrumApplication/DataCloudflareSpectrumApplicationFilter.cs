using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareSpectrumApplication
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareSpectrumApplication.DataCloudflareSpectrumApplicationFilter")]
    public class DataCloudflareSpectrumApplicationFilter : cloudflare.DataCloudflareSpectrumApplication.IDataCloudflareSpectrumApplicationFilter
    {
        /// <summary>Sets the direction by which results are ordered. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/spectrum_application#direction DataCloudflareSpectrumApplication#direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }

        /// <summary>Application field by which results are ordered. Available values: "protocol", "app_id", "created_on", "modified_on", "dns".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/spectrum_application#order DataCloudflareSpectrumApplication#order}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Order
        {
            get;
            set;
        }
    }
}
