using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermEventgridPartnerRegistration
{
    [JsiiByValue(fqn: "azurerm.dataAzurermEventgridPartnerRegistration.DataAzurermEventgridPartnerRegistrationTimeouts")]
    public class DataAzurermEventgridPartnerRegistrationTimeouts : azurerm.DataAzurermEventgridPartnerRegistration.IDataAzurermEventgridPartnerRegistrationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/eventgrid_partner_registration#read DataAzurermEventgridPartnerRegistration#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
