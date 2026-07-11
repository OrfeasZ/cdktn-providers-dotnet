using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevTestGlobalVmShutdownSchedule
{
    [JsiiInterface(nativeType: typeof(IDevTestGlobalVmShutdownScheduleConfig), fullyQualifiedName: "azurerm.devTestGlobalVmShutdownSchedule.DevTestGlobalVmShutdownScheduleConfig")]
    public interface IDevTestGlobalVmShutdownScheduleConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dev_test_global_vm_shutdown_schedule#daily_recurrence_time DevTestGlobalVmShutdownSchedule#daily_recurrence_time}.</summary>
        [JsiiProperty(name: "dailyRecurrenceTime", typeJson: "{\"primitive\":\"string\"}")]
        string DailyRecurrenceTime
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dev_test_global_vm_shutdown_schedule#location DevTestGlobalVmShutdownSchedule#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>notification_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dev_test_global_vm_shutdown_schedule#notification_settings DevTestGlobalVmShutdownSchedule#notification_settings}
        /// </remarks>
        [JsiiProperty(name: "notificationSettings", typeJson: "{\"fqn\":\"azurerm.devTestGlobalVmShutdownSchedule.DevTestGlobalVmShutdownScheduleNotificationSettings\"}")]
        azurerm.DevTestGlobalVmShutdownSchedule.IDevTestGlobalVmShutdownScheduleNotificationSettings NotificationSettings
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dev_test_global_vm_shutdown_schedule#timezone DevTestGlobalVmShutdownSchedule#timezone}.</summary>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        string Timezone
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dev_test_global_vm_shutdown_schedule#virtual_machine_id DevTestGlobalVmShutdownSchedule#virtual_machine_id}.</summary>
        [JsiiProperty(name: "virtualMachineId", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualMachineId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dev_test_global_vm_shutdown_schedule#enabled DevTestGlobalVmShutdownSchedule#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dev_test_global_vm_shutdown_schedule#id DevTestGlobalVmShutdownSchedule#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dev_test_global_vm_shutdown_schedule#tags DevTestGlobalVmShutdownSchedule#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dev_test_global_vm_shutdown_schedule#timeouts DevTestGlobalVmShutdownSchedule#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.devTestGlobalVmShutdownSchedule.DevTestGlobalVmShutdownScheduleTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DevTestGlobalVmShutdownSchedule.IDevTestGlobalVmShutdownScheduleTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevTestGlobalVmShutdownScheduleConfig), fullyQualifiedName: "azurerm.devTestGlobalVmShutdownSchedule.DevTestGlobalVmShutdownScheduleConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.DevTestGlobalVmShutdownSchedule.IDevTestGlobalVmShutdownScheduleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dev_test_global_vm_shutdown_schedule#daily_recurrence_time DevTestGlobalVmShutdownSchedule#daily_recurrence_time}.</summary>
            [JsiiProperty(name: "dailyRecurrenceTime", typeJson: "{\"primitive\":\"string\"}")]
            public string DailyRecurrenceTime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dev_test_global_vm_shutdown_schedule#location DevTestGlobalVmShutdownSchedule#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>notification_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dev_test_global_vm_shutdown_schedule#notification_settings DevTestGlobalVmShutdownSchedule#notification_settings}
            /// </remarks>
            [JsiiProperty(name: "notificationSettings", typeJson: "{\"fqn\":\"azurerm.devTestGlobalVmShutdownSchedule.DevTestGlobalVmShutdownScheduleNotificationSettings\"}")]
            public azurerm.DevTestGlobalVmShutdownSchedule.IDevTestGlobalVmShutdownScheduleNotificationSettings NotificationSettings
            {
                get => GetInstanceProperty<azurerm.DevTestGlobalVmShutdownSchedule.IDevTestGlobalVmShutdownScheduleNotificationSettings>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dev_test_global_vm_shutdown_schedule#timezone DevTestGlobalVmShutdownSchedule#timezone}.</summary>
            [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
            public string Timezone
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dev_test_global_vm_shutdown_schedule#virtual_machine_id DevTestGlobalVmShutdownSchedule#virtual_machine_id}.</summary>
            [JsiiProperty(name: "virtualMachineId", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualMachineId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dev_test_global_vm_shutdown_schedule#enabled DevTestGlobalVmShutdownSchedule#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dev_test_global_vm_shutdown_schedule#id DevTestGlobalVmShutdownSchedule#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dev_test_global_vm_shutdown_schedule#tags DevTestGlobalVmShutdownSchedule#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/dev_test_global_vm_shutdown_schedule#timeouts DevTestGlobalVmShutdownSchedule#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.devTestGlobalVmShutdownSchedule.DevTestGlobalVmShutdownScheduleTimeouts\"}", isOptional: true)]
            public azurerm.DevTestGlobalVmShutdownSchedule.IDevTestGlobalVmShutdownScheduleTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.DevTestGlobalVmShutdownSchedule.IDevTestGlobalVmShutdownScheduleTimeouts?>();
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
