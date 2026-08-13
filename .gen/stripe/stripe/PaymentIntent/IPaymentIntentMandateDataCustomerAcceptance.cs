using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentMandateDataCustomerAcceptance), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentMandateDataCustomerAcceptance")]
    public interface IPaymentIntentMandateDataCustomerAcceptance
    {
        /// <summary>The type of customer acceptance information included with the Mandate. One of `online` or `offline`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#type PaymentIntent#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>The time at which the customer accepted the Mandate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#accepted_at PaymentIntent#accepted_at}
        /// </remarks>
        [JsiiProperty(name: "acceptedAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AcceptedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a Mandate accepted online, this hash contains details about the online acceptance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#online PaymentIntent#online}
        /// </remarks>
        [JsiiProperty(name: "online", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentMandateDataCustomerAcceptanceOnline\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentMandateDataCustomerAcceptanceOnline? Online
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentMandateDataCustomerAcceptance), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentMandateDataCustomerAcceptance")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentMandateDataCustomerAcceptance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The type of customer acceptance information included with the Mandate. One of `online` or `offline`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#type PaymentIntent#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The time at which the customer accepted the Mandate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#accepted_at PaymentIntent#accepted_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acceptedAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AcceptedAt
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>If this is a Mandate accepted online, this hash contains details about the online acceptance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#online PaymentIntent#online}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "online", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentMandateDataCustomerAcceptanceOnline\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentMandateDataCustomerAcceptanceOnline? Online
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentMandateDataCustomerAcceptanceOnline?>();
            }
        }
    }
}
