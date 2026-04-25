using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.CustomSsl
{
    [JsiiByValue(fqn: "cloudflare.customSsl.CustomSslGeoRestrictions")]
    public class CustomSslGeoRestrictions : cloudflare.CustomSsl.ICustomSslGeoRestrictions
    {
        /// <summary>Available values: "us", "eu", "highest_security".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/custom_ssl#label CustomSsl#label}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Label
        {
            get;
            set;
        }
    }
}
