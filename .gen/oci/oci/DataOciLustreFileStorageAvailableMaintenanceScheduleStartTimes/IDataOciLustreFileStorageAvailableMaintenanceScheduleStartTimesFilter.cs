using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLustreFileStorageAvailableMaintenanceScheduleStartTimes
{
    [JsiiInterface(nativeType: typeof(IDataOciLustreFileStorageAvailableMaintenanceScheduleStartTimesFilter), fullyQualifiedName: "oci.dataOciLustreFileStorageAvailableMaintenanceScheduleStartTimes.DataOciLustreFileStorageAvailableMaintenanceScheduleStartTimesFilter")]
    public interface IDataOciLustreFileStorageAvailableMaintenanceScheduleStartTimesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/data-sources/lustre_file_storage_available_maintenance_schedule_start_times#name DataOciLustreFileStorageAvailableMaintenanceScheduleStartTimes#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/data-sources/lustre_file_storage_available_maintenance_schedule_start_times#values DataOciLustreFileStorageAvailableMaintenanceScheduleStartTimes#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/data-sources/lustre_file_storage_available_maintenance_schedule_start_times#regex DataOciLustreFileStorageAvailableMaintenanceScheduleStartTimes#regex}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciLustreFileStorageAvailableMaintenanceScheduleStartTimesFilter), fullyQualifiedName: "oci.dataOciLustreFileStorageAvailableMaintenanceScheduleStartTimes.DataOciLustreFileStorageAvailableMaintenanceScheduleStartTimesFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciLustreFileStorageAvailableMaintenanceScheduleStartTimes.IDataOciLustreFileStorageAvailableMaintenanceScheduleStartTimesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/data-sources/lustre_file_storage_available_maintenance_schedule_start_times#name DataOciLustreFileStorageAvailableMaintenanceScheduleStartTimes#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/data-sources/lustre_file_storage_available_maintenance_schedule_start_times#values DataOciLustreFileStorageAvailableMaintenanceScheduleStartTimes#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/data-sources/lustre_file_storage_available_maintenance_schedule_start_times#regex DataOciLustreFileStorageAvailableMaintenanceScheduleStartTimes#regex}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
