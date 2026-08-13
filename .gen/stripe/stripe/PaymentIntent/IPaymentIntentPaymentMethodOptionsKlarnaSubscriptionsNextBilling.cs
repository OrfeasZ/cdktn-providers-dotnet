using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling")]
    public interface IPaymentIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling
    {
        /// <summary>The amount of the next charge for the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#amount PaymentIntent#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        double Amount
        {
            get;
        }

        /// <summary>The date of the next charge for the subscription in YYYY-MM-DD format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#date PaymentIntent#date}
        /// </remarks>
        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}")]
        string Date
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsKlarnaSubscriptionsNextBilling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The amount of the next charge for the subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#amount PaymentIntent#amount}
            /// </remarks>
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
            public double Amount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The date of the next charge for the subscription in YYYY-MM-DD format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#date PaymentIntent#date}
            /// </remarks>
            [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}")]
            public string Date
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
