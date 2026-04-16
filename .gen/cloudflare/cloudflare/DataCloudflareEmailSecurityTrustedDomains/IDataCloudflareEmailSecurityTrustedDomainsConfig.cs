using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareEmailSecurityTrustedDomains
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareEmailSecurityTrustedDomainsConfig), fullyQualifiedName: "cloudflare.dataCloudflareEmailSecurityTrustedDomains.DataCloudflareEmailSecurityTrustedDomainsConfig")]
    public interface IDataCloudflareEmailSecurityTrustedDomainsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Account Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_trusted_domains#account_id DataCloudflareEmailSecurityTrustedDomains#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_trusted_domains#filter DataCloudflareEmailSecurityTrustedDomains#filter}.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareEmailSecurityTrustedDomains.DataCloudflareEmailSecurityTrustedDomainsFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DataCloudflareEmailSecurityTrustedDomains.IDataCloudflareEmailSecurityTrustedDomainsFilter? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>The unique identifier for the trusted domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_trusted_domains#trusted_domain_id DataCloudflareEmailSecurityTrustedDomains#trusted_domain_id}
        /// </remarks>
        [JsiiProperty(name: "trustedDomainId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TrustedDomainId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareEmailSecurityTrustedDomainsConfig), fullyQualifiedName: "cloudflare.dataCloudflareEmailSecurityTrustedDomains.DataCloudflareEmailSecurityTrustedDomainsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareEmailSecurityTrustedDomains.IDataCloudflareEmailSecurityTrustedDomainsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Account Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_trusted_domains#account_id DataCloudflareEmailSecurityTrustedDomains#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_trusted_domains#filter DataCloudflareEmailSecurityTrustedDomains#filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareEmailSecurityTrustedDomains.DataCloudflareEmailSecurityTrustedDomainsFilter\"}", isOptional: true)]
            public cloudflare.DataCloudflareEmailSecurityTrustedDomains.IDataCloudflareEmailSecurityTrustedDomainsFilter? Filter
            {
                get => GetInstanceProperty<cloudflare.DataCloudflareEmailSecurityTrustedDomains.IDataCloudflareEmailSecurityTrustedDomainsFilter?>();
            }

            /// <summary>The unique identifier for the trusted domain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_trusted_domains#trusted_domain_id DataCloudflareEmailSecurityTrustedDomains#trusted_domain_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trustedDomainId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TrustedDomainId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
