using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountDnsSettings
{
    [JsiiInterface(nativeType: typeof(IAccountDnsSettingsZoneDefaults), fullyQualifiedName: "cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaults")]
    public interface IAccountDnsSettingsZoneDefaults
    {
        /// <summary>Whether to flatten all CNAME records in the zone.</summary>
        /// <remarks>
        /// Note that, due to DNS limitations, a CNAME record at the zone apex will always be flattened.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#flatten_all_cnames AccountDnsSettings#flatten_all_cnames}
        /// </remarks>
        [JsiiProperty(name: "flattenAllCnames", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FlattenAllCnames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to enable Foundation DNS Advanced Nameservers on the zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#foundation_dns AccountDnsSettings#foundation_dns}
        /// </remarks>
        [JsiiProperty(name: "foundationDns", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FoundationDns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Settings for this internal zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#internal_dns AccountDnsSettings#internal_dns}
        /// </remarks>
        [JsiiProperty(name: "internalDns", typeJson: "{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsInternalDns\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsInternalDns? InternalDns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to enable multi-provider DNS, which causes Cloudflare to activate the zone even when non-Cloudflare NS records exist, and to respect NS records at the zone apex during outbound zone transfers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#multi_provider AccountDnsSettings#multi_provider}
        /// </remarks>
        [JsiiProperty(name: "multiProvider", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MultiProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>Settings determining the nameservers through which the zone should be available.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#nameservers AccountDnsSettings#nameservers}
        /// </remarks>
        [JsiiProperty(name: "nameservers", typeJson: "{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsNameservers\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsNameservers? Nameservers
        {
            get
            {
                return null;
            }
        }

        /// <summary>The time to live (TTL) of the zone's nameserver (NS) records.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#ns_ttl AccountDnsSettings#ns_ttl}
        /// </remarks>
        [JsiiProperty(name: "nsTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NsTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allows a Secondary DNS zone to use (proxied) override records and CNAME flattening at the zone apex.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#secondary_overrides AccountDnsSettings#secondary_overrides}
        /// </remarks>
        [JsiiProperty(name: "secondaryOverrides", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecondaryOverrides
        {
            get
            {
                return null;
            }
        }

        /// <summary>Components of the zone's SOA record.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#soa AccountDnsSettings#soa}
        /// </remarks>
        [JsiiProperty(name: "soa", typeJson: "{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsSoa\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsSoa? Soa
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the zone mode is a regular or CDN/DNS only zone. Available values: "standard", "cdn_only", "dns_only".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#zone_mode AccountDnsSettings#zone_mode}
        /// </remarks>
        [JsiiProperty(name: "zoneMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZoneMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccountDnsSettingsZoneDefaults), fullyQualifiedName: "cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaults")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaults
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether to flatten all CNAME records in the zone.</summary>
            /// <remarks>
            /// Note that, due to DNS limitations, a CNAME record at the zone apex will always be flattened.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#flatten_all_cnames AccountDnsSettings#flatten_all_cnames}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flattenAllCnames", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FlattenAllCnames
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to enable Foundation DNS Advanced Nameservers on the zone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#foundation_dns AccountDnsSettings#foundation_dns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "foundationDns", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FoundationDns
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Settings for this internal zone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#internal_dns AccountDnsSettings#internal_dns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "internalDns", typeJson: "{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsInternalDns\"}", isOptional: true)]
            public cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsInternalDns? InternalDns
            {
                get => GetInstanceProperty<cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsInternalDns?>();
            }

            /// <summary>Whether to enable multi-provider DNS, which causes Cloudflare to activate the zone even when non-Cloudflare NS records exist, and to respect NS records at the zone apex during outbound zone transfers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#multi_provider AccountDnsSettings#multi_provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "multiProvider", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MultiProvider
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Settings determining the nameservers through which the zone should be available.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#nameservers AccountDnsSettings#nameservers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nameservers", typeJson: "{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsNameservers\"}", isOptional: true)]
            public cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsNameservers? Nameservers
            {
                get => GetInstanceProperty<cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsNameservers?>();
            }

            /// <summary>The time to live (TTL) of the zone's nameserver (NS) records.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#ns_ttl AccountDnsSettings#ns_ttl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nsTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NsTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Allows a Secondary DNS zone to use (proxied) override records and CNAME flattening at the zone apex.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#secondary_overrides AccountDnsSettings#secondary_overrides}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secondaryOverrides", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SecondaryOverrides
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Components of the zone's SOA record.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#soa AccountDnsSettings#soa}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "soa", typeJson: "{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsSoa\"}", isOptional: true)]
            public cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsSoa? Soa
            {
                get => GetInstanceProperty<cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsSoa?>();
            }

            /// <summary>Whether the zone mode is a regular or CDN/DNS only zone. Available values: "standard", "cdn_only", "dns_only".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#zone_mode AccountDnsSettings#zone_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zoneMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZoneMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
