using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedLustreFileSystem
{
    [JsiiInterface(nativeType: typeof(IManagedLustreFileSystemRootSquash), fullyQualifiedName: "azurerm.managedLustreFileSystem.ManagedLustreFileSystemRootSquash")]
    public interface IManagedLustreFileSystemRootSquash
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/managed_lustre_file_system#mode ManagedLustreFileSystem#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/managed_lustre_file_system#no_squash_nids ManagedLustreFileSystem#no_squash_nids}.</summary>
        [JsiiProperty(name: "noSquashNids", typeJson: "{\"primitive\":\"string\"}")]
        string NoSquashNids
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/managed_lustre_file_system#squash_gid ManagedLustreFileSystem#squash_gid}.</summary>
        [JsiiProperty(name: "squashGid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SquashGid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/managed_lustre_file_system#squash_uid ManagedLustreFileSystem#squash_uid}.</summary>
        [JsiiProperty(name: "squashUid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SquashUid
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedLustreFileSystemRootSquash), fullyQualifiedName: "azurerm.managedLustreFileSystem.ManagedLustreFileSystemRootSquash")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemRootSquash
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/managed_lustre_file_system#mode ManagedLustreFileSystem#mode}.</summary>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/managed_lustre_file_system#no_squash_nids ManagedLustreFileSystem#no_squash_nids}.</summary>
            [JsiiProperty(name: "noSquashNids", typeJson: "{\"primitive\":\"string\"}")]
            public string NoSquashNids
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/managed_lustre_file_system#squash_gid ManagedLustreFileSystem#squash_gid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "squashGid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SquashGid
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/managed_lustre_file_system#squash_uid ManagedLustreFileSystem#squash_uid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "squashUid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SquashUid
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
