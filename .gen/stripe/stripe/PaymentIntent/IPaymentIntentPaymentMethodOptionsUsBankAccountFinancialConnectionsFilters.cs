using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters")]
    public interface IPaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters
    {
        /// <summary>The account subcategories to use to filter for possible accounts to link. Valid subcategories are `checking` and `savings`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#account_subcategories PaymentIntent#account_subcategories}
        /// </remarks>
        [JsiiProperty(name: "accountSubcategories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AccountSubcategories
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account subcategories to use to filter for possible accounts to link. Valid subcategories are `checking` and `savings`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#account_subcategories PaymentIntent#account_subcategories}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountSubcategories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AccountSubcategories
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
