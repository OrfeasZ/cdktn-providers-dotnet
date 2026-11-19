using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LustreFileStorageLustreFileSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.lustreFileStorageLustreFileSystem.LustreFileStorageLustreFileSystemTieringConfigurationRules")]
    public class LustreFileStorageLustreFileSystemTieringConfigurationRules : oci.LustreFileStorageLustreFileSystem.ILustreFileStorageLustreFileSystemTieringConfigurationRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#action LustreFileStorageLustreFileSystem#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#path_prefixes LustreFileStorageLustreFileSystem#path_prefixes}.</summary>
        [JsiiProperty(name: "pathPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] PathPrefixes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#archive_after_days_since_last_access LustreFileStorageLustreFileSystem#archive_after_days_since_last_access}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "archiveAfterDaysSinceLastAccess", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ArchiveAfterDaysSinceLastAccess
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#min_size_in_bytes LustreFileStorageLustreFileSystem#min_size_in_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minSizeInBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinSizeInBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#release_after_days_since_last_access LustreFileStorageLustreFileSystem#release_after_days_since_last_access}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "releaseAfterDaysSinceLastAccess", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReleaseAfterDaysSinceLastAccess
        {
            get;
            set;
        }
    }
}
