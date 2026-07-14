using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridPartnerConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.eventgridPartnerConfiguration.EventgridPartnerConfigurationPartnerAuthorization")]
    public class EventgridPartnerConfigurationPartnerAuthorization : azurerm.EventgridPartnerConfiguration.IEventgridPartnerConfigurationPartnerAuthorization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/eventgrid_partner_configuration#partner_name EventgridPartnerConfiguration#partner_name}.</summary>
        [JsiiProperty(name: "partnerName", typeJson: "{\"primitive\":\"string\"}")]
        public string PartnerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/eventgrid_partner_configuration#partner_registration_id EventgridPartnerConfiguration#partner_registration_id}.</summary>
        [JsiiProperty(name: "partnerRegistrationId", typeJson: "{\"primitive\":\"string\"}")]
        public string PartnerRegistrationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/eventgrid_partner_configuration#authorization_expiration_time_in_utc EventgridPartnerConfiguration#authorization_expiration_time_in_utc}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorizationExpirationTimeInUtc", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthorizationExpirationTimeInUtc
        {
            get;
            set;
        }
    }
}
