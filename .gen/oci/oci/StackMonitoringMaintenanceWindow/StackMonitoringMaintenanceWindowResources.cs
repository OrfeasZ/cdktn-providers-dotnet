using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMaintenanceWindow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.stackMonitoringMaintenanceWindow.StackMonitoringMaintenanceWindowResources")]
    public class StackMonitoringMaintenanceWindowResources : oci.StackMonitoringMaintenanceWindow.IStackMonitoringMaintenanceWindowResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_maintenance_window#resource_id StackMonitoringMaintenanceWindow#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceId
        {
            get;
            set;
        }

        private object? _areMembersIncluded;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_maintenance_window#are_members_included StackMonitoringMaintenanceWindow#are_members_included}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "areMembersIncluded", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AreMembersIncluded
        {
            get => _areMembersIncluded;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _areMembersIncluded = value;
            }
        }
    }
}
