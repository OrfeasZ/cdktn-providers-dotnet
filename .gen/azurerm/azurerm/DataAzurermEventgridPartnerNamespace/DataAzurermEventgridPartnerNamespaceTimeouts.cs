using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermEventgridPartnerNamespace
{
    [JsiiByValue(fqn: "azurerm.dataAzurermEventgridPartnerNamespace.DataAzurermEventgridPartnerNamespaceTimeouts")]
    public class DataAzurermEventgridPartnerNamespaceTimeouts : azurerm.DataAzurermEventgridPartnerNamespace.IDataAzurermEventgridPartnerNamespaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/eventgrid_partner_namespace#read DataAzurermEventgridPartnerNamespace#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
