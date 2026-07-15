using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.BillingBudgetAlertNotification
{
    [JsiiInterface(nativeType: typeof(IBillingBudgetAlertNotificationConfig), fullyQualifiedName: "scaleway.billingBudgetAlertNotification.BillingBudgetAlertNotificationConfig")]
    public interface IBillingBudgetAlertNotificationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID of the budget alert to create notification for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.79.0/docs/resources/billing_budget_alert_notification#budget_alert_id BillingBudgetAlertNotification#budget_alert_id}
        /// </remarks>
        [JsiiProperty(name: "budgetAlertId", typeJson: "{\"primitive\":\"string\"}")]
        string BudgetAlertId
        {
            get;
        }

        /// <summary>List of email addresses to receive email notifications. Precisely one of sms_phone_numbers, email_addresses, or webhook_urls must be set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.79.0/docs/resources/billing_budget_alert_notification#email_addresses BillingBudgetAlertNotification#email_addresses}
        /// </remarks>
        [JsiiProperty(name: "emailAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EmailAddresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of phone numbers to receive SMS notifications. Precisely one of sms_phone_numbers, email_addresses, or webhook_urls must be set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.79.0/docs/resources/billing_budget_alert_notification#sms_phone_numbers BillingBudgetAlertNotification#sms_phone_numbers}
        /// </remarks>
        [JsiiProperty(name: "smsPhoneNumbers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SmsPhoneNumbers
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of webhook URLs to receive webhook notifications. Precisely one of sms_phone_numbers, email_addresses, or webhook_urls must be set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.79.0/docs/resources/billing_budget_alert_notification#webhook_urls BillingBudgetAlertNotification#webhook_urls}
        /// </remarks>
        [JsiiProperty(name: "webhookUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? WebhookUrls
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingBudgetAlertNotificationConfig), fullyQualifiedName: "scaleway.billingBudgetAlertNotification.BillingBudgetAlertNotificationConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.BillingBudgetAlertNotification.IBillingBudgetAlertNotificationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the budget alert to create notification for.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.79.0/docs/resources/billing_budget_alert_notification#budget_alert_id BillingBudgetAlertNotification#budget_alert_id}
            /// </remarks>
            [JsiiProperty(name: "budgetAlertId", typeJson: "{\"primitive\":\"string\"}")]
            public string BudgetAlertId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>List of email addresses to receive email notifications. Precisely one of sms_phone_numbers, email_addresses, or webhook_urls must be set.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.79.0/docs/resources/billing_budget_alert_notification#email_addresses BillingBudgetAlertNotification#email_addresses}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emailAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EmailAddresses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of phone numbers to receive SMS notifications. Precisely one of sms_phone_numbers, email_addresses, or webhook_urls must be set.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.79.0/docs/resources/billing_budget_alert_notification#sms_phone_numbers BillingBudgetAlertNotification#sms_phone_numbers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "smsPhoneNumbers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SmsPhoneNumbers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of webhook URLs to receive webhook notifications. Precisely one of sms_phone_numbers, email_addresses, or webhook_urls must be set.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.79.0/docs/resources/billing_budget_alert_notification#webhook_urls BillingBudgetAlertNotification#webhook_urls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webhookUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? WebhookUrls
            {
                get => GetInstanceProperty<string[]?>();
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
