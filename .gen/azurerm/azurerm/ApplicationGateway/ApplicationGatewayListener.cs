using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.applicationGateway.ApplicationGatewayListener")]
    public class ApplicationGatewayListener : azurerm.ApplicationGateway.IApplicationGatewayListener
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#frontend_ip_configuration_name ApplicationGateway#frontend_ip_configuration_name}.</summary>
        [JsiiProperty(name: "frontendIpConfigurationName", typeJson: "{\"primitive\":\"string\"}")]
        public string FrontendIpConfigurationName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#frontend_port_name ApplicationGateway#frontend_port_name}.</summary>
        [JsiiProperty(name: "frontendPortName", typeJson: "{\"primitive\":\"string\"}")]
        public string FrontendPortName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#protocol ApplicationGateway#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#host_names ApplicationGateway#host_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? HostNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#ssl_certificate_name ApplicationGateway#ssl_certificate_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslCertificateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslCertificateName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#ssl_profile_name ApplicationGateway#ssl_profile_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslProfileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslProfileName
        {
            get;
            set;
        }
    }
}
