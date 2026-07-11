using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SubscriptionCostManagementExport
{
    [JsiiInterface(nativeType: typeof(ISubscriptionCostManagementExportConfig), fullyQualifiedName: "azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportConfig")]
    public interface ISubscriptionCostManagementExportConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>export_data_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#export_data_options SubscriptionCostManagementExport#export_data_options}
        /// </remarks>
        [JsiiProperty(name: "exportDataOptions", typeJson: "{\"fqn\":\"azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportExportDataOptions\"}")]
        azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportExportDataOptions ExportDataOptions
        {
            get;
        }

        /// <summary>export_data_storage_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#export_data_storage_location SubscriptionCostManagementExport#export_data_storage_location}
        /// </remarks>
        [JsiiProperty(name: "exportDataStorageLocation", typeJson: "{\"fqn\":\"azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportExportDataStorageLocation\"}")]
        azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportExportDataStorageLocation ExportDataStorageLocation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#name SubscriptionCostManagementExport#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#recurrence_period_end_date SubscriptionCostManagementExport#recurrence_period_end_date}.</summary>
        [JsiiProperty(name: "recurrencePeriodEndDate", typeJson: "{\"primitive\":\"string\"}")]
        string RecurrencePeriodEndDate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#recurrence_period_start_date SubscriptionCostManagementExport#recurrence_period_start_date}.</summary>
        [JsiiProperty(name: "recurrencePeriodStartDate", typeJson: "{\"primitive\":\"string\"}")]
        string RecurrencePeriodStartDate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#recurrence_type SubscriptionCostManagementExport#recurrence_type}.</summary>
        [JsiiProperty(name: "recurrenceType", typeJson: "{\"primitive\":\"string\"}")]
        string RecurrenceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#subscription_id SubscriptionCostManagementExport#subscription_id}.</summary>
        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        string SubscriptionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#active SubscriptionCostManagementExport#active}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Active
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#file_format SubscriptionCostManagementExport#file_format}.</summary>
        [JsiiProperty(name: "fileFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FileFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#id SubscriptionCostManagementExport#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#timeouts SubscriptionCostManagementExport#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionCostManagementExportConfig), fullyQualifiedName: "azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>export_data_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#export_data_options SubscriptionCostManagementExport#export_data_options}
            /// </remarks>
            [JsiiProperty(name: "exportDataOptions", typeJson: "{\"fqn\":\"azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportExportDataOptions\"}")]
            public azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportExportDataOptions ExportDataOptions
            {
                get => GetInstanceProperty<azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportExportDataOptions>()!;
            }

            /// <summary>export_data_storage_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#export_data_storage_location SubscriptionCostManagementExport#export_data_storage_location}
            /// </remarks>
            [JsiiProperty(name: "exportDataStorageLocation", typeJson: "{\"fqn\":\"azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportExportDataStorageLocation\"}")]
            public azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportExportDataStorageLocation ExportDataStorageLocation
            {
                get => GetInstanceProperty<azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportExportDataStorageLocation>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#name SubscriptionCostManagementExport#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#recurrence_period_end_date SubscriptionCostManagementExport#recurrence_period_end_date}.</summary>
            [JsiiProperty(name: "recurrencePeriodEndDate", typeJson: "{\"primitive\":\"string\"}")]
            public string RecurrencePeriodEndDate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#recurrence_period_start_date SubscriptionCostManagementExport#recurrence_period_start_date}.</summary>
            [JsiiProperty(name: "recurrencePeriodStartDate", typeJson: "{\"primitive\":\"string\"}")]
            public string RecurrencePeriodStartDate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#recurrence_type SubscriptionCostManagementExport#recurrence_type}.</summary>
            [JsiiProperty(name: "recurrenceType", typeJson: "{\"primitive\":\"string\"}")]
            public string RecurrenceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#subscription_id SubscriptionCostManagementExport#subscription_id}.</summary>
            [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubscriptionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#active SubscriptionCostManagementExport#active}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Active
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#file_format SubscriptionCostManagementExport#file_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FileFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#id SubscriptionCostManagementExport#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/subscription_cost_management_export#timeouts SubscriptionCostManagementExport#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportTimeouts\"}", isOptional: true)]
            public azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportTimeouts?>();
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
