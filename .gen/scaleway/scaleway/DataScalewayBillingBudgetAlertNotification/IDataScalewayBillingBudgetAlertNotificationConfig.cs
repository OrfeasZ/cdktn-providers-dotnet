using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayBillingBudgetAlertNotification
{
    [JsiiInterface(nativeType: typeof(IDataScalewayBillingBudgetAlertNotificationConfig), fullyQualifiedName: "scaleway.dataScalewayBillingBudgetAlertNotification.DataScalewayBillingBudgetAlertNotificationConfig")]
    public interface IDataScalewayBillingBudgetAlertNotificationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID of the budget alert notification to retrieve.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/data-sources/billing_budget_alert_notification#notification_id DataScalewayBillingBudgetAlertNotification#notification_id}
        /// </remarks>
        [JsiiProperty(name: "notificationId", typeJson: "{\"primitive\":\"string\"}")]
        string NotificationId
        {
            get;
        }

        /// <summary>The ID of the budget alert. If not provided, it will be retrieved from the notification.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/data-sources/billing_budget_alert_notification#budget_alert_id DataScalewayBillingBudgetAlertNotification#budget_alert_id}
        /// </remarks>
        [JsiiProperty(name: "budgetAlertId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BudgetAlertId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The organization ID. If not provided, the default organization configured in the provider is used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/data-sources/billing_budget_alert_notification#organization_id DataScalewayBillingBudgetAlertNotification#organization_id}
        /// </remarks>
        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrganizationId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataScalewayBillingBudgetAlertNotificationConfig), fullyQualifiedName: "scaleway.dataScalewayBillingBudgetAlertNotification.DataScalewayBillingBudgetAlertNotificationConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.DataScalewayBillingBudgetAlertNotification.IDataScalewayBillingBudgetAlertNotificationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the budget alert notification to retrieve.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/data-sources/billing_budget_alert_notification#notification_id DataScalewayBillingBudgetAlertNotification#notification_id}
            /// </remarks>
            [JsiiProperty(name: "notificationId", typeJson: "{\"primitive\":\"string\"}")]
            public string NotificationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The ID of the budget alert. If not provided, it will be retrieved from the notification.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/data-sources/billing_budget_alert_notification#budget_alert_id DataScalewayBillingBudgetAlertNotification#budget_alert_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "budgetAlertId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BudgetAlertId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The organization ID. If not provided, the default organization configured in the provider is used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/data-sources/billing_budget_alert_notification#organization_id DataScalewayBillingBudgetAlertNotification#organization_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrganizationId
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
