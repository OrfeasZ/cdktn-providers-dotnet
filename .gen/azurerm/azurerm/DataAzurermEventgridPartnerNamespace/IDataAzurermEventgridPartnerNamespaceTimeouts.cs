using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermEventgridPartnerNamespace
{
    [JsiiInterface(nativeType: typeof(IDataAzurermEventgridPartnerNamespaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermEventgridPartnerNamespace.DataAzurermEventgridPartnerNamespaceTimeouts")]
    public interface IDataAzurermEventgridPartnerNamespaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/eventgrid_partner_namespace#read DataAzurermEventgridPartnerNamespace#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermEventgridPartnerNamespaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermEventgridPartnerNamespace.DataAzurermEventgridPartnerNamespaceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermEventgridPartnerNamespace.IDataAzurermEventgridPartnerNamespaceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/data-sources/eventgrid_partner_namespace#read DataAzurermEventgridPartnerNamespace#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
