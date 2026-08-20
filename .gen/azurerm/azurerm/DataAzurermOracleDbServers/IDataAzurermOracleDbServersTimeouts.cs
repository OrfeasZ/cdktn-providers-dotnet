using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleDbServers
{
    [JsiiInterface(nativeType: typeof(IDataAzurermOracleDbServersTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleDbServers.DataAzurermOracleDbServersTimeouts")]
    public interface IDataAzurermOracleDbServersTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/oracle_db_servers#read DataAzurermOracleDbServers#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermOracleDbServersTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleDbServers.DataAzurermOracleDbServersTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermOracleDbServers.IDataAzurermOracleDbServersTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/oracle_db_servers#read DataAzurermOracleDbServers#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
