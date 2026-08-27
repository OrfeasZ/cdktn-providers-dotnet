using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleResourceAnchor
{
    [JsiiInterface(nativeType: typeof(IDataAzurermOracleResourceAnchorTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleResourceAnchor.DataAzurermOracleResourceAnchorTimeouts")]
    public interface IDataAzurermOracleResourceAnchorTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/oracle_resource_anchor#read DataAzurermOracleResourceAnchor#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermOracleResourceAnchorTimeouts), fullyQualifiedName: "azurerm.dataAzurermOracleResourceAnchor.DataAzurermOracleResourceAnchorTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermOracleResourceAnchor.IDataAzurermOracleResourceAnchorTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/oracle_resource_anchor#read DataAzurermOracleResourceAnchor#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
