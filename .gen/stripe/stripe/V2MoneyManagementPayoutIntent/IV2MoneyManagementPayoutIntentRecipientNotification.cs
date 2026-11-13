using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementPayoutIntent
{
    [JsiiInterface(nativeType: typeof(IV2MoneyManagementPayoutIntentRecipientNotification), fullyQualifiedName: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentRecipientNotification")]
    public interface IV2MoneyManagementPayoutIntentRecipientNotification
    {
        /// <summary>Closed Enum.</summary>
        /// <remarks>
        /// Configuration option to enable or disable notifications to recipients.
        /// Do not send notifications when <c>setting</c> is <c>none</c>. Use the account setting when <c>setting</c> is <c>configured</c> or omitted.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#setting V2MoneyManagementPayoutIntent#setting}
        /// </remarks>
        [JsiiProperty(name: "setting", typeJson: "{\"primitive\":\"string\"}")]
        string Setting
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IV2MoneyManagementPayoutIntentRecipientNotification), fullyQualifiedName: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentRecipientNotification")]
        internal sealed class _Proxy : DeputyBase, stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentRecipientNotification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Closed Enum.</summary>
            /// <remarks>
            /// Configuration option to enable or disable notifications to recipients.
            /// Do not send notifications when <c>setting</c> is <c>none</c>. Use the account setting when <c>setting</c> is <c>configured</c> or omitted.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#setting V2MoneyManagementPayoutIntent#setting}
            /// </remarks>
            [JsiiProperty(name: "setting", typeJson: "{\"primitive\":\"string\"}")]
            public string Setting
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
