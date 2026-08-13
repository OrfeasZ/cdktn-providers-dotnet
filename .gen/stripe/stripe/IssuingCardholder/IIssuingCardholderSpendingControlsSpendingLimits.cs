using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCardholder
{
    [JsiiInterface(nativeType: typeof(IIssuingCardholderSpendingControlsSpendingLimits), fullyQualifiedName: "stripe.issuingCardholder.IssuingCardholderSpendingControlsSpendingLimits")]
    public interface IIssuingCardholderSpendingControlsSpendingLimits
    {
        /// <summary>Maximum amount allowed to spend per interval.</summary>
        /// <remarks>
        /// This amount is in the card's currency and in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#amount IssuingCardholder#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        double Amount
        {
            get;
        }

        /// <summary>Interval (or event) to which the amount applies.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#interval IssuingCardholder#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        string Interval
        {
            get;
        }

        /// <summary>Array of strings containing [categories](https://docs.stripe.com/api#issuing_authorization_object-merchant_data-category) this limit applies to. Omitting this field will apply the limit to all categories.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#categories IssuingCardholder#categories}
        /// </remarks>
        [JsiiProperty(name: "categories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Categories
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingCardholderSpendingControlsSpendingLimits), fullyQualifiedName: "stripe.issuingCardholder.IssuingCardholderSpendingControlsSpendingLimits")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingCardholder.IIssuingCardholderSpendingControlsSpendingLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Maximum amount allowed to spend per interval.</summary>
            /// <remarks>
            /// This amount is in the card's currency and in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#amount IssuingCardholder#amount}
            /// </remarks>
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
            public double Amount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Interval (or event) to which the amount applies.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#interval IssuingCardholder#interval}
            /// </remarks>
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
            public string Interval
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Array of strings containing [categories](https://docs.stripe.com/api#issuing_authorization_object-merchant_data-category) this limit applies to. Omitting this field will apply the limit to all categories.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#categories IssuingCardholder#categories}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "categories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Categories
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
