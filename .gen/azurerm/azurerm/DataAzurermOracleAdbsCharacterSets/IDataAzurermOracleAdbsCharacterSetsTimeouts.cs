using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleAdbsCharacterSets
{
    [JsiiInterface(nativeType: typeof(IDataAzurermOracleAdbsCharacterSetsTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleAdbsCharacterSets.DataAzurermOracleAdbsCharacterSetsTimeouts")]
    public interface IDataAzurermOracleAdbsCharacterSetsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/oracle_adbs_character_sets#read DataAzurermOracleAdbsCharacterSets#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermOracleAdbsCharacterSetsTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleAdbsCharacterSets.DataAzurermOracleAdbsCharacterSetsTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermOracleAdbsCharacterSets.IDataAzurermOracleAdbsCharacterSetsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/oracle_adbs_character_sets#read DataAzurermOracleAdbsCharacterSets#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
