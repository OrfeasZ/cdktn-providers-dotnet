using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LustreFileStorageLustreFileSystem
{
    [JsiiByValue(fqn: "oci.lustreFileStorageLustreFileSystem.LustreFileStorageLustreFileSystemRootSquashConfiguration")]
    public class LustreFileStorageLustreFileSystemRootSquashConfiguration : oci.LustreFileStorageLustreFileSystem.ILustreFileStorageLustreFileSystemRootSquashConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/lustre_file_storage_lustre_file_system#client_exceptions LustreFileStorageLustreFileSystem#client_exceptions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientExceptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ClientExceptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/lustre_file_storage_lustre_file_system#identity_squash LustreFileStorageLustreFileSystem#identity_squash}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identitySquash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentitySquash
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/lustre_file_storage_lustre_file_system#squash_gid LustreFileStorageLustreFileSystem#squash_gid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "squashGid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SquashGid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/lustre_file_storage_lustre_file_system#squash_uid LustreFileStorageLustreFileSystem#squash_uid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "squashUid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SquashUid
        {
            get;
            set;
        }
    }
}
