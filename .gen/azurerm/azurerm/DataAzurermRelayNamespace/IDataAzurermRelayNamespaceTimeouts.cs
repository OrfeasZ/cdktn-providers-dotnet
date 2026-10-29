using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermRelayNamespace
{
    [JsiiInterface(nativeType: typeof(IDataAzurermRelayNamespaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermRelayNamespace.DataAzurermRelayNamespaceTimeouts")]
    public interface IDataAzurermRelayNamespaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.12.0/docs/data-sources/relay_namespace#read DataAzurermRelayNamespace#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermRelayNamespaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermRelayNamespace.DataAzurermRelayNamespaceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermRelayNamespace.IDataAzurermRelayNamespaceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.12.0/docs/data-sources/relay_namespace#read DataAzurermRelayNamespace#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
