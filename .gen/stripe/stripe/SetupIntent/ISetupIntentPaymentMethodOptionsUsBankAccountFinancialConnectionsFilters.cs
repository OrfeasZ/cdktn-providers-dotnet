using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters")]
    public interface ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters
    {
        /// <summary>The account subcategories to use to filter for possible accounts to link. Valid subcategories are `checking` and `savings`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#account_subcategories SetupIntent#account_subcategories}
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

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account subcategories to use to filter for possible accounts to link. Valid subcategories are `checking` and `savings`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#account_subcategories SetupIntent#account_subcategories}
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
