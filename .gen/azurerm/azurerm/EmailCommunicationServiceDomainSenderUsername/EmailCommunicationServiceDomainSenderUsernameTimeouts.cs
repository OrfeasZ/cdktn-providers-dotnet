using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EmailCommunicationServiceDomainSenderUsername
{
    [JsiiByValue(fqn: "azurerm.emailCommunicationServiceDomainSenderUsername.EmailCommunicationServiceDomainSenderUsernameTimeouts")]
    public class EmailCommunicationServiceDomainSenderUsernameTimeouts : azurerm.EmailCommunicationServiceDomainSenderUsername.IEmailCommunicationServiceDomainSenderUsernameTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/email_communication_service_domain_sender_username#create EmailCommunicationServiceDomainSenderUsername#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/email_communication_service_domain_sender_username#delete EmailCommunicationServiceDomainSenderUsername#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/email_communication_service_domain_sender_username#read EmailCommunicationServiceDomainSenderUsername#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/email_communication_service_domain_sender_username#update EmailCommunicationServiceDomainSenderUsername#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
