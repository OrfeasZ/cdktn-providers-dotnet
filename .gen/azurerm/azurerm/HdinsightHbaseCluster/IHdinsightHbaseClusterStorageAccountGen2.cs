using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHbaseCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightHbaseClusterStorageAccountGen2), fullyQualifiedName: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterStorageAccountGen2")]
    public interface IHdinsightHbaseClusterStorageAccountGen2
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/hdinsight_hbase_cluster#filesystem_id HdinsightHbaseCluster#filesystem_id}.</summary>
        [JsiiProperty(name: "filesystemId", typeJson: "{\"primitive\":\"string\"}")]
        string FilesystemId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/hdinsight_hbase_cluster#is_default HdinsightHbaseCluster#is_default}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isDefault", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsDefault
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/hdinsight_hbase_cluster#storage_account_id HdinsightHbaseCluster#storage_account_id}.</summary>
        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
        string StorageAccountId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/hdinsight_hbase_cluster#user_assigned_identity_id HdinsightHbaseCluster#user_assigned_identity_id}.</summary>
        [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
        string UserAssignedIdentityId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightHbaseClusterStorageAccountGen2), fullyQualifiedName: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterStorageAccountGen2")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterStorageAccountGen2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/hdinsight_hbase_cluster#filesystem_id HdinsightHbaseCluster#filesystem_id}.</summary>
            [JsiiProperty(name: "filesystemId", typeJson: "{\"primitive\":\"string\"}")]
            public string FilesystemId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/hdinsight_hbase_cluster#is_default HdinsightHbaseCluster#is_default}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "isDefault", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsDefault
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/hdinsight_hbase_cluster#storage_account_id HdinsightHbaseCluster#storage_account_id}.</summary>
            [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageAccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/hdinsight_hbase_cluster#user_assigned_identity_id HdinsightHbaseCluster#user_assigned_identity_id}.</summary>
            [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
            public string UserAssignedIdentityId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
