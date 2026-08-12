using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LustreFileStorageLustreFileSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.lustreFileStorageLustreFileSystem.LustreFileStorageLustreFileSystemDateTimeDetails")]
    public class LustreFileStorageLustreFileSystemDateTimeDetails : oci.LustreFileStorageLustreFileSystem.ILustreFileStorageLustreFileSystemDateTimeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/lustre_file_storage_lustre_file_system#date LustreFileStorageLustreFileSystem#date}.</summary>
        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}")]
        public string Date
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/lustre_file_storage_lustre_file_system#time LustreFileStorageLustreFileSystem#time}.</summary>
        [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}")]
        public string Time
        {
            get;
            set;
        }
    }
}
