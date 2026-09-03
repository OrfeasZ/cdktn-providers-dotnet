using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApiConnection
{
    [JsiiInterface(nativeType: typeof(IDataAzurermApiConnectionTimeouts), fullyQualifiedName: "azurerm.dataAzurermApiConnection.DataAzurermApiConnectionTimeouts")]
    public interface IDataAzurermApiConnectionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/api_connection#read DataAzurermApiConnection#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermApiConnectionTimeouts), fullyQualifiedName: "azurerm.dataAzurermApiConnection.DataAzurermApiConnectionTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermApiConnection.IDataAzurermApiConnectionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/api_connection#read DataAzurermApiConnection#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
