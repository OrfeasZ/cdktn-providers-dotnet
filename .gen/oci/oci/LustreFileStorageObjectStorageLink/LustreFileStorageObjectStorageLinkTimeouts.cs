using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LustreFileStorageObjectStorageLink
{
    [JsiiByValue(fqn: "oci.lustreFileStorageObjectStorageLink.LustreFileStorageObjectStorageLinkTimeouts")]
    public class LustreFileStorageObjectStorageLinkTimeouts : oci.LustreFileStorageObjectStorageLink.ILustreFileStorageObjectStorageLinkTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/lustre_file_storage_object_storage_link#create LustreFileStorageObjectStorageLink#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/lustre_file_storage_object_storage_link#delete LustreFileStorageObjectStorageLink#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/lustre_file_storage_object_storage_link#update LustreFileStorageObjectStorageLink#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
