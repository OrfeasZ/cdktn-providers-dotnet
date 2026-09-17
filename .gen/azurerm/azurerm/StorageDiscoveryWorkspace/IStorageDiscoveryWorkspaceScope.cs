using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageDiscoveryWorkspace
{
    [JsiiInterface(nativeType: typeof(IStorageDiscoveryWorkspaceScope), fullyQualifiedName: "azurerm.storageDiscoveryWorkspace.StorageDiscoveryWorkspaceScope")]
    public interface IStorageDiscoveryWorkspaceScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.6.0/docs/resources/storage_discovery_workspace#display_name StorageDiscoveryWorkspace#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.6.0/docs/resources/storage_discovery_workspace#resource_types StorageDiscoveryWorkspace#resource_types}.</summary>
        [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ResourceTypes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.6.0/docs/resources/storage_discovery_workspace#tag_keys_only StorageDiscoveryWorkspace#tag_keys_only}.</summary>
        [JsiiProperty(name: "tagKeysOnly", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TagKeysOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.6.0/docs/resources/storage_discovery_workspace#tags StorageDiscoveryWorkspace#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageDiscoveryWorkspaceScope), fullyQualifiedName: "azurerm.storageDiscoveryWorkspace.StorageDiscoveryWorkspaceScope")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageDiscoveryWorkspace.IStorageDiscoveryWorkspaceScope
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.6.0/docs/resources/storage_discovery_workspace#display_name StorageDiscoveryWorkspace#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.6.0/docs/resources/storage_discovery_workspace#resource_types StorageDiscoveryWorkspace#resource_types}.</summary>
            [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ResourceTypes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.6.0/docs/resources/storage_discovery_workspace#tag_keys_only StorageDiscoveryWorkspace#tag_keys_only}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagKeysOnly", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TagKeysOnly
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.6.0/docs/resources/storage_discovery_workspace#tags StorageDiscoveryWorkspace#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
