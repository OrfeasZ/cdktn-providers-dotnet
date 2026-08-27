using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappVolumeGroupOracle
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNetappVolumeGroupOracleTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappVolumeGroupOracle.DataAzurermNetappVolumeGroupOracleTimeouts")]
    public interface IDataAzurermNetappVolumeGroupOracleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/netapp_volume_group_oracle#read DataAzurermNetappVolumeGroupOracle#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNetappVolumeGroupOracleTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappVolumeGroupOracle.DataAzurermNetappVolumeGroupOracleTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNetappVolumeGroupOracle.IDataAzurermNetappVolumeGroupOracleTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/netapp_volume_group_oracle#read DataAzurermNetappVolumeGroupOracle#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
