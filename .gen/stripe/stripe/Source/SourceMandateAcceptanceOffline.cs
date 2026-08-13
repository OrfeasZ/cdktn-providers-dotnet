using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.source.SourceMandateAcceptanceOffline")]
    public class SourceMandateAcceptanceOffline : stripe.Source.ISourceMandateAcceptanceOffline
    {
        /// <summary>An email to contact you with if a copy of the mandate is requested, required if `type` is `offline`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#contact_email Source#contact_email}
        /// </remarks>
        [JsiiProperty(name: "contactEmail", typeJson: "{\"primitive\":\"string\"}")]
        public string ContactEmail
        {
            get;
            set;
        }
    }
}
