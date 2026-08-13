using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ConsumptionBudgetResourceGroup
{
    [JsiiInterface(nativeType: typeof(IConsumptionBudgetResourceGroupConfig), fullyQualifiedName: "azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupConfig")]
    public interface IConsumptionBudgetResourceGroupConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#amount ConsumptionBudgetResourceGroup#amount}.</summary>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        double Amount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#name ConsumptionBudgetResourceGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>notification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#notification ConsumptionBudgetResourceGroup#notification}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupNotification" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "notification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupNotification\"},\"kind\":\"array\"}}]}}")]
        object Notification
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#resource_group_id ConsumptionBudgetResourceGroup#resource_group_id}.</summary>
        [JsiiProperty(name: "resourceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupId
        {
            get;
        }

        /// <summary>time_period block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#time_period ConsumptionBudgetResourceGroup#time_period}
        /// </remarks>
        [JsiiProperty(name: "timePeriod", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupTimePeriod\"}")]
        azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupTimePeriod TimePeriod
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#etag ConsumptionBudgetResourceGroup#etag}.</summary>
        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Etag
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#filter ConsumptionBudgetResourceGroup#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupFilter? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#id ConsumptionBudgetResourceGroup#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#time_grain ConsumptionBudgetResourceGroup#time_grain}.</summary>
        [JsiiProperty(name: "timeGrain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeGrain
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#timeouts ConsumptionBudgetResourceGroup#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConsumptionBudgetResourceGroupConfig), fullyQualifiedName: "azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#amount ConsumptionBudgetResourceGroup#amount}.</summary>
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
            public double Amount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#name ConsumptionBudgetResourceGroup#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>notification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#notification ConsumptionBudgetResourceGroup#notification}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupNotification" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "notification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupNotification\"},\"kind\":\"array\"}}]}}")]
            public object Notification
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#resource_group_id ConsumptionBudgetResourceGroup#resource_group_id}.</summary>
            [JsiiProperty(name: "resourceGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>time_period block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#time_period ConsumptionBudgetResourceGroup#time_period}
            /// </remarks>
            [JsiiProperty(name: "timePeriod", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupTimePeriod\"}")]
            public azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupTimePeriod TimePeriod
            {
                get => GetInstanceProperty<azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupTimePeriod>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#etag ConsumptionBudgetResourceGroup#etag}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Etag
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#filter ConsumptionBudgetResourceGroup#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupFilter\"}", isOptional: true)]
            public azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupFilter? Filter
            {
                get => GetInstanceProperty<azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupFilter?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#id ConsumptionBudgetResourceGroup#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#time_grain ConsumptionBudgetResourceGroup#time_grain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeGrain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeGrain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/consumption_budget_resource_group#timeouts ConsumptionBudgetResourceGroup#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.consumptionBudgetResourceGroup.ConsumptionBudgetResourceGroupTimeouts\"}", isOptional: true)]
            public azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ConsumptionBudgetResourceGroup.IConsumptionBudgetResourceGroupTimeouts?>();
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
