using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ResourceGroupCostManagementView
{
    [JsiiInterface(nativeType: typeof(IResourceGroupCostManagementViewConfig), fullyQualifiedName: "azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewConfig")]
    public interface IResourceGroupCostManagementViewConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#accumulated ResourceGroupCostManagementView#accumulated}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "accumulated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Accumulated
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#chart_type ResourceGroupCostManagementView#chart_type}.</summary>
        [JsiiProperty(name: "chartType", typeJson: "{\"primitive\":\"string\"}")]
        string ChartType
        {
            get;
        }

        /// <summary>dataset block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#dataset ResourceGroupCostManagementView#dataset}
        /// </remarks>
        [JsiiProperty(name: "dataset", typeJson: "{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDataset\"}")]
        azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDataset Dataset
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#display_name ResourceGroupCostManagementView#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#name ResourceGroupCostManagementView#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#report_type ResourceGroupCostManagementView#report_type}.</summary>
        [JsiiProperty(name: "reportType", typeJson: "{\"primitive\":\"string\"}")]
        string ReportType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#resource_group_id ResourceGroupCostManagementView#resource_group_id}.</summary>
        [JsiiProperty(name: "resourceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#timeframe ResourceGroupCostManagementView#timeframe}.</summary>
        [JsiiProperty(name: "timeframe", typeJson: "{\"primitive\":\"string\"}")]
        string Timeframe
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#id ResourceGroupCostManagementView#id}.</summary>
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

        /// <summary>kpi block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#kpi ResourceGroupCostManagementView#kpi}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewKpi" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "kpi", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewKpi\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Kpi
        {
            get
            {
                return null;
            }
        }

        /// <summary>pivot block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#pivot ResourceGroupCostManagementView#pivot}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewPivot" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "pivot", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewPivot\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Pivot
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#timeouts ResourceGroupCostManagementView#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResourceGroupCostManagementViewConfig), fullyQualifiedName: "azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#accumulated ResourceGroupCostManagementView#accumulated}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "accumulated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Accumulated
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#chart_type ResourceGroupCostManagementView#chart_type}.</summary>
            [JsiiProperty(name: "chartType", typeJson: "{\"primitive\":\"string\"}")]
            public string ChartType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>dataset block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#dataset ResourceGroupCostManagementView#dataset}
            /// </remarks>
            [JsiiProperty(name: "dataset", typeJson: "{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewDataset\"}")]
            public azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDataset Dataset
            {
                get => GetInstanceProperty<azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewDataset>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#display_name ResourceGroupCostManagementView#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#name ResourceGroupCostManagementView#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#report_type ResourceGroupCostManagementView#report_type}.</summary>
            [JsiiProperty(name: "reportType", typeJson: "{\"primitive\":\"string\"}")]
            public string ReportType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#resource_group_id ResourceGroupCostManagementView#resource_group_id}.</summary>
            [JsiiProperty(name: "resourceGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#timeframe ResourceGroupCostManagementView#timeframe}.</summary>
            [JsiiProperty(name: "timeframe", typeJson: "{\"primitive\":\"string\"}")]
            public string Timeframe
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#id ResourceGroupCostManagementView#id}.</summary>
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

            /// <summary>kpi block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#kpi ResourceGroupCostManagementView#kpi}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewKpi" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kpi", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewKpi\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Kpi
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>pivot block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#pivot ResourceGroupCostManagementView#pivot}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewPivot" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pivot", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewPivot\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Pivot
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/resource_group_cost_management_view#timeouts ResourceGroupCostManagementView#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.resourceGroupCostManagementView.ResourceGroupCostManagementViewTimeouts\"}", isOptional: true)]
            public azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ResourceGroupCostManagementView.IResourceGroupCostManagementViewTimeouts?>();
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
