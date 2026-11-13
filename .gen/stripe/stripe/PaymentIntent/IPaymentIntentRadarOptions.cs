using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentRadarOptions), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentRadarOptions")]
    public interface IPaymentIntentRadarOptions
    {
        /// <summary>The referrer URL of the current checkout session.</summary>
        /// <remarks>
        /// You can use this to supply session-level referrer data when a Radar Session isn't available or doesn't contain a referrer.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#referrer PaymentIntent#referrer}
        /// </remarks>
        [JsiiProperty(name: "referrer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Referrer
        {
            get
            {
                return null;
            }
        }

        /// <summary>A [Radar Session](https://docs.stripe.com/radar/radar-session) is a snapshot of the browser metadata and device details that help Radar make more accurate predictions on your payments.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#session PaymentIntent#session}
        /// </remarks>
        [JsiiProperty(name: "session", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Session
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentRadarOptions), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentRadarOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentRadarOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The referrer URL of the current checkout session.</summary>
            /// <remarks>
            /// You can use this to supply session-level referrer data when a Radar Session isn't available or doesn't contain a referrer.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#referrer PaymentIntent#referrer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "referrer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Referrer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A [Radar Session](https://docs.stripe.com/radar/radar-session) is a snapshot of the browser metadata and device details that help Radar make more accurate predictions on your payments.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/payment_intent#session PaymentIntent#session}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "session", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Session
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
