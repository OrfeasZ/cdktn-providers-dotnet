using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BillingAccountCostManagementExport
{
    [JsiiInterface(nativeType: typeof(IBillingAccountCostManagementExportConfig), fullyQualifiedName: "azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportConfig")]
    public interface IBillingAccountCostManagementExportConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#billing_account_id BillingAccountCostManagementExport#billing_account_id}.</summary>
        [JsiiProperty(name: "billingAccountId", typeJson: "{\"primitive\":\"string\"}")]
        string BillingAccountId
        {
            get;
        }

        /// <summary>export_data_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#export_data_options BillingAccountCostManagementExport#export_data_options}
        /// </remarks>
        [JsiiProperty(name: "exportDataOptions", typeJson: "{\"fqn\":\"azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportExportDataOptions\"}")]
        azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportExportDataOptions ExportDataOptions
        {
            get;
        }

        /// <summary>export_data_storage_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#export_data_storage_location BillingAccountCostManagementExport#export_data_storage_location}
        /// </remarks>
        [JsiiProperty(name: "exportDataStorageLocation", typeJson: "{\"fqn\":\"azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportExportDataStorageLocation\"}")]
        azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportExportDataStorageLocation ExportDataStorageLocation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#name BillingAccountCostManagementExport#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#recurrence_period_end_date BillingAccountCostManagementExport#recurrence_period_end_date}.</summary>
        [JsiiProperty(name: "recurrencePeriodEndDate", typeJson: "{\"primitive\":\"string\"}")]
        string RecurrencePeriodEndDate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#recurrence_period_start_date BillingAccountCostManagementExport#recurrence_period_start_date}.</summary>
        [JsiiProperty(name: "recurrencePeriodStartDate", typeJson: "{\"primitive\":\"string\"}")]
        string RecurrencePeriodStartDate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#recurrence_type BillingAccountCostManagementExport#recurrence_type}.</summary>
        [JsiiProperty(name: "recurrenceType", typeJson: "{\"primitive\":\"string\"}")]
        string RecurrenceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#active BillingAccountCostManagementExport#active}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#file_format BillingAccountCostManagementExport#file_format}.</summary>
        [JsiiProperty(name: "fileFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FileFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#id BillingAccountCostManagementExport#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#timeouts BillingAccountCostManagementExport#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingAccountCostManagementExportConfig), fullyQualifiedName: "azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#billing_account_id BillingAccountCostManagementExport#billing_account_id}.</summary>
            [JsiiProperty(name: "billingAccountId", typeJson: "{\"primitive\":\"string\"}")]
            public string BillingAccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>export_data_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#export_data_options BillingAccountCostManagementExport#export_data_options}
            /// </remarks>
            [JsiiProperty(name: "exportDataOptions", typeJson: "{\"fqn\":\"azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportExportDataOptions\"}")]
            public azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportExportDataOptions ExportDataOptions
            {
                get => GetInstanceProperty<azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportExportDataOptions>()!;
            }

            /// <summary>export_data_storage_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#export_data_storage_location BillingAccountCostManagementExport#export_data_storage_location}
            /// </remarks>
            [JsiiProperty(name: "exportDataStorageLocation", typeJson: "{\"fqn\":\"azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportExportDataStorageLocation\"}")]
            public azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportExportDataStorageLocation ExportDataStorageLocation
            {
                get => GetInstanceProperty<azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportExportDataStorageLocation>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#name BillingAccountCostManagementExport#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#recurrence_period_end_date BillingAccountCostManagementExport#recurrence_period_end_date}.</summary>
            [JsiiProperty(name: "recurrencePeriodEndDate", typeJson: "{\"primitive\":\"string\"}")]
            public string RecurrencePeriodEndDate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#recurrence_period_start_date BillingAccountCostManagementExport#recurrence_period_start_date}.</summary>
            [JsiiProperty(name: "recurrencePeriodStartDate", typeJson: "{\"primitive\":\"string\"}")]
            public string RecurrencePeriodStartDate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#recurrence_type BillingAccountCostManagementExport#recurrence_type}.</summary>
            [JsiiProperty(name: "recurrenceType", typeJson: "{\"primitive\":\"string\"}")]
            public string RecurrenceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#active BillingAccountCostManagementExport#active}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Active
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#file_format BillingAccountCostManagementExport#file_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FileFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#id BillingAccountCostManagementExport#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/billing_account_cost_management_export#timeouts BillingAccountCostManagementExport#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.billingAccountCostManagementExport.BillingAccountCostManagementExportTimeouts\"}", isOptional: true)]
            public azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.BillingAccountCostManagementExport.IBillingAccountCostManagementExportTimeouts?>();
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
