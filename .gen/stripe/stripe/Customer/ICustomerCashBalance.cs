using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiInterface(nativeType: typeof(ICustomerCashBalance), fullyQualifiedName: "stripe.customer.CustomerCashBalance")]
    public interface ICustomerCashBalance
    {
        /// <summary>settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#settings Customer#settings}
        /// </remarks>
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"stripe.customer.CustomerCashBalanceSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Customer.ICustomerCashBalanceSettings? Settings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomerCashBalance), fullyQualifiedName: "stripe.customer.CustomerCashBalance")]
        internal sealed class _Proxy : DeputyBase, stripe.Customer.ICustomerCashBalance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#settings Customer#settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"stripe.customer.CustomerCashBalanceSettings\"}", isOptional: true)]
            public stripe.Customer.ICustomerCashBalanceSettings? Settings
            {
                get => GetInstanceProperty<stripe.Customer.ICustomerCashBalanceSettings?>();
            }
        }
    }
}
