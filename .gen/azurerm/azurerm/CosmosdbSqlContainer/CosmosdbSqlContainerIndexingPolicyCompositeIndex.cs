using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbSqlContainer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyCompositeIndex")]
    public class CosmosdbSqlContainerIndexingPolicyCompositeIndex : azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyCompositeIndex
    {
        private object _index;

        /// <summary>index block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cosmosdb_sql_container#index CosmosdbSqlContainer#index}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyCompositeIndexIndex" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "index", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyCompositeIndexIndex\"},\"kind\":\"array\"}}]}}")]
        public object Index
        {
            get => _index;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyCompositeIndexIndex[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyCompositeIndexIndex).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyCompositeIndexIndex).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _index = value;
            }
        }
    }
}
