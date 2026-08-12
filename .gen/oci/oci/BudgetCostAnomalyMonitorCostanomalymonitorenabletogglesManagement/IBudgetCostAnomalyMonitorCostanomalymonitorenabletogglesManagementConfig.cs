using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement
{
    [JsiiInterface(nativeType: typeof(IBudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementConfig), fullyQualifiedName: "oci.budgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementConfig")]
    public interface IBudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#cost_anomaly_monitor_id BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#cost_anomaly_monitor_id}.</summary>
        [JsiiProperty(name: "costAnomalyMonitorId", typeJson: "{\"primitive\":\"string\"}")]
        string CostAnomalyMonitorId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#enable_costanomalymonitorenabletoggle BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#enable_costanomalymonitorenabletoggle}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enableCostanomalymonitorenabletoggle", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object EnableCostanomalymonitorenabletoggle
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#id BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#timeouts BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.budgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.IBudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementConfig), fullyQualifiedName: "oci.budgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementConfig")]
        internal sealed class _Proxy : DeputyBase, oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.IBudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#cost_anomaly_monitor_id BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#cost_anomaly_monitor_id}.</summary>
            [JsiiProperty(name: "costAnomalyMonitorId", typeJson: "{\"primitive\":\"string\"}")]
            public string CostAnomalyMonitorId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#enable_costanomalymonitorenabletoggle BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#enable_costanomalymonitorenabletoggle}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enableCostanomalymonitorenabletoggle", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object EnableCostanomalymonitorenabletoggle
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#id BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/budget_cost_anomaly_monitor_costanomalymonitorenabletoggles_management#timeouts BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.budgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts\"}", isOptional: true)]
            public oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.IBudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.BudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagement.IBudgetCostAnomalyMonitorCostanomalymonitorenabletogglesManagementTimeouts?>();
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
