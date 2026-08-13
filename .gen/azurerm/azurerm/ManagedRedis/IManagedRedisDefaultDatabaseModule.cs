using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedRedis
{
    [JsiiInterface(nativeType: typeof(IManagedRedisDefaultDatabaseModule), fullyQualifiedName: "azurerm.managedRedis.ManagedRedisDefaultDatabaseModule")]
    public interface IManagedRedisDefaultDatabaseModule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_redis#name ManagedRedis#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_redis#args ManagedRedis#args}.</summary>
        [JsiiProperty(name: "args", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Args
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedRedisDefaultDatabaseModule), fullyQualifiedName: "azurerm.managedRedis.ManagedRedisDefaultDatabaseModule")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedRedis.IManagedRedisDefaultDatabaseModule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_redis#name ManagedRedis#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_redis#args ManagedRedis#args}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "args", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Args
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
