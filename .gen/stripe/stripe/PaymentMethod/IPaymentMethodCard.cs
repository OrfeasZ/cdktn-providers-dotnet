using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodCard), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCard")]
    public interface IPaymentMethodCard
    {
        /// <summary>The card's CVC. It is highly recommended to always include this value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#cvc PaymentMethod#cvc}
        /// </remarks>
        [JsiiProperty(name: "cvc", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Cvc
        {
            get
            {
                return null;
            }
        }

        /// <summary>Two-digit number representing the card's expiration month.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#exp_month PaymentMethod#exp_month}
        /// </remarks>
        [JsiiProperty(name: "expMonth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpMonth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Four-digit number representing the card's expiration year.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#exp_year PaymentMethod#exp_year}
        /// </remarks>
        [JsiiProperty(name: "expYear", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpYear
        {
            get
            {
                return null;
            }
        }

        /// <summary>Contains information about card networks that can be used to process the payment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#networks PaymentMethod#networks}
        /// </remarks>
        [JsiiProperty(name: "networks", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardNetworks\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodCardNetworks? Networks
        {
            get
            {
                return null;
            }
        }

        /// <summary>The card number, as a string without any separators.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#number PaymentMethod#number}
        /// </remarks>
        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Number
        {
            get
            {
                return null;
            }
        }

        /// <summary>For backwards compatibility, you can alternatively provide a Stripe token (e.g., for Apple Pay, Amex Express Checkout, or legacy Checkout) into the card hash with format card: {token: "tok_visa"}.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#token PaymentMethod#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Token
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodCard), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCard")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodCard
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The card's CVC. It is highly recommended to always include this value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#cvc PaymentMethod#cvc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cvc", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Cvc
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Two-digit number representing the card's expiration month.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#exp_month PaymentMethod#exp_month}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expMonth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExpMonth
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Four-digit number representing the card's expiration year.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#exp_year PaymentMethod#exp_year}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expYear", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExpYear
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Contains information about card networks that can be used to process the payment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#networks PaymentMethod#networks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networks", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardNetworks\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodCardNetworks? Networks
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodCardNetworks?>();
            }

            /// <summary>The card number, as a string without any separators.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#number PaymentMethod#number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Number
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>For backwards compatibility, you can alternatively provide a Stripe token (e.g., for Apple Pay, Amex Express Checkout, or legacy Checkout) into the card hash with format card: {token: "tok_visa"}.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#token PaymentMethod#token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Token
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
