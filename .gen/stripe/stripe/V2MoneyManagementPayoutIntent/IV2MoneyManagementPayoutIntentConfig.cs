using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementPayoutIntent
{
    [JsiiInterface(nativeType: typeof(IV2MoneyManagementPayoutIntentConfig), fullyQualifiedName: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentConfig")]
    public interface IV2MoneyManagementPayoutIntentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The monetary amount to be sent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#amount V2MoneyManagementPayoutIntent#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentAmount\"}")]
        stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentAmount Amount
        {
            get;
        }

        /// <summary>The FinancialAccount that funds are pulled from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#from V2MoneyManagementPayoutIntent#from}
        /// </remarks>
        [JsiiProperty(name: "from", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFrom\"}")]
        stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentFrom From
        {
            get;
        }

        /// <summary>To which payout method the payout is sent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#to V2MoneyManagementPayoutIntent#to}
        /// </remarks>
        [JsiiProperty(name: "to", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentTo\"}")]
        stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentTo To
        {
            get;
        }

        /// <summary>Controls whether the PayoutIntent requires explicit confirmation before transitioning to `pending`.</summary>
        /// <remarks>
        /// Even when <c>automatic</c>, regulatory requirements may require confirmation. See <a href="https://docs.stripe.com/global-payouts/send-money">Send money with Global Payouts</a> for details.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#confirmation_method V2MoneyManagementPayoutIntent#confirmation_method}
        /// </remarks>
        [JsiiProperty(name: "confirmationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfirmationMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>An arbitrary string attached to the PayoutIntent. Often useful for displaying to users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#description V2MoneyManagementPayoutIntent#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of key-value pairs that you can attach to an object.</summary>
        /// <remarks>
        /// This can be useful for storing additional information about the object in a structured format.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#metadata V2MoneyManagementPayoutIntent#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Recipient notification settings for the PayoutIntent. Only applicable when the PayoutIntent creates an OutboundPayment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#recipient_notification V2MoneyManagementPayoutIntent#recipient_notification}
        /// </remarks>
        [JsiiProperty(name: "recipientNotification", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentRecipientNotification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentRecipientNotification? RecipientNotification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Scheduling options for the payout. If omitted, the payout is scheduled for immediate execution.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#schedule_options V2MoneyManagementPayoutIntent#schedule_options}
        /// </remarks>
        [JsiiProperty(name: "scheduleOptions", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentScheduleOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentScheduleOptions? ScheduleOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>The description that appears on the receiving end for the payout (for example, on a bank statement).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#statement_descriptor V2MoneyManagementPayoutIntent#statement_descriptor}
        /// </remarks>
        [JsiiProperty(name: "statementDescriptor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StatementDescriptor
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IV2MoneyManagementPayoutIntentConfig), fullyQualifiedName: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The monetary amount to be sent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#amount V2MoneyManagementPayoutIntent#amount}
            /// </remarks>
            [JsiiProperty(name: "amount", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentAmount\"}")]
            public stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentAmount Amount
            {
                get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentAmount>()!;
            }

            /// <summary>The FinancialAccount that funds are pulled from.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#from V2MoneyManagementPayoutIntent#from}
            /// </remarks>
            [JsiiProperty(name: "from", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFrom\"}")]
            public stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentFrom From
            {
                get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentFrom>()!;
            }

            /// <summary>To which payout method the payout is sent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#to V2MoneyManagementPayoutIntent#to}
            /// </remarks>
            [JsiiProperty(name: "to", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentTo\"}")]
            public stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentTo To
            {
                get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentTo>()!;
            }

            /// <summary>Controls whether the PayoutIntent requires explicit confirmation before transitioning to `pending`.</summary>
            /// <remarks>
            /// Even when <c>automatic</c>, regulatory requirements may require confirmation. See <a href="https://docs.stripe.com/global-payouts/send-money">Send money with Global Payouts</a> for details.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#confirmation_method V2MoneyManagementPayoutIntent#confirmation_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "confirmationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfirmationMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>An arbitrary string attached to the PayoutIntent. Often useful for displaying to users.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#description V2MoneyManagementPayoutIntent#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set of key-value pairs that you can attach to an object.</summary>
            /// <remarks>
            /// This can be useful for storing additional information about the object in a structured format.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#metadata V2MoneyManagementPayoutIntent#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Recipient notification settings for the PayoutIntent. Only applicable when the PayoutIntent creates an OutboundPayment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#recipient_notification V2MoneyManagementPayoutIntent#recipient_notification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recipientNotification", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentRecipientNotification\"}", isOptional: true)]
            public stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentRecipientNotification? RecipientNotification
            {
                get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentRecipientNotification?>();
            }

            /// <summary>Scheduling options for the payout. If omitted, the payout is scheduled for immediate execution.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#schedule_options V2MoneyManagementPayoutIntent#schedule_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scheduleOptions", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentScheduleOptions\"}", isOptional: true)]
            public stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentScheduleOptions? ScheduleOptions
            {
                get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentScheduleOptions?>();
            }

            /// <summary>The description that appears on the receiving end for the payout (for example, on a bank statement).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#statement_descriptor V2MoneyManagementPayoutIntent#statement_descriptor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statementDescriptor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StatementDescriptor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
