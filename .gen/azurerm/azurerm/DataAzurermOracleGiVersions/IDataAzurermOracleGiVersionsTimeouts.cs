using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleGiVersions
{
    [JsiiInterface(nativeType: typeof(IDataAzurermOracleGiVersionsTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleGiVersions.DataAzurermOracleGiVersionsTimeouts")]
    public interface IDataAzurermOracleGiVersionsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/oracle_gi_versions#read DataAzurermOracleGiVersions#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermOracleGiVersionsTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleGiVersions.DataAzurermOracleGiVersionsTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermOracleGiVersions.IDataAzurermOracleGiVersionsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/oracle_gi_versions#read DataAzurermOracleGiVersions#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
