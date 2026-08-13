using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    [JsiiByValue(fqn: "stripe.source.SourceMandateAcceptanceOnline")]
    public class SourceMandateAcceptanceOnline : stripe.Source.ISourceMandateAcceptanceOnline
    {
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
