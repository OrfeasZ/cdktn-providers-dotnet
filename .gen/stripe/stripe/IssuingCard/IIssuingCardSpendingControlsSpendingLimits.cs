using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCard
{
    [JsiiInterface(nativeType: typeof(IIssuingCardSpendingControlsSpendingLimits), fullyQualifiedName: "stripe.issuingCard.IssuingCardSpendingControlsSpendingLimits")]
    public interface IIssuingCardSpendingControlsSpendingLimits
    {
        /// <summary>Maximum amount allowed to spend per interval.</summary>
        /// <remarks>
        /// This amount is in the card's currency and in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#amount IssuingCard#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        double Amount
        {
            get;
        }

        /// <summary>Interval (or event) to which the amount applies.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#interval IssuingCard#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        string Interval
        {
            get;
        }

        /// <summary>Array of strings containing [categories](https://docs.stripe.com/api#issuing_authorization_object-merchant_data-category) this limit applies to. Omitting this field will apply the limit to all categories.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#categories IssuingCard#categories}
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

        [JsiiTypeProxy(nativeType: typeof(IIssuingCardSpendingControlsSpendingLimits), fullyQualifiedName: "stripe.issuingCard.IssuingCardSpendingControlsSpendingLimits")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingCard.IIssuingCardSpendingControlsSpendingLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Maximum amount allowed to spend per interval.</summary>
            /// <remarks>
            /// This amount is in the card's currency and in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#amount IssuingCard#amount}
            /// </remarks>
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
            public double Amount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Interval (or event) to which the amount applies.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#interval IssuingCard#interval}
            /// </remarks>
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
            public string Interval
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Array of strings containing [categories](https://docs.stripe.com/api#issuing_authorization_object-merchant_data-category) this limit applies to. Omitting this field will apply the limit to all categories.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#categories IssuingCard#categories}
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
