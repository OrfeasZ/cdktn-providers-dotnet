using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiInterface(nativeType: typeof(ICustomerCashBalanceSettings), fullyQualifiedName: "stripe.customer.CustomerCashBalanceSettings")]
    public interface ICustomerCashBalanceSettings
    {
        /// <summary>Controls how funds transferred by the customer are applied to payment intents and invoices.</summary>
        /// <remarks>
        /// Valid options are <c>automatic</c>, <c>manual</c>, or <c>merchant_default</c>. For more information about these reconciliation modes, see <a href="https://stripe.com/docs/payments/customer-balance/reconciliation">Reconciliation</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#reconciliation_mode Customer#reconciliation_mode}
        /// </remarks>
        [JsiiProperty(name: "reconciliationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReconciliationMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomerCashBalanceSettings), fullyQualifiedName: "stripe.customer.CustomerCashBalanceSettings")]
        internal sealed class _Proxy : DeputyBase, stripe.Customer.ICustomerCashBalanceSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls how funds transferred by the customer are applied to payment intents and invoices.</summary>
            /// <remarks>
            /// Valid options are <c>automatic</c>, <c>manual</c>, or <c>merchant_default</c>. For more information about these reconciliation modes, see <a href="https://stripe.com/docs/payments/customer-balance/reconciliation">Reconciliation</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#reconciliation_mode Customer#reconciliation_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reconciliationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReconciliationMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
