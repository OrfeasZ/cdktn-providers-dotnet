using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridPartnerConfiguration
{
    [JsiiInterface(nativeType: typeof(IEventgridPartnerConfigurationPartnerAuthorization), fullyQualifiedName: "azurerm.eventgridPartnerConfiguration.EventgridPartnerConfigurationPartnerAuthorization")]
    public interface IEventgridPartnerConfigurationPartnerAuthorization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/eventgrid_partner_configuration#partner_name EventgridPartnerConfiguration#partner_name}.</summary>
        [JsiiProperty(name: "partnerName", typeJson: "{\"primitive\":\"string\"}")]
        string PartnerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/eventgrid_partner_configuration#partner_registration_id EventgridPartnerConfiguration#partner_registration_id}.</summary>
        [JsiiProperty(name: "partnerRegistrationId", typeJson: "{\"primitive\":\"string\"}")]
        string PartnerRegistrationId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/eventgrid_partner_configuration#authorization_expiration_time_in_utc EventgridPartnerConfiguration#authorization_expiration_time_in_utc}.</summary>
        [JsiiProperty(name: "authorizationExpirationTimeInUtc", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthorizationExpirationTimeInUtc
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEventgridPartnerConfigurationPartnerAuthorization), fullyQualifiedName: "azurerm.eventgridPartnerConfiguration.EventgridPartnerConfigurationPartnerAuthorization")]
        internal sealed class _Proxy : DeputyBase, azurerm.EventgridPartnerConfiguration.IEventgridPartnerConfigurationPartnerAuthorization
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/eventgrid_partner_configuration#partner_name EventgridPartnerConfiguration#partner_name}.</summary>
            [JsiiProperty(name: "partnerName", typeJson: "{\"primitive\":\"string\"}")]
            public string PartnerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/eventgrid_partner_configuration#partner_registration_id EventgridPartnerConfiguration#partner_registration_id}.</summary>
            [JsiiProperty(name: "partnerRegistrationId", typeJson: "{\"primitive\":\"string\"}")]
            public string PartnerRegistrationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/eventgrid_partner_configuration#authorization_expiration_time_in_utc EventgridPartnerConfiguration#authorization_expiration_time_in_utc}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorizationExpirationTimeInUtc", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthorizationExpirationTimeInUtc
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
