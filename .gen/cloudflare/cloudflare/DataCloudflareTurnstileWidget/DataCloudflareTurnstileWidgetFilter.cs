using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareTurnstileWidget
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareTurnstileWidget.DataCloudflareTurnstileWidgetFilter")]
    public class DataCloudflareTurnstileWidgetFilter : cloudflare.DataCloudflareTurnstileWidget.IDataCloudflareTurnstileWidgetFilter
    {
        /// <summary>Direction to order widgets. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/data-sources/turnstile_widget#direction DataCloudflareTurnstileWidget#direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }

        /// <summary>Field to order widgets by. Available values: "id", "sitekey", "name", "created_on", "modified_on".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/data-sources/turnstile_widget#order DataCloudflareTurnstileWidget#order}
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
