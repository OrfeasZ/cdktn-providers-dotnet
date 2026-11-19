using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LustreFileStorageLustreFileSystem
{
    [JsiiInterface(nativeType: typeof(ILustreFileStorageLustreFileSystemTieringConfigurationRules), fullyQualifiedName: "oci.lustreFileStorageLustreFileSystem.LustreFileStorageLustreFileSystemTieringConfigurationRules")]
    public interface ILustreFileStorageLustreFileSystemTieringConfigurationRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#action LustreFileStorageLustreFileSystem#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#path_prefixes LustreFileStorageLustreFileSystem#path_prefixes}.</summary>
        [JsiiProperty(name: "pathPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] PathPrefixes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#archive_after_days_since_last_access LustreFileStorageLustreFileSystem#archive_after_days_since_last_access}.</summary>
        [JsiiProperty(name: "archiveAfterDaysSinceLastAccess", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ArchiveAfterDaysSinceLastAccess
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#min_size_in_bytes LustreFileStorageLustreFileSystem#min_size_in_bytes}.</summary>
        [JsiiProperty(name: "minSizeInBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinSizeInBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#release_after_days_since_last_access LustreFileStorageLustreFileSystem#release_after_days_since_last_access}.</summary>
        [JsiiProperty(name: "releaseAfterDaysSinceLastAccess", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReleaseAfterDaysSinceLastAccess
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILustreFileStorageLustreFileSystemTieringConfigurationRules), fullyQualifiedName: "oci.lustreFileStorageLustreFileSystem.LustreFileStorageLustreFileSystemTieringConfigurationRules")]
        internal sealed class _Proxy : DeputyBase, oci.LustreFileStorageLustreFileSystem.ILustreFileStorageLustreFileSystemTieringConfigurationRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#action LustreFileStorageLustreFileSystem#action}.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#path_prefixes LustreFileStorageLustreFileSystem#path_prefixes}.</summary>
            [JsiiProperty(name: "pathPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] PathPrefixes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#archive_after_days_since_last_access LustreFileStorageLustreFileSystem#archive_after_days_since_last_access}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "archiveAfterDaysSinceLastAccess", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ArchiveAfterDaysSinceLastAccess
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#min_size_in_bytes LustreFileStorageLustreFileSystem#min_size_in_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minSizeInBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinSizeInBytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/lustre_file_storage_lustre_file_system#release_after_days_since_last_access LustreFileStorageLustreFileSystem#release_after_days_since_last_access}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "releaseAfterDaysSinceLastAccess", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReleaseAfterDaysSinceLastAccess
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
