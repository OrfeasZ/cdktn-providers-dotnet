using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementRunbookVersion
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferences), fullyQualifiedName: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferences")]
    public interface IFleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferences
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#should_notify_on_pause FleetAppsManagementRunbookVersion#should_notify_on_pause}.</summary>
        [JsiiProperty(name: "shouldNotifyOnPause", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldNotifyOnPause
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#should_notify_on_task_failure FleetAppsManagementRunbookVersion#should_notify_on_task_failure}.</summary>
        [JsiiProperty(name: "shouldNotifyOnTaskFailure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldNotifyOnTaskFailure
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#should_notify_on_task_success FleetAppsManagementRunbookVersion#should_notify_on_task_success}.</summary>
        [JsiiProperty(name: "shouldNotifyOnTaskSuccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldNotifyOnTaskSuccess
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferences), fullyQualifiedName: "oci.fleetAppsManagementRunbookVersion.FleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferences")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementRunbookVersion.IFleetAppsManagementRunbookVersionTasksStepPropertiesNotificationPreferences
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#should_notify_on_pause FleetAppsManagementRunbookVersion#should_notify_on_pause}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shouldNotifyOnPause", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldNotifyOnPause
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#should_notify_on_task_failure FleetAppsManagementRunbookVersion#should_notify_on_task_failure}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shouldNotifyOnTaskFailure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldNotifyOnTaskFailure
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_runbook_version#should_notify_on_task_success FleetAppsManagementRunbookVersion#should_notify_on_task_success}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shouldNotifyOnTaskSuccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldNotifyOnTaskSuccess
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
