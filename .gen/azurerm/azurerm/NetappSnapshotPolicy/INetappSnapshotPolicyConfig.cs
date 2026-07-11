using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappSnapshotPolicy
{
    [JsiiInterface(nativeType: typeof(INetappSnapshotPolicyConfig), fullyQualifiedName: "azurerm.netappSnapshotPolicy.NetappSnapshotPolicyConfig")]
    public interface INetappSnapshotPolicyConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#account_name NetappSnapshotPolicy#account_name}.</summary>
        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
        string AccountName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#enabled NetappSnapshotPolicy#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#location NetappSnapshotPolicy#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#name NetappSnapshotPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#resource_group_name NetappSnapshotPolicy#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>daily_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#daily_schedule NetappSnapshotPolicy#daily_schedule}
        /// </remarks>
        [JsiiProperty(name: "dailySchedule", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyDailySchedule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyDailySchedule? DailySchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>hourly_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#hourly_schedule NetappSnapshotPolicy#hourly_schedule}
        /// </remarks>
        [JsiiProperty(name: "hourlySchedule", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyHourlySchedule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyHourlySchedule? HourlySchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#id NetappSnapshotPolicy#id}.</summary>
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

        /// <summary>monthly_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#monthly_schedule NetappSnapshotPolicy#monthly_schedule}
        /// </remarks>
        [JsiiProperty(name: "monthlySchedule", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyMonthlySchedule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyMonthlySchedule? MonthlySchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#tags NetappSnapshotPolicy#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#timeouts NetappSnapshotPolicy#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>weekly_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#weekly_schedule NetappSnapshotPolicy#weekly_schedule}
        /// </remarks>
        [JsiiProperty(name: "weeklySchedule", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyWeeklySchedule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyWeeklySchedule? WeeklySchedule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetappSnapshotPolicyConfig), fullyQualifiedName: "azurerm.netappSnapshotPolicy.NetappSnapshotPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#account_name NetappSnapshotPolicy#account_name}.</summary>
            [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#enabled NetappSnapshotPolicy#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#location NetappSnapshotPolicy#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#name NetappSnapshotPolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#resource_group_name NetappSnapshotPolicy#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>daily_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#daily_schedule NetappSnapshotPolicy#daily_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dailySchedule", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyDailySchedule\"}", isOptional: true)]
            public azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyDailySchedule? DailySchedule
            {
                get => GetInstanceProperty<azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyDailySchedule?>();
            }

            /// <summary>hourly_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#hourly_schedule NetappSnapshotPolicy#hourly_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hourlySchedule", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyHourlySchedule\"}", isOptional: true)]
            public azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyHourlySchedule? HourlySchedule
            {
                get => GetInstanceProperty<azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyHourlySchedule?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#id NetappSnapshotPolicy#id}.</summary>
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

            /// <summary>monthly_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#monthly_schedule NetappSnapshotPolicy#monthly_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monthlySchedule", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyMonthlySchedule\"}", isOptional: true)]
            public azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyMonthlySchedule? MonthlySchedule
            {
                get => GetInstanceProperty<azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyMonthlySchedule?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#tags NetappSnapshotPolicy#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#timeouts NetappSnapshotPolicy#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyTimeouts\"}", isOptional: true)]
            public azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyTimeouts?>();
            }

            /// <summary>weekly_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_snapshot_policy#weekly_schedule NetappSnapshotPolicy#weekly_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "weeklySchedule", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyWeeklySchedule\"}", isOptional: true)]
            public azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyWeeklySchedule? WeeklySchedule
            {
                get => GetInstanceProperty<azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyWeeklySchedule?>();
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
