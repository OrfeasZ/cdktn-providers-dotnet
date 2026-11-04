using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Microvm
{
    [JsiiByValue(fqn: "digitalocean.microvm.MicrovmEgressPolicyRule")]
    public class MicrovmEgressPolicyRule : digitalocean.Microvm.IMicrovmEgressPolicyRule
    {
        /// <summary>An exact host such as 'api.example.com', or a wildcard such as '*.example.com'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/microvm#domain Microvm#domain}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Domain
        {
            get;
            set;
        }

        /// <summary>An exact IP address. CIDR ranges are not supported.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/microvm#ip Microvm#ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ip
        {
            get;
            set;
        }
    }
}
