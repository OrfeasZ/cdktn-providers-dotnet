using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbSqlContainer
{
    [JsiiInterface(nativeType: typeof(ICosmosdbSqlContainerIndexingPolicyCompositeIndex), fullyQualifiedName: "azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyCompositeIndex")]
    public interface ICosmosdbSqlContainerIndexingPolicyCompositeIndex
    {
        /// <summary>index block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_sql_container#index CosmosdbSqlContainer#index}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyCompositeIndexIndex" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "index", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyCompositeIndexIndex\"},\"kind\":\"array\"}}]}}")]
        object Index
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbSqlContainerIndexingPolicyCompositeIndex), fullyQualifiedName: "azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyCompositeIndex")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyCompositeIndex
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>index block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_sql_container#index CosmosdbSqlContainer#index}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyCompositeIndexIndex" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "index", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyCompositeIndexIndex\"},\"kind\":\"array\"}}]}}")]
            public object Index
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
