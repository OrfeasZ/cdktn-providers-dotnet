using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementPayoutIntent
{
    [JsiiInterface(nativeType: typeof(IV2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccount), fullyQualifiedName: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccount")]
    public interface IV2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccount
    {
        /// <summary>Per-network configuration options.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#preferred_network_options V2MoneyManagementPayoutIntent#preferred_network_options}
        /// </remarks>
        [JsiiProperty(name: "preferredNetworkOptions", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccountPreferredNetworkOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccountPreferredNetworkOptions? PreferredNetworkOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>The preferred networks to use for this PayoutIntent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#preferred_networks V2MoneyManagementPayoutIntent#preferred_networks}
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

        [JsiiTypeProxy(nativeType: typeof(IV2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccount), fullyQualifiedName: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccount")]
        internal sealed class _Proxy : DeputyBase, stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Per-network configuration options.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#preferred_network_options V2MoneyManagementPayoutIntent#preferred_network_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preferredNetworkOptions", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccountPreferredNetworkOptions\"}", isOptional: true)]
            public stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccountPreferredNetworkOptions? PreferredNetworkOptions
            {
                get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentToPayoutMethodOptionsBankAccountPreferredNetworkOptions?>();
            }

            /// <summary>The preferred networks to use for this PayoutIntent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#preferred_networks V2MoneyManagementPayoutIntent#preferred_networks}
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
