using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedRedis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managedRedis.ManagedRedisIdentity")]
    public class ManagedRedisIdentity : azurerm.ManagedRedis.IManagedRedisIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/managed_redis#type ManagedRedis#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/managed_redis#identity_ids ManagedRedis#identity_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IdentityIds
        {
            get;
            set;
        }
    }
}
