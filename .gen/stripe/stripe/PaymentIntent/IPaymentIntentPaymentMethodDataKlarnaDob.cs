using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodDataKlarnaDob), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataKlarnaDob")]
    public interface IPaymentIntentPaymentMethodDataKlarnaDob
    {
        /// <summary>The day of birth, between 1 and 31.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#day PaymentIntent#day}
        /// </remarks>
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"number\"}")]
        double Day
        {
            get;
        }

        /// <summary>The month of birth, between 1 and 12.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#month PaymentIntent#month}
        /// </remarks>
        [JsiiProperty(name: "month", typeJson: "{\"primitive\":\"number\"}")]
        double Month
        {
            get;
        }

        /// <summary>The four-digit year of birth.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#year PaymentIntent#year}
        /// </remarks>
        [JsiiProperty(name: "year", typeJson: "{\"primitive\":\"number\"}")]
        double Year
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodDataKlarnaDob), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataKlarnaDob")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodDataKlarnaDob
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The day of birth, between 1 and 31.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#day PaymentIntent#day}
            /// </remarks>
            [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"number\"}")]
            public double Day
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The month of birth, between 1 and 12.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#month PaymentIntent#month}
            /// </remarks>
            [JsiiProperty(name: "month", typeJson: "{\"primitive\":\"number\"}")]
            public double Month
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The four-digit year of birth.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#year PaymentIntent#year}
            /// </remarks>
            [JsiiProperty(name: "year", typeJson: "{\"primitive\":\"number\"}")]
            public double Year
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
