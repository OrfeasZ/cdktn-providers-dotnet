using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedLustreFileSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managedLustreFileSystem.ManagedLustreFileSystemRootSquash")]
    public class ManagedLustreFileSystemRootSquash : azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemRootSquash
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_lustre_file_system#mode ManagedLustreFileSystem#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_lustre_file_system#no_squash_nids ManagedLustreFileSystem#no_squash_nids}.</summary>
        [JsiiProperty(name: "noSquashNids", typeJson: "{\"primitive\":\"string\"}")]
        public string NoSquashNids
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_lustre_file_system#squash_gid ManagedLustreFileSystem#squash_gid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "squashGid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SquashGid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_lustre_file_system#squash_uid ManagedLustreFileSystem#squash_uid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "squashUid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SquashUid
        {
            get;
            set;
        }
    }
}
