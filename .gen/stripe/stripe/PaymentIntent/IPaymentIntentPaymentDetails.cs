using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentDetails), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentDetails")]
    public interface IPaymentIntentPaymentDetails
    {
        /// <summary>A unique value to identify the customer. This field is available only for card payments.</summary>
        /// <remarks>
        /// This field is truncated to 25 alphanumeric characters, excluding spaces, before being sent to card networks.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#customer_reference PaymentIntent#customer_reference}
        /// </remarks>
        [JsiiProperty(name: "customerReference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomerReference
        {
            get
            {
                return null;
            }
        }

        /// <summary>A unique value assigned by the business to identify the transaction. Required for L2 and L3 rates.</summary>
        /// <remarks>
        /// For Cards, this field is truncated to 25 alphanumeric characters, excluding spaces, before being sent to card networks. For Klarna, this field is truncated to 255 characters and is visible to customers when they view the order in the Klarna app.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#order_reference PaymentIntent#order_reference}
        /// </remarks>
        [JsiiProperty(name: "orderReference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrderReference
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentDetails), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentDetails")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A unique value to identify the customer. This field is available only for card payments.</summary>
            /// <remarks>
            /// This field is truncated to 25 alphanumeric characters, excluding spaces, before being sent to card networks.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#customer_reference PaymentIntent#customer_reference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customerReference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerReference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A unique value assigned by the business to identify the transaction. Required for L2 and L3 rates.</summary>
            /// <remarks>
            /// For Cards, this field is truncated to 25 alphanumeric characters, excluding spaces, before being sent to card networks. For Klarna, this field is truncated to 255 characters and is visible to customers when they view the order in the Klarna app.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#order_reference PaymentIntent#order_reference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orderReference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrderReference
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
