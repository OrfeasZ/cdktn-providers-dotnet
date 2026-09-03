using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbAccount
{
    [JsiiInterface(nativeType: typeof(ICosmosdbAccountGeoLocation), fullyQualifiedName: "azurerm.cosmosdbAccount.CosmosdbAccountGeoLocation")]
    public interface ICosmosdbAccountGeoLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_account#failover_priority CosmosdbAccount#failover_priority}.</summary>
        [JsiiProperty(name: "failoverPriority", typeJson: "{\"primitive\":\"number\"}")]
        double FailoverPriority
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_account#location CosmosdbAccount#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_account#zone_redundant CosmosdbAccount#zone_redundant}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "zoneRedundant", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ZoneRedundant
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbAccountGeoLocation), fullyQualifiedName: "azurerm.cosmosdbAccount.CosmosdbAccountGeoLocation")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbAccount.ICosmosdbAccountGeoLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_account#failover_priority CosmosdbAccount#failover_priority}.</summary>
            [JsiiProperty(name: "failoverPriority", typeJson: "{\"primitive\":\"number\"}")]
            public double FailoverPriority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_account#location CosmosdbAccount#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cosmosdb_account#zone_redundant CosmosdbAccount#zone_redundant}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zoneRedundant", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ZoneRedundant
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
