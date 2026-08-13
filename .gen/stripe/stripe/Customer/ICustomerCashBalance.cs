using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiInterface(nativeType: typeof(ICustomerCashBalance), fullyQualifiedName: "stripe.customer.CustomerCashBalance")]
    public interface ICustomerCashBalance
    {
        /// <summary>settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#settings Customer#settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Customer.ICustomerCashBalanceSettings" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "settings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.customer.CustomerCashBalanceSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Settings
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#settings Customer#settings}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Customer.ICustomerCashBalanceSettings" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "settings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.customer.CustomerCashBalanceSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Settings
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
