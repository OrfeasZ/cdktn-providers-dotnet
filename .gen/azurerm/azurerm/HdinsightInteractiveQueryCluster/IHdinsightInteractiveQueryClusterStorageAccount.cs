using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightInteractiveQueryCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightInteractiveQueryClusterStorageAccount), fullyQualifiedName: "azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterStorageAccount")]
    public interface IHdinsightInteractiveQueryClusterStorageAccount
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/hdinsight_interactive_query_cluster#is_default HdinsightInteractiveQueryCluster#is_default}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isDefault", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsDefault
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/hdinsight_interactive_query_cluster#storage_account_key HdinsightInteractiveQueryCluster#storage_account_key}.</summary>
        [JsiiProperty(name: "storageAccountKey", typeJson: "{\"primitive\":\"string\"}")]
        string StorageAccountKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/hdinsight_interactive_query_cluster#storage_container_url HdinsightInteractiveQueryCluster#storage_container_url}.</summary>
        [JsiiProperty(name: "storageContainerUrl", typeJson: "{\"primitive\":\"string\"}")]
        string StorageContainerUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/hdinsight_interactive_query_cluster#storage_account_id HdinsightInteractiveQueryCluster#storage_account_id}.</summary>
        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightInteractiveQueryClusterStorageAccount), fullyQualifiedName: "azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterStorageAccount")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterStorageAccount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/hdinsight_interactive_query_cluster#is_default HdinsightInteractiveQueryCluster#is_default}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "isDefault", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsDefault
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/hdinsight_interactive_query_cluster#storage_account_key HdinsightInteractiveQueryCluster#storage_account_key}.</summary>
            [JsiiProperty(name: "storageAccountKey", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageAccountKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/hdinsight_interactive_query_cluster#storage_container_url HdinsightInteractiveQueryCluster#storage_container_url}.</summary>
            [JsiiProperty(name: "storageContainerUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageContainerUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/hdinsight_interactive_query_cluster#storage_account_id HdinsightInteractiveQueryCluster#storage_account_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
