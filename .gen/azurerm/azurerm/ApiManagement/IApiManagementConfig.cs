using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagement
{
    [JsiiInterface(nativeType: typeof(IApiManagementConfig), fullyQualifiedName: "azurerm.apiManagement.ApiManagementConfig")]
    public interface IApiManagementConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#location ApiManagement#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#name ApiManagement#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#publisher_email ApiManagement#publisher_email}.</summary>
        [JsiiProperty(name: "publisherEmail", typeJson: "{\"primitive\":\"string\"}")]
        string PublisherEmail
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#publisher_name ApiManagement#publisher_name}.</summary>
        [JsiiProperty(name: "publisherName", typeJson: "{\"primitive\":\"string\"}")]
        string PublisherName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#resource_group_name ApiManagement#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#sku_name ApiManagement#sku_name}.</summary>
        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        string SkuName
        {
            get;
        }

        /// <summary>additional_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#additional_location ApiManagement#additional_location}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagement.IApiManagementAdditionalLocation" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "additionalLocation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementAdditionalLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AdditionalLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#certificate ApiManagement#certificate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagement.IApiManagementCertificate" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "certificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Certificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#client_certificate_enabled ApiManagement#client_certificate_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "clientCertificateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ClientCertificateEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>delegation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#delegation ApiManagement#delegation}
        /// </remarks>
        [JsiiProperty(name: "delegation", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementDelegation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagement.IApiManagementDelegation? Delegation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#gateway_disabled ApiManagement#gateway_disabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "gatewayDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GatewayDisabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>hostname_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#hostname_configuration ApiManagement#hostname_configuration}
        /// </remarks>
        [JsiiProperty(name: "hostnameConfiguration", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagement.IApiManagementHostnameConfiguration? HostnameConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#id ApiManagement#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#identity ApiManagement#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagement.IApiManagementIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#min_api_version ApiManagement#min_api_version}.</summary>
        [JsiiProperty(name: "minApiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinApiVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#notification_sender_email ApiManagement#notification_sender_email}.</summary>
        [JsiiProperty(name: "notificationSenderEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotificationSenderEmail
        {
            get
            {
                return null;
            }
        }

        /// <summary>protocols block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#protocols ApiManagement#protocols}
        /// </remarks>
        [JsiiProperty(name: "protocols", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementProtocols\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagement.IApiManagementProtocols? Protocols
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#public_ip_address_id ApiManagement#public_ip_address_id}.</summary>
        [JsiiProperty(name: "publicIpAddressId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PublicIpAddressId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#public_network_access_enabled ApiManagement#public_network_access_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublicNetworkAccessEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>security block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#security ApiManagement#security}
        /// </remarks>
        [JsiiProperty(name: "security", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementSecurity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagement.IApiManagementSecurity? Security
        {
            get
            {
                return null;
            }
        }

        /// <summary>sign_in block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#sign_in ApiManagement#sign_in}
        /// </remarks>
        [JsiiProperty(name: "signIn", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementSignIn\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagement.IApiManagementSignIn? SignIn
        {
            get
            {
                return null;
            }
        }

        /// <summary>sign_up block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#sign_up ApiManagement#sign_up}
        /// </remarks>
        [JsiiProperty(name: "signUp", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementSignUp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagement.IApiManagementSignUp? SignUp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#tags ApiManagement#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>tenant_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#tenant_access ApiManagement#tenant_access}
        /// </remarks>
        [JsiiProperty(name: "tenantAccess", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementTenantAccess\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagement.IApiManagementTenantAccess? TenantAccess
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#timeouts ApiManagement#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagement.IApiManagementTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>virtual_network_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#virtual_network_configuration ApiManagement#virtual_network_configuration}
        /// </remarks>
        [JsiiProperty(name: "virtualNetworkConfiguration", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementVirtualNetworkConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagement.IApiManagementVirtualNetworkConfiguration? VirtualNetworkConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#virtual_network_type ApiManagement#virtual_network_type}.</summary>
        [JsiiProperty(name: "virtualNetworkType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VirtualNetworkType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#zones ApiManagement#zones}.</summary>
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Zones
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementConfig), fullyQualifiedName: "azurerm.apiManagement.ApiManagementConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagement.IApiManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#location ApiManagement#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#name ApiManagement#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#publisher_email ApiManagement#publisher_email}.</summary>
            [JsiiProperty(name: "publisherEmail", typeJson: "{\"primitive\":\"string\"}")]
            public string PublisherEmail
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#publisher_name ApiManagement#publisher_name}.</summary>
            [JsiiProperty(name: "publisherName", typeJson: "{\"primitive\":\"string\"}")]
            public string PublisherName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#resource_group_name ApiManagement#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#sku_name ApiManagement#sku_name}.</summary>
            [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
            public string SkuName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>additional_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#additional_location ApiManagement#additional_location}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagement.IApiManagementAdditionalLocation" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalLocation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementAdditionalLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AdditionalLocation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#certificate ApiManagement#certificate}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApiManagement.IApiManagementCertificate" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Certificate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#client_certificate_enabled ApiManagement#client_certificate_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ClientCertificateEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>delegation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#delegation ApiManagement#delegation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "delegation", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementDelegation\"}", isOptional: true)]
            public azurerm.ApiManagement.IApiManagementDelegation? Delegation
            {
                get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementDelegation?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#gateway_disabled ApiManagement#gateway_disabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gatewayDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? GatewayDisabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>hostname_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#hostname_configuration ApiManagement#hostname_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostnameConfiguration", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfiguration\"}", isOptional: true)]
            public azurerm.ApiManagement.IApiManagementHostnameConfiguration? HostnameConfiguration
            {
                get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementHostnameConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#id ApiManagement#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#identity ApiManagement#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementIdentity\"}", isOptional: true)]
            public azurerm.ApiManagement.IApiManagementIdentity? Identity
            {
                get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementIdentity?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#min_api_version ApiManagement#min_api_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minApiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinApiVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#notification_sender_email ApiManagement#notification_sender_email}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notificationSenderEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotificationSenderEmail
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>protocols block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#protocols ApiManagement#protocols}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protocols", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementProtocols\"}", isOptional: true)]
            public azurerm.ApiManagement.IApiManagementProtocols? Protocols
            {
                get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementProtocols?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#public_ip_address_id ApiManagement#public_ip_address_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publicIpAddressId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PublicIpAddressId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#public_network_access_enabled ApiManagement#public_network_access_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PublicNetworkAccessEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>security block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#security ApiManagement#security}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "security", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementSecurity\"}", isOptional: true)]
            public azurerm.ApiManagement.IApiManagementSecurity? Security
            {
                get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementSecurity?>();
            }

            /// <summary>sign_in block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#sign_in ApiManagement#sign_in}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "signIn", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementSignIn\"}", isOptional: true)]
            public azurerm.ApiManagement.IApiManagementSignIn? SignIn
            {
                get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementSignIn?>();
            }

            /// <summary>sign_up block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#sign_up ApiManagement#sign_up}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "signUp", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementSignUp\"}", isOptional: true)]
            public azurerm.ApiManagement.IApiManagementSignUp? SignUp
            {
                get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementSignUp?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#tags ApiManagement#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>tenant_access block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#tenant_access ApiManagement#tenant_access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tenantAccess", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementTenantAccess\"}", isOptional: true)]
            public azurerm.ApiManagement.IApiManagementTenantAccess? TenantAccess
            {
                get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementTenantAccess?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#timeouts ApiManagement#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementTimeouts\"}", isOptional: true)]
            public azurerm.ApiManagement.IApiManagementTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementTimeouts?>();
            }

            /// <summary>virtual_network_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#virtual_network_configuration ApiManagement#virtual_network_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualNetworkConfiguration", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementVirtualNetworkConfiguration\"}", isOptional: true)]
            public azurerm.ApiManagement.IApiManagementVirtualNetworkConfiguration? VirtualNetworkConfiguration
            {
                get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementVirtualNetworkConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#virtual_network_type ApiManagement#virtual_network_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "virtualNetworkType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VirtualNetworkType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/api_management#zones ApiManagement#zones}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Zones
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
