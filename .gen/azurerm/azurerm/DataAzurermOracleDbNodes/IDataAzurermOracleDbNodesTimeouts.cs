using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleDbNodes
{
    [JsiiInterface(nativeType: typeof(IDataAzurermOracleDbNodesTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleDbNodes.DataAzurermOracleDbNodesTimeouts")]
    public interface IDataAzurermOracleDbNodesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/oracle_db_nodes#read DataAzurermOracleDbNodes#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermOracleDbNodesTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleDbNodes.DataAzurermOracleDbNodesTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermOracleDbNodes.IDataAzurermOracleDbNodesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/data-sources/oracle_db_nodes#read DataAzurermOracleDbNodes#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
