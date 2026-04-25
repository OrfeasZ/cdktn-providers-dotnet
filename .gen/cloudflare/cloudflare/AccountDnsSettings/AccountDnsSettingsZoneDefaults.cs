using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountDnsSettings
{
    [JsiiByValue(fqn: "cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaults")]
    public class AccountDnsSettingsZoneDefaults : cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaults
    {
        private object? _flattenAllCnames;

        /// <summary>Whether to flatten all CNAME records in the zone.</summary>
        /// <remarks>
        /// Note that, due to DNS limitations, a CNAME record at the zone apex will always be flattened.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_dns_settings#flatten_all_cnames AccountDnsSettings#flatten_all_cnames}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flattenAllCnames", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? FlattenAllCnames
        {
            get => _flattenAllCnames;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _flattenAllCnames = value;
            }
        }

        private object? _foundationDns;

        /// <summary>Whether to enable Foundation DNS Advanced Nameservers on the zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_dns_settings#foundation_dns AccountDnsSettings#foundation_dns}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "foundationDns", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? FoundationDns
        {
            get => _foundationDns;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _foundationDns = value;
            }
        }

        /// <summary>Settings for this internal zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_dns_settings#internal_dns AccountDnsSettings#internal_dns}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalDns", typeJson: "{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsInternalDns\"}", isOptional: true)]
        public cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsInternalDns? InternalDns
        {
            get;
            set;
        }

        private object? _multiProvider;

        /// <summary>Whether to enable multi-provider DNS, which causes Cloudflare to activate the zone even when non-Cloudflare NS records exist, and to respect NS records at the zone apex during outbound zone transfers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_dns_settings#multi_provider AccountDnsSettings#multi_provider}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "multiProvider", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? MultiProvider
        {
            get => _multiProvider;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _multiProvider = value;
            }
        }

        /// <summary>Settings determining the nameservers through which the zone should be available.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_dns_settings#nameservers AccountDnsSettings#nameservers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nameservers", typeJson: "{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsNameservers\"}", isOptional: true)]
        public cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsNameservers? Nameservers
        {
            get;
            set;
        }

        /// <summary>The time to live (TTL) of the zone's nameserver (NS) records.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_dns_settings#ns_ttl AccountDnsSettings#ns_ttl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nsTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NsTtl
        {
            get;
            set;
        }

        private object? _secondaryOverrides;

        /// <summary>Allows a Secondary DNS zone to use (proxied) override records and CNAME flattening at the zone apex.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_dns_settings#secondary_overrides AccountDnsSettings#secondary_overrides}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryOverrides", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SecondaryOverrides
        {
            get => _secondaryOverrides;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secondaryOverrides = value;
            }
        }

        /// <summary>Components of the zone's SOA record.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_dns_settings#soa AccountDnsSettings#soa}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "soa", typeJson: "{\"fqn\":\"cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsSoa\"}", isOptional: true)]
        public cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsSoa? Soa
        {
            get;
            set;
        }

        /// <summary>Whether the zone mode is a regular or CDN/DNS only zone. Available values: "standard", "cdn_only", "dns_only".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_dns_settings#zone_mode AccountDnsSettings#zone_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zoneMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ZoneMode
        {
            get;
            set;
        }
    }
}
