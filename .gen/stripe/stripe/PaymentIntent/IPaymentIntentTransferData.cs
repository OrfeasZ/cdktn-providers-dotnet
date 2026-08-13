using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentTransferData), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentTransferData")]
    public interface IPaymentIntentTransferData
    {
        /// <summary>The account (if any) that the payment is attributed to for tax reporting, and where funds from the payment are transferred to after payment success.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#destination PaymentIntent#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        string Destination
        {
            get;
        }

        /// <summary>The amount transferred to the destination account.</summary>
        /// <remarks>
        /// This transfer will occur automatically after the payment succeeds. If no amount is specified, by default the entire payment amount is transferred to the destination account.
        /// The amount must be less than or equal to the <a href="https://docs.stripe.com/api/payment_intents/object#payment_intent_object-amount">amount</a>, and must be a positive integer
        /// representing how much to transfer in the smallest currency unit (e.g., 100 cents to charge $1.00).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#amount PaymentIntent#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Amount
        {
            get
            {
                return null;
            }
        }

        /// <summary>An arbitrary string attached to the transfer. Often useful for displaying to users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#description PaymentIntent#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#metadata PaymentIntent#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#payment_data PaymentIntent#payment_data}.</summary>
        [JsiiProperty(name: "paymentData", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentTransferDataPaymentData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentTransferDataPaymentData? PaymentData
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentTransferData), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentTransferData")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentTransferData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account (if any) that the payment is attributed to for tax reporting, and where funds from the payment are transferred to after payment success.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#destination PaymentIntent#destination}
            /// </remarks>
            [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
            public string Destination
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The amount transferred to the destination account.</summary>
            /// <remarks>
            /// This transfer will occur automatically after the payment succeeds. If no amount is specified, by default the entire payment amount is transferred to the destination account.
            /// The amount must be less than or equal to the <a href="https://docs.stripe.com/api/payment_intents/object#payment_intent_object-amount">amount</a>, and must be a positive integer
            /// representing how much to transfer in the smallest currency unit (e.g., 100 cents to charge $1.00).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#amount PaymentIntent#amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Amount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>An arbitrary string attached to the transfer. Often useful for displaying to users.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#description PaymentIntent#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#metadata PaymentIntent#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#payment_data PaymentIntent#payment_data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "paymentData", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentTransferDataPaymentData\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentTransferDataPaymentData? PaymentData
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentTransferDataPaymentData?>();
            }
        }
    }
}
