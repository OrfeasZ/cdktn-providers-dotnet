using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.SpectrumApplication
{
    [JsiiByValue(fqn: "cloudflare.spectrumApplication.SpectrumApplicationEdgeIps")]
    public class SpectrumApplicationEdgeIps : cloudflare.SpectrumApplication.ISpectrumApplicationEdgeIps
    {
        /// <summary>The IP versions supported for inbound connections on Spectrum anycast IPs. Available values: "all", "ipv4", "ipv6".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/spectrum_application#connectivity SpectrumApplication#connectivity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectivity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Connectivity
        {
            get;
            set;
        }

        /// <summary>The array of customer owned IPs we broadcast via anycast for this hostname and application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/spectrum_application#ips SpectrumApplication#ips}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ips", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Ips
        {
            get;
            set;
        }

        /// <summary>The type of edge IP configuration specified.</summary>
        /// <remarks>
        /// Dynamically allocated edge IPs use Spectrum anycast IPs in accordance with the connectivity you specify. Only valid with CNAME DNS names.
        /// Available values: "dynamic", "static".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/spectrum_application#type SpectrumApplication#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
