using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiByValue(fqn: "stripe.paymentLink.PaymentLinkNameCollection")]
    public class PaymentLinkNameCollection : stripe.PaymentLink.IPaymentLinkNameCollection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#business PaymentLink#business}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "business", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkNameCollectionBusiness\"}", isOptional: true)]
        public stripe.PaymentLink.IPaymentLinkNameCollectionBusiness? Business
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#individual PaymentLink#individual}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "individual", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkNameCollectionIndividual\"}", isOptional: true)]
        public stripe.PaymentLink.IPaymentLinkNameCollectionIndividual? Individual
        {
            get;
            set;
        }
    }
}
