using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.SpectrumApplication
{
    [JsiiByValue(fqn: "cloudflare.spectrumApplication.SpectrumApplicationOriginDns")]
    public class SpectrumApplicationOriginDns : cloudflare.SpectrumApplication.ISpectrumApplicationOriginDns
    {
        /// <summary>The name of the DNS record associated with the origin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#name SpectrumApplication#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>The TTL of our resolution of your DNS record in seconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#ttl SpectrumApplication#ttl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ttl
        {
            get;
            set;
        }

        /// <summary>The type of DNS record associated with the origin.</summary>
        /// <remarks>
        /// "" is used to specify a combination of A/AAAA records.
        /// Available values: "", "A", "AAAA", "SRV".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/spectrum_application#type SpectrumApplication#type}
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
