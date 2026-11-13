using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementPayoutIntent
{
    [JsiiInterface(nativeType: typeof(IV2MoneyManagementPayoutIntentScheduleOptions), fullyQualifiedName: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentScheduleOptions")]
    public interface IV2MoneyManagementPayoutIntentScheduleOptions
    {
        /// <summary>The date when the payout should be executed, in YYYY-MM-DD format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#execute_on V2MoneyManagementPayoutIntent#execute_on}
        /// </remarks>
        [JsiiProperty(name: "executeOn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExecuteOn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IV2MoneyManagementPayoutIntentScheduleOptions), fullyQualifiedName: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentScheduleOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentScheduleOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The date when the payout should be executed, in YYYY-MM-DD format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#execute_on V2MoneyManagementPayoutIntent#execute_on}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "executeOn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExecuteOn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
