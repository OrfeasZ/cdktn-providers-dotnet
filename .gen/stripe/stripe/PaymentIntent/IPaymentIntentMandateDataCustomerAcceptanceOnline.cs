using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentMandateDataCustomerAcceptanceOnline), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentMandateDataCustomerAcceptanceOnline")]
    public interface IPaymentIntentMandateDataCustomerAcceptanceOnline
    {
        /// <summary>The IP address from which the Mandate was accepted by the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#ip_address PaymentIntent#ip_address}
        /// </remarks>
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        string IpAddress
        {
            get;
        }

        /// <summary>The user agent of the browser from which the Mandate was accepted by the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#user_agent PaymentIntent#user_agent}
        /// </remarks>
        [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}")]
        string UserAgent
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentMandateDataCustomerAcceptanceOnline), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentMandateDataCustomerAcceptanceOnline")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentMandateDataCustomerAcceptanceOnline
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The IP address from which the Mandate was accepted by the customer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#ip_address PaymentIntent#ip_address}
            /// </remarks>
            [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string IpAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The user agent of the browser from which the Mandate was accepted by the customer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#user_agent PaymentIntent#user_agent}
            /// </remarks>
            [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}")]
            public string UserAgent
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
