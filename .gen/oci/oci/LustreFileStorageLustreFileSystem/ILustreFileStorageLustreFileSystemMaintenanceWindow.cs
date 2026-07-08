using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LustreFileStorageLustreFileSystem
{
    [JsiiInterface(nativeType: typeof(ILustreFileStorageLustreFileSystemMaintenanceWindow), fullyQualifiedName: "oci.lustreFileStorageLustreFileSystem.LustreFileStorageLustreFileSystemMaintenanceWindow")]
    public interface ILustreFileStorageLustreFileSystemMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/lustre_file_storage_lustre_file_system#day_of_week LustreFileStorageLustreFileSystem#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DayOfWeek
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/lustre_file_storage_lustre_file_system#time_start LustreFileStorageLustreFileSystem#time_start}.</summary>
        [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeStart
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILustreFileStorageLustreFileSystemMaintenanceWindow), fullyQualifiedName: "oci.lustreFileStorageLustreFileSystem.LustreFileStorageLustreFileSystemMaintenanceWindow")]
        internal sealed class _Proxy : DeputyBase, oci.LustreFileStorageLustreFileSystem.ILustreFileStorageLustreFileSystemMaintenanceWindow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/lustre_file_storage_lustre_file_system#day_of_week LustreFileStorageLustreFileSystem#day_of_week}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DayOfWeek
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/lustre_file_storage_lustre_file_system#time_start LustreFileStorageLustreFileSystem#time_start}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeStart
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
