using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermGraphServicesAccount
{
    [JsiiInterface(nativeType: typeof(IDataAzurermGraphServicesAccountTimeouts), fullyQualifiedName: "azurerm.dataAzurermGraphServicesAccount.DataAzurermGraphServicesAccountTimeouts")]
    public interface IDataAzurermGraphServicesAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/graph_services_account#read DataAzurermGraphServicesAccount#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermGraphServicesAccountTimeouts), fullyQualifiedName: "azurerm.dataAzurermGraphServicesAccount.DataAzurermGraphServicesAccountTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermGraphServicesAccount.IDataAzurermGraphServicesAccountTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/data-sources/graph_services_account#read DataAzurermGraphServicesAccount#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
