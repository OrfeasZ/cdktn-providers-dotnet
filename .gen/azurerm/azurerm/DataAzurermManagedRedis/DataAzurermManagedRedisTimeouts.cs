using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermManagedRedis
{
    [JsiiByValue(fqn: "azurerm.dataAzurermManagedRedis.DataAzurermManagedRedisTimeouts")]
    public class DataAzurermManagedRedisTimeouts : azurerm.DataAzurermManagedRedis.IDataAzurermManagedRedisTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/data-sources/managed_redis#read DataAzurermManagedRedis#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
