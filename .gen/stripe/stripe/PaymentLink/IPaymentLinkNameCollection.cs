using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkNameCollection), fullyQualifiedName: "stripe.paymentLink.PaymentLinkNameCollection")]
    public interface IPaymentLinkNameCollection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#business PaymentLink#business}.</summary>
        [JsiiProperty(name: "business", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkNameCollectionBusiness\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkNameCollectionBusiness? Business
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#individual PaymentLink#individual}.</summary>
        [JsiiProperty(name: "individual", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkNameCollectionIndividual\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkNameCollectionIndividual? Individual
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkNameCollection), fullyQualifiedName: "stripe.paymentLink.PaymentLinkNameCollection")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkNameCollection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#business PaymentLink#business}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "business", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkNameCollectionBusiness\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkNameCollectionBusiness? Business
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkNameCollectionBusiness?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#individual PaymentLink#individual}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "individual", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkNameCollectionIndividual\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkNameCollectionIndividual? Individual
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkNameCollectionIndividual?>();
            }
        }
    }
}
