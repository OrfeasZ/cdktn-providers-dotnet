using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.EmailSecurityDomain
{
    [JsiiInterface(nativeType: typeof(IEmailSecurityDomainConfig), fullyQualifiedName: "cloudflare.emailSecurityDomain.EmailSecurityDomainConfig")]
    public interface IEmailSecurityDomainConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#account_id EmailSecurityDomain#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Delivery modes to onboard the domain through.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#allowed_delivery_modes EmailSecurityDomain#allowed_delivery_modes}
        /// </remarks>
        [JsiiProperty(name: "allowedDeliveryModes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AllowedDeliveryModes
        {
            get;
        }

        /// <summary>The email domain to protect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#domain EmailSecurityDomain#domain}
        /// </remarks>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        string Domain
        {
            get;
        }

        /// <summary>Dispositions to drop instead of delivering, e.g. `["MALICIOUS", "SPAM"]`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#drop_dispositions EmailSecurityDomain#drop_dispositions}
        /// </remarks>
        [JsiiProperty(name: "dropDispositions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DropDispositions
        {
            get;
        }

        /// <summary>Source IP ranges mail is accepted from. Any other source is rejected.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#ip_restrictions EmailSecurityDomain#ip_restrictions}
        /// </remarks>
        [JsiiProperty(name: "ipRestrictions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] IpRestrictions
        {
            get;
        }

        /// <summary>Regions that process messages for this domain, e.g. `["GLOBAL"]` or `["US"]`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#regions EmailSecurityDomain#regions}
        /// </remarks>
        [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Regions
        {
            get;
        }

        /// <summary>The mailbox folder to scan, for API-scanning domains. Available values: "AllItems", "Inbox".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#folder EmailSecurityDomain#folder}
        /// </remarks>
        [JsiiProperty(name: "folder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Folder
        {
            get
            {
                return null;
            }
        }

        /// <summary>Identifier of the CASB integration that authorizes this domain.</summary>
        /// <remarks>
        /// The integration also enables API scanning, post-delivery actions, and directory sync.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#integration_id EmailSecurityDomain#integration_id}
        /// </remarks>
        [JsiiProperty(name: "integrationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IntegrationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of hops to trace back through received headers when reconstructing the original message (1-20).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#lookback_hops EmailSecurityDomain#lookback_hops}
        /// </remarks>
        [JsiiProperty(name: "lookbackHops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LookbackHops
        {
            get
            {
                return null;
            }
        }

        /// <summary>Require TLS on inbound connections.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#require_tls_inbound EmailSecurityDomain#require_tls_inbound}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "requireTlsInbound", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireTlsInbound
        {
            get
            {
                return null;
            }
        }

        /// <summary>Require TLS on outbound connections.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#require_tls_outbound EmailSecurityDomain#require_tls_outbound}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "requireTlsOutbound", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireTlsOutbound
        {
            get
            {
                return null;
            }
        }

        /// <summary>The mail transport hostname for MX/Inline delivery — the MX record Cloudflare delivers email to (e.g. `mx.example.com`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#transport EmailSecurityDomain#transport}
        /// </remarks>
        [JsiiProperty(name: "transport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Transport
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmailSecurityDomainConfig), fullyQualifiedName: "cloudflare.emailSecurityDomain.EmailSecurityDomainConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.EmailSecurityDomain.IEmailSecurityDomainConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#account_id EmailSecurityDomain#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Delivery modes to onboard the domain through.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#allowed_delivery_modes EmailSecurityDomain#allowed_delivery_modes}
            /// </remarks>
            [JsiiProperty(name: "allowedDeliveryModes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AllowedDeliveryModes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>The email domain to protect.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#domain EmailSecurityDomain#domain}
            /// </remarks>
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
            public string Domain
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Dispositions to drop instead of delivering, e.g. `["MALICIOUS", "SPAM"]`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#drop_dispositions EmailSecurityDomain#drop_dispositions}
            /// </remarks>
            [JsiiProperty(name: "dropDispositions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DropDispositions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Source IP ranges mail is accepted from. Any other source is rejected.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#ip_restrictions EmailSecurityDomain#ip_restrictions}
            /// </remarks>
            [JsiiProperty(name: "ipRestrictions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] IpRestrictions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Regions that process messages for this domain, e.g. `["GLOBAL"]` or `["US"]`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#regions EmailSecurityDomain#regions}
            /// </remarks>
            [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Regions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>The mailbox folder to scan, for API-scanning domains. Available values: "AllItems", "Inbox".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#folder EmailSecurityDomain#folder}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "folder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Folder
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Identifier of the CASB integration that authorizes this domain.</summary>
            /// <remarks>
            /// The integration also enables API scanning, post-delivery actions, and directory sync.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#integration_id EmailSecurityDomain#integration_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "integrationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IntegrationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Number of hops to trace back through received headers when reconstructing the original message (1-20).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#lookback_hops EmailSecurityDomain#lookback_hops}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lookbackHops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LookbackHops
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Require TLS on inbound connections.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#require_tls_inbound EmailSecurityDomain#require_tls_inbound}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireTlsInbound", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequireTlsInbound
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Require TLS on outbound connections.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#require_tls_outbound EmailSecurityDomain#require_tls_outbound}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireTlsOutbound", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequireTlsOutbound
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The mail transport hostname for MX/Inline delivery — the MX record Cloudflare delivers email to (e.g. `mx.example.com`).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/email_security_domain#transport EmailSecurityDomain#transport}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Transport
            {
                get => GetInstanceProperty<string?>();
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
