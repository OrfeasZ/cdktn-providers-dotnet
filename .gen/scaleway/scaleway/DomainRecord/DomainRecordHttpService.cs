using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRecord
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.domainRecord.DomainRecordHttpService")]
    public class DomainRecordHttpService : scaleway.DomainRecord.IDomainRecordHttpService
    {
        /// <summary>IPs to check.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_record#ips DomainRecord#ips}
        /// </remarks>
        [JsiiProperty(name: "ips", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Ips
        {
            get;
            set;
        }

        /// <summary>Text to search.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_record#must_contain DomainRecord#must_contain}
        /// </remarks>
        [JsiiProperty(name: "mustContain", typeJson: "{\"primitive\":\"string\"}")]
        public string MustContain
        {
            get;
            set;
        }

        /// <summary>Strategy to return an IP from the IPs list.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_record#strategy DomainRecord#strategy}
        /// </remarks>
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
        public string Strategy
        {
            get;
            set;
        }

        /// <summary>URL to match the must_contain text to validate an IP.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_record#url DomainRecord#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>User-agent used when checking the URL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_record#user_agent DomainRecord#user_agent}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserAgent
        {
            get;
            set;
        }
    }
}
