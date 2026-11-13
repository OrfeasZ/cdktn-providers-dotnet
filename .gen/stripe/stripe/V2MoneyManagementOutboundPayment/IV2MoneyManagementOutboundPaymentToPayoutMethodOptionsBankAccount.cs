using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementOutboundPayment
{
    [JsiiInterface(nativeType: typeof(IV2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccount), fullyQualifiedName: "stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccount")]
    public interface IV2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccount
    {
        /// <summary>Per-network configuration options.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#preferred_network_options V2MoneyManagementOutboundPayment#preferred_network_options}
        /// </remarks>
        [JsiiProperty(name: "preferredNetworkOptions", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptions? PreferredNetworkOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>The preferred networks to use for this OutboundPayment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#preferred_networks V2MoneyManagementOutboundPayment#preferred_networks}
        /// </remarks>
        [JsiiProperty(name: "preferredNetworks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PreferredNetworks
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IV2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccount), fullyQualifiedName: "stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccount")]
        internal sealed class _Proxy : DeputyBase, stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Per-network configuration options.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#preferred_network_options V2MoneyManagementOutboundPayment#preferred_network_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preferredNetworkOptions", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptions\"}", isOptional: true)]
            public stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptions? PreferredNetworkOptions
            {
                get => GetInstanceProperty<stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptions?>();
            }

            /// <summary>The preferred networks to use for this OutboundPayment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#preferred_networks V2MoneyManagementOutboundPayment#preferred_networks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preferredNetworks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PreferredNetworks
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
