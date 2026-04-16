using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingServiceAction
{
    [JsiiInterface(nativeType: typeof(IV2BillingServiceActionCreditGrantAmountMonetary), fullyQualifiedName: "stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmountMonetary")]
    public interface IV2BillingServiceActionCreditGrantAmountMonetary
    {
        /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#currency V2BillingServiceAction#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        string Currency
        {
            get;
        }

        /// <summary>A non-negative integer representing how much to charge in the [smallest currency unit](https://docs.stripe.com/currencies#minor-units).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#value V2BillingServiceAction#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        double Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IV2BillingServiceActionCreditGrantAmountMonetary), fullyQualifiedName: "stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmountMonetary")]
        internal sealed class _Proxy : DeputyBase, stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmountMonetary
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#currency V2BillingServiceAction#currency}
            /// </remarks>
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
            public string Currency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A non-negative integer representing how much to charge in the [smallest currency unit](https://docs.stripe.com/currencies#minor-units).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#value V2BillingServiceAction#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
            public double Value
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
