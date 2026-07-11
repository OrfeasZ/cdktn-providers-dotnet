using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleAdbsNationalCharacterSets
{
    [JsiiInterface(nativeType: typeof(IDataAzurermOracleAdbsNationalCharacterSetsTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleAdbsNationalCharacterSets.DataAzurermOracleAdbsNationalCharacterSetsTimeouts")]
    public interface IDataAzurermOracleAdbsNationalCharacterSetsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/oracle_adbs_national_character_sets#read DataAzurermOracleAdbsNationalCharacterSets#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermOracleAdbsNationalCharacterSetsTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleAdbsNationalCharacterSets.DataAzurermOracleAdbsNationalCharacterSetsTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermOracleAdbsNationalCharacterSets.IDataAzurermOracleAdbsNationalCharacterSetsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/oracle_adbs_national_character_sets#read DataAzurermOracleAdbsNationalCharacterSets#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
