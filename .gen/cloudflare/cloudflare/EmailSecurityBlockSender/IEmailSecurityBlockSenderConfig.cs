using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.EmailSecurityBlockSender
{
    [JsiiInterface(nativeType: typeof(IEmailSecurityBlockSenderConfig), fullyQualifiedName: "cloudflare.emailSecurityBlockSender.EmailSecurityBlockSenderConfig")]
    public interface IEmailSecurityBlockSenderConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/email_security_block_sender#account_id EmailSecurityBlockSender#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/email_security_block_sender#is_regex EmailSecurityBlockSender#is_regex}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isRegex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsRegex
        {
            get;
        }

        /// <summary>The pattern value to match against.</summary>
        /// <remarks>
        /// Format depends on <c>pattern_type</c>:
        ///
        /// <list type="bullet">
        /// <description>EMAIL: a valid email address, e.g. <c>user@example.com</c></description>
        /// <description>DOMAIN: a valid domain name, e.g. <c>example.com</c></description>
        /// <description>IP: a plain IPv4 address (e.g. <c>1.2.3.4</c>) or an IPv4 CIDR block (e.g. <c>1.2.3.0/24</c>). Only globally reachable addresses are accepted; private, loopback, link-local, and unspecified addresses are rejected.</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/email_security_block_sender#pattern EmailSecurityBlockSender#pattern}
        /// </remarks>
        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
        string Pattern
        {
            get;
        }

        /// <summary>Type of pattern matching.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description>EMAIL: matches a full email address (e.g. <c>user@example.com</c>)</description>
        /// <description>DOMAIN: matches a domain name (e.g. <c>example.com</c>)</description>
        /// <description>IP: matches a plain IPv4 address (e.g. <c>1.2.3.4</c>) or an IPv4 CIDR block (e.g. <c>1.2.3.0/24</c>). Only globally reachable addresses are accepted.</description>
        /// <description>UNKNOWN: deprecated, cannot be used when creating or updating policies, but may be returned for existing entries.
        /// Available values: "EMAIL", "DOMAIN", "IP", "UNKNOWN".</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/email_security_block_sender#pattern_type EmailSecurityBlockSender#pattern_type}
        /// </remarks>
        [JsiiProperty(name: "patternType", typeJson: "{\"primitive\":\"string\"}")]
        string PatternType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/email_security_block_sender#comments EmailSecurityBlockSender#comments}.</summary>
        [JsiiProperty(name: "comments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Comments
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmailSecurityBlockSenderConfig), fullyQualifiedName: "cloudflare.emailSecurityBlockSender.EmailSecurityBlockSenderConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.EmailSecurityBlockSender.IEmailSecurityBlockSenderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/email_security_block_sender#account_id EmailSecurityBlockSender#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/email_security_block_sender#is_regex EmailSecurityBlockSender#is_regex}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "isRegex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsRegex
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The pattern value to match against.</summary>
            /// <remarks>
            /// Format depends on <c>pattern_type</c>:
            ///
            /// <list type="bullet">
            /// <description>EMAIL: a valid email address, e.g. <c>user@example.com</c></description>
            /// <description>DOMAIN: a valid domain name, e.g. <c>example.com</c></description>
            /// <description>IP: a plain IPv4 address (e.g. <c>1.2.3.4</c>) or an IPv4 CIDR block (e.g. <c>1.2.3.0/24</c>). Only globally reachable addresses are accepted; private, loopback, link-local, and unspecified addresses are rejected.</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/email_security_block_sender#pattern EmailSecurityBlockSender#pattern}
            /// </remarks>
            [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
            public string Pattern
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Type of pattern matching.</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description>EMAIL: matches a full email address (e.g. <c>user@example.com</c>)</description>
            /// <description>DOMAIN: matches a domain name (e.g. <c>example.com</c>)</description>
            /// <description>IP: matches a plain IPv4 address (e.g. <c>1.2.3.4</c>) or an IPv4 CIDR block (e.g. <c>1.2.3.0/24</c>). Only globally reachable addresses are accepted.</description>
            /// <description>UNKNOWN: deprecated, cannot be used when creating or updating policies, but may be returned for existing entries.
            /// Available values: "EMAIL", "DOMAIN", "IP", "UNKNOWN".</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/email_security_block_sender#pattern_type EmailSecurityBlockSender#pattern_type}
            /// </remarks>
            [JsiiProperty(name: "patternType", typeJson: "{\"primitive\":\"string\"}")]
            public string PatternType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/email_security_block_sender#comments EmailSecurityBlockSender#comments}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "comments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Comments
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
