using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LustreFileStorageLustreFileSystem
{
    [JsiiByValue(fqn: "oci.lustreFileStorageLustreFileSystem.LustreFileStorageLustreFileSystemMaintenanceWindow")]
    public class LustreFileStorageLustreFileSystemMaintenanceWindow : oci.LustreFileStorageLustreFileSystem.ILustreFileStorageLustreFileSystemMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/lustre_file_storage_lustre_file_system#day_of_week LustreFileStorageLustreFileSystem#day_of_week}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DayOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/lustre_file_storage_lustre_file_system#time_start LustreFileStorageLustreFileSystem#time_start}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeStart
        {
            get;
            set;
        }
    }
}
