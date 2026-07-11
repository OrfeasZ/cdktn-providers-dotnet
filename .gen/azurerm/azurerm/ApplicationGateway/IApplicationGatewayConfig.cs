using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    [JsiiInterface(nativeType: typeof(IApplicationGatewayConfig), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayConfig")]
    public interface IApplicationGatewayConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>backend_address_pool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#backend_address_pool ApplicationGateway#backend_address_pool}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayBackendAddressPool" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "backendAddressPool", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayBackendAddressPool\"},\"kind\":\"array\"}}]}}")]
        object BackendAddressPool
        {
            get;
        }

        /// <summary>frontend_ip_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#frontend_ip_configuration ApplicationGateway#frontend_ip_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayFrontendIpConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "frontendIpConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayFrontendIpConfiguration\"},\"kind\":\"array\"}}]}}")]
        object FrontendIpConfiguration
        {
            get;
        }

        /// <summary>frontend_port block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#frontend_port ApplicationGateway#frontend_port}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayFrontendPort" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "frontendPort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayFrontendPort\"},\"kind\":\"array\"}}]}}")]
        object FrontendPort
        {
            get;
        }

        /// <summary>gateway_ip_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#gateway_ip_configuration ApplicationGateway#gateway_ip_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayGatewayIpConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "gatewayIpConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayGatewayIpConfiguration\"},\"kind\":\"array\"}}]}}")]
        object GatewayIpConfiguration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#location ApplicationGateway#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#resource_group_name ApplicationGateway#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>sku block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#sku ApplicationGateway#sku}
        /// </remarks>
        [JsiiProperty(name: "sku", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewaySku\"}")]
        azurerm.ApplicationGateway.IApplicationGatewaySku Sku
        {
            get;
        }

        /// <summary>authentication_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#authentication_certificate ApplicationGateway#authentication_certificate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayAuthenticationCertificate" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "authenticationCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayAuthenticationCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AuthenticationCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>autoscale_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#autoscale_configuration ApplicationGateway#autoscale_configuration}
        /// </remarks>
        [JsiiProperty(name: "autoscaleConfiguration", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayAutoscaleConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApplicationGateway.IApplicationGatewayAutoscaleConfiguration? AutoscaleConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>backend block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#backend ApplicationGateway#backend}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayBackend" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "backend", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayBackend\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Backend
        {
            get
            {
                return null;
            }
        }

        /// <summary>backend_http_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#backend_http_settings ApplicationGateway#backend_http_settings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayBackendHttpSettings" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "backendHttpSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayBackendHttpSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BackendHttpSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_error_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#custom_error_configuration ApplicationGateway#custom_error_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayCustomErrorConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "customErrorConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayCustomErrorConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomErrorConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#enable_http2 ApplicationGateway#enable_http2}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enableHttp2", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableHttp2
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#fips_enabled ApplicationGateway#fips_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "fipsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FipsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#firewall_policy_id ApplicationGateway#firewall_policy_id}.</summary>
        [JsiiProperty(name: "firewallPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FirewallPolicyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#force_firewall_policy_association ApplicationGateway#force_firewall_policy_association}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "forceFirewallPolicyAssociation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ForceFirewallPolicyAssociation
        {
            get
            {
                return null;
            }
        }

        /// <summary>global block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#global ApplicationGateway#global}
        /// </remarks>
        [JsiiProperty(name: "global", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayGlobal\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApplicationGateway.IApplicationGatewayGlobal? Global
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#http2_enabled ApplicationGateway#http2_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "http2Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Http2Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_listener block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#http_listener ApplicationGateway#http_listener}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayHttpListener" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "httpListener", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayHttpListener\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpListener
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#id ApplicationGateway#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#identity ApplicationGateway#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApplicationGateway.IApplicationGatewayIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>listener block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#listener ApplicationGateway#listener}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayListener" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "listener", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayListener\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Listener
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_link_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#private_link_configuration ApplicationGateway#private_link_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayPrivateLinkConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "privateLinkConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayPrivateLinkConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrivateLinkConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>probe block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#probe ApplicationGateway#probe}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayProbe" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "probe", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayProbe\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Probe
        {
            get
            {
                return null;
            }
        }

        /// <summary>redirect_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#redirect_configuration ApplicationGateway#redirect_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayRedirectConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "redirectConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRedirectConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RedirectConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>request_routing_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#request_routing_rule ApplicationGateway#request_routing_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayRequestRoutingRule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestRoutingRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRequestRoutingRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestRoutingRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>rewrite_rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#rewrite_rule_set ApplicationGateway#rewrite_rule_set}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSet" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rewriteRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRewriteRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RewriteRuleSet
        {
            get
            {
                return null;
            }
        }

        /// <summary>routing_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#routing_rule ApplicationGateway#routing_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayRoutingRule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "routingRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRoutingRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RoutingRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssl_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#ssl_certificate ApplicationGateway#ssl_certificate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewaySslCertificate" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sslCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewaySslCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SslCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssl_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#ssl_policy ApplicationGateway#ssl_policy}
        /// </remarks>
        [JsiiProperty(name: "sslPolicy", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewaySslPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApplicationGateway.IApplicationGatewaySslPolicy? SslPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssl_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#ssl_profile ApplicationGateway#ssl_profile}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewaySslProfile" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sslProfile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewaySslProfile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SslProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#tags ApplicationGateway#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#timeouts ApplicationGateway#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApplicationGateway.IApplicationGatewayTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>trusted_client_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#trusted_client_certificate ApplicationGateway#trusted_client_certificate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayTrustedClientCertificate" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "trustedClientCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayTrustedClientCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TrustedClientCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>trusted_root_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#trusted_root_certificate ApplicationGateway#trusted_root_certificate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayTrustedRootCertificate" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "trustedRootCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayTrustedRootCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TrustedRootCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>url_path_map block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#url_path_map ApplicationGateway#url_path_map}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayUrlPathMap" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "urlPathMap", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayUrlPathMap\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UrlPathMap
        {
            get
            {
                return null;
            }
        }

        /// <summary>waf_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#waf_configuration ApplicationGateway#waf_configuration}
        /// </remarks>
        [JsiiProperty(name: "wafConfiguration", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayWafConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApplicationGateway.IApplicationGatewayWafConfiguration? WafConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#zones ApplicationGateway#zones}.</summary>
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Zones
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationGatewayConfig), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApplicationGateway.IApplicationGatewayConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>backend_address_pool block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#backend_address_pool ApplicationGateway#backend_address_pool}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayBackendAddressPool" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "backendAddressPool", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayBackendAddressPool\"},\"kind\":\"array\"}}]}}")]
            public object BackendAddressPool
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>frontend_ip_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#frontend_ip_configuration ApplicationGateway#frontend_ip_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayFrontendIpConfiguration" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "frontendIpConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayFrontendIpConfiguration\"},\"kind\":\"array\"}}]}}")]
            public object FrontendIpConfiguration
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>frontend_port block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#frontend_port ApplicationGateway#frontend_port}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayFrontendPort" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "frontendPort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayFrontendPort\"},\"kind\":\"array\"}}]}}")]
            public object FrontendPort
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>gateway_ip_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#gateway_ip_configuration ApplicationGateway#gateway_ip_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayGatewayIpConfiguration" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "gatewayIpConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayGatewayIpConfiguration\"},\"kind\":\"array\"}}]}}")]
            public object GatewayIpConfiguration
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#location ApplicationGateway#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#resource_group_name ApplicationGateway#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>sku block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#sku ApplicationGateway#sku}
            /// </remarks>
            [JsiiProperty(name: "sku", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewaySku\"}")]
            public azurerm.ApplicationGateway.IApplicationGatewaySku Sku
            {
                get => GetInstanceProperty<azurerm.ApplicationGateway.IApplicationGatewaySku>()!;
            }

            /// <summary>authentication_certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#authentication_certificate ApplicationGateway#authentication_certificate}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayAuthenticationCertificate" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayAuthenticationCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AuthenticationCertificate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>autoscale_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#autoscale_configuration ApplicationGateway#autoscale_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoscaleConfiguration", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayAutoscaleConfiguration\"}", isOptional: true)]
            public azurerm.ApplicationGateway.IApplicationGatewayAutoscaleConfiguration? AutoscaleConfiguration
            {
                get => GetInstanceProperty<azurerm.ApplicationGateway.IApplicationGatewayAutoscaleConfiguration?>();
            }

            /// <summary>backend block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#backend ApplicationGateway#backend}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayBackend" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backend", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayBackend\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Backend
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>backend_http_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#backend_http_settings ApplicationGateway#backend_http_settings}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayBackendHttpSettings" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backendHttpSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayBackendHttpSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BackendHttpSettings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>custom_error_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#custom_error_configuration ApplicationGateway#custom_error_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayCustomErrorConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customErrorConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayCustomErrorConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomErrorConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#enable_http2 ApplicationGateway#enable_http2}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enableHttp2", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableHttp2
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#fips_enabled ApplicationGateway#fips_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fipsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FipsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#firewall_policy_id ApplicationGateway#firewall_policy_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firewallPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FirewallPolicyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#force_firewall_policy_association ApplicationGateway#force_firewall_policy_association}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forceFirewallPolicyAssociation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ForceFirewallPolicyAssociation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>global block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#global ApplicationGateway#global}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "global", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayGlobal\"}", isOptional: true)]
            public azurerm.ApplicationGateway.IApplicationGatewayGlobal? Global
            {
                get => GetInstanceProperty<azurerm.ApplicationGateway.IApplicationGatewayGlobal?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#http2_enabled ApplicationGateway#http2_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http2Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Http2Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>http_listener block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#http_listener ApplicationGateway#http_listener}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayHttpListener" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpListener", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayHttpListener\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HttpListener
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#id ApplicationGateway#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#identity ApplicationGateway#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayIdentity\"}", isOptional: true)]
            public azurerm.ApplicationGateway.IApplicationGatewayIdentity? Identity
            {
                get => GetInstanceProperty<azurerm.ApplicationGateway.IApplicationGatewayIdentity?>();
            }

            /// <summary>listener block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#listener ApplicationGateway#listener}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayListener" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "listener", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayListener\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Listener
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>private_link_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#private_link_configuration ApplicationGateway#private_link_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayPrivateLinkConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateLinkConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayPrivateLinkConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PrivateLinkConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>probe block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#probe ApplicationGateway#probe}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayProbe" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "probe", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayProbe\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Probe
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>redirect_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#redirect_configuration ApplicationGateway#redirect_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayRedirectConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirectConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRedirectConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RedirectConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_routing_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#request_routing_rule ApplicationGateway#request_routing_rule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayRequestRoutingRule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestRoutingRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRequestRoutingRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestRoutingRule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>rewrite_rule_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#rewrite_rule_set ApplicationGateway#rewrite_rule_set}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSet" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rewriteRuleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRewriteRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RewriteRuleSet
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>routing_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#routing_rule ApplicationGateway#routing_rule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayRoutingRule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routingRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRoutingRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RoutingRule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ssl_certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#ssl_certificate ApplicationGateway#ssl_certificate}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewaySslCertificate" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewaySslCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SslCertificate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ssl_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#ssl_policy ApplicationGateway#ssl_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslPolicy", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewaySslPolicy\"}", isOptional: true)]
            public azurerm.ApplicationGateway.IApplicationGatewaySslPolicy? SslPolicy
            {
                get => GetInstanceProperty<azurerm.ApplicationGateway.IApplicationGatewaySslPolicy?>();
            }

            /// <summary>ssl_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#ssl_profile ApplicationGateway#ssl_profile}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewaySslProfile" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslProfile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewaySslProfile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SslProfile
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#tags ApplicationGateway#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#timeouts ApplicationGateway#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayTimeouts\"}", isOptional: true)]
            public azurerm.ApplicationGateway.IApplicationGatewayTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ApplicationGateway.IApplicationGatewayTimeouts?>();
            }

            /// <summary>trusted_client_certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#trusted_client_certificate ApplicationGateway#trusted_client_certificate}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayTrustedClientCertificate" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trustedClientCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayTrustedClientCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TrustedClientCertificate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>trusted_root_certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#trusted_root_certificate ApplicationGateway#trusted_root_certificate}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayTrustedRootCertificate" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trustedRootCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayTrustedRootCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TrustedRootCertificate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>url_path_map block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#url_path_map ApplicationGateway#url_path_map}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayUrlPathMap" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "urlPathMap", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayUrlPathMap\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UrlPathMap
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>waf_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#waf_configuration ApplicationGateway#waf_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wafConfiguration", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayWafConfiguration\"}", isOptional: true)]
            public azurerm.ApplicationGateway.IApplicationGatewayWafConfiguration? WafConfiguration
            {
                get => GetInstanceProperty<azurerm.ApplicationGateway.IApplicationGatewayWafConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/application_gateway#zones ApplicationGateway#zones}.</summary>
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
