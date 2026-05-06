using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMaintenanceWindow
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringMaintenanceWindowResources), fullyQualifiedName: "oci.stackMonitoringMaintenanceWindow.StackMonitoringMaintenanceWindowResources")]
    public interface IStackMonitoringMaintenanceWindowResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_maintenance_window#resource_id StackMonitoringMaintenanceWindow#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_maintenance_window#are_members_included StackMonitoringMaintenanceWindow#are_members_included}.</summary>
        [JsiiProperty(name: "areMembersIncluded", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AreMembersIncluded
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringMaintenanceWindowResources), fullyQualifiedName: "oci.stackMonitoringMaintenanceWindow.StackMonitoringMaintenanceWindowResources")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringMaintenanceWindow.IStackMonitoringMaintenanceWindowResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_maintenance_window#resource_id StackMonitoringMaintenanceWindow#resource_id}.</summary>
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_maintenance_window#are_members_included StackMonitoringMaintenanceWindow#are_members_included}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "areMembersIncluded", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AreMembersIncluded
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
