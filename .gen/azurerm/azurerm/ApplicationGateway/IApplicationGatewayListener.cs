using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    [JsiiInterface(nativeType: typeof(IApplicationGatewayListener), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayListener")]
    public interface IApplicationGatewayListener
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_gateway#frontend_ip_configuration_name ApplicationGateway#frontend_ip_configuration_name}.</summary>
        [JsiiProperty(name: "frontendIpConfigurationName", typeJson: "{\"primitive\":\"string\"}")]
        string FrontendIpConfigurationName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_gateway#frontend_port_name ApplicationGateway#frontend_port_name}.</summary>
        [JsiiProperty(name: "frontendPortName", typeJson: "{\"primitive\":\"string\"}")]
        string FrontendPortName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_gateway#protocol ApplicationGateway#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_gateway#host_names ApplicationGateway#host_names}.</summary>
        [JsiiProperty(name: "hostNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? HostNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_gateway#ssl_certificate_name ApplicationGateway#ssl_certificate_name}.</summary>
        [JsiiProperty(name: "sslCertificateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslCertificateName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_gateway#ssl_profile_name ApplicationGateway#ssl_profile_name}.</summary>
        [JsiiProperty(name: "sslProfileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslProfileName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationGatewayListener), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayListener")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApplicationGateway.IApplicationGatewayListener
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_gateway#frontend_ip_configuration_name ApplicationGateway#frontend_ip_configuration_name}.</summary>
            [JsiiProperty(name: "frontendIpConfigurationName", typeJson: "{\"primitive\":\"string\"}")]
            public string FrontendIpConfigurationName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_gateway#frontend_port_name ApplicationGateway#frontend_port_name}.</summary>
            [JsiiProperty(name: "frontendPortName", typeJson: "{\"primitive\":\"string\"}")]
            public string FrontendPortName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_gateway#protocol ApplicationGateway#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_gateway#host_names ApplicationGateway#host_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? HostNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_gateway#ssl_certificate_name ApplicationGateway#ssl_certificate_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslCertificateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslCertificateName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_gateway#ssl_profile_name ApplicationGateway#ssl_profile_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslProfileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslProfileName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
