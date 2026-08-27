using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedRedis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managedRedis.ManagedRedisDefaultDatabaseModule")]
    public class ManagedRedisDefaultDatabaseModule : azurerm.ManagedRedis.IManagedRedisDefaultDatabaseModule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_redis#name ManagedRedis#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_redis#args ManagedRedis#args}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "args", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Args
        {
            get;
            set;
        }
    }
}
