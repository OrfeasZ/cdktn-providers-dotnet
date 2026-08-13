using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.source.SourceMandateAcceptance")]
    public class SourceMandateAcceptance : stripe.Source.ISourceMandateAcceptance
    {
        /// <summary>The status of the mandate acceptance. Either `accepted` (the mandate was accepted) or `refused` (the mandate was refused).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#status Source#status}
        /// </remarks>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public string Status
        {
            get;
            set;
        }

        /// <summary>The Unix timestamp (in seconds) when the mandate was accepted or refused by the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#date Source#date}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Date
        {
            get;
            set;
        }

        /// <summary>The IP address from which the mandate was accepted or refused by the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#ip Source#ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ip
        {
            get;
            set;
        }

        /// <summary>The parameters required to store a mandate accepted offline. Should only be set if `mandate[type]` is `offline`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#offline Source#offline}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "offline", typeJson: "{\"fqn\":\"stripe.source.SourceMandateAcceptanceOffline\"}", isOptional: true)]
        public stripe.Source.ISourceMandateAcceptanceOffline? Offline
        {
            get;
            set;
        }

        /// <summary>The parameters required to store a mandate accepted online. Should only be set if `mandate[type]` is `online`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#online Source#online}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "online", typeJson: "{\"fqn\":\"stripe.source.SourceMandateAcceptanceOnline\"}", isOptional: true)]
        public stripe.Source.ISourceMandateAcceptanceOnline? Online
        {
            get;
            set;
        }

        /// <summary>The type of acceptance information included with the mandate. Either `online` or `offline`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#type Source#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>The user agent of the browser from which the mandate was accepted or refused by the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#user_agent Source#user_agent}
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
