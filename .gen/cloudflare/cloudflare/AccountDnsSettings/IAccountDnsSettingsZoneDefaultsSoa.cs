using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountDnsSettings
{
    [JsiiInterface(nativeType: typeof(IAccountDnsSettingsZoneDefaultsSoa), fullyQualifiedName: "cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsSoa")]
    public interface IAccountDnsSettingsZoneDefaultsSoa
    {
        /// <summary>Time in seconds of being unable to query the primary server after which secondary servers should stop serving the zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_dns_settings#expire AccountDnsSettings#expire}
        /// </remarks>
        [JsiiProperty(name: "expire", typeJson: "{\"primitive\":\"number\"}")]
        double Expire
        {
            get;
        }

        /// <summary>The time to live (TTL) for negative caching of records within the zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_dns_settings#min_ttl AccountDnsSettings#min_ttl}
        /// </remarks>
        [JsiiProperty(name: "minTtl", typeJson: "{\"primitive\":\"number\"}")]
        double MinTtl
        {
            get;
        }

        /// <summary>The primary nameserver, which may be used for outbound zone transfers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_dns_settings#mname AccountDnsSettings#mname}
        /// </remarks>
        [JsiiProperty(name: "mname", typeJson: "{\"primitive\":\"string\"}")]
        string Mname
        {
            get;
        }

        /// <summary>Time in seconds after which secondary servers should re-check the SOA record to see if the zone has been updated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_dns_settings#refresh AccountDnsSettings#refresh}
        /// </remarks>
        [JsiiProperty(name: "refresh", typeJson: "{\"primitive\":\"number\"}")]
        double Refresh
        {
            get;
        }

        /// <summary>Time in seconds after which secondary servers should retry queries after the primary server was unresponsive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_dns_settings#retry AccountDnsSettings#retry}
        /// </remarks>
        [JsiiProperty(name: "retry", typeJson: "{\"primitive\":\"number\"}")]
        double Retry
        {
            get;
        }

        /// <summary>The email address of the zone administrator, with the first label representing the local part of the email address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_dns_settings#rname AccountDnsSettings#rname}
        /// </remarks>
        [JsiiProperty(name: "rname", typeJson: "{\"primitive\":\"string\"}")]
        string Rname
        {
            get;
        }

        /// <summary>The time to live (TTL) of the SOA record itself.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_dns_settings#ttl AccountDnsSettings#ttl}
        /// </remarks>
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        double Ttl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAccountDnsSettingsZoneDefaultsSoa), fullyQualifiedName: "cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsSoa")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsSoa
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Time in seconds of being unable to query the primary server after which secondary servers should stop serving the zone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_dns_settings#expire AccountDnsSettings#expire}
            /// </remarks>
            [JsiiProperty(name: "expire", typeJson: "{\"primitive\":\"number\"}")]
            public double Expire
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The time to live (TTL) for negative caching of records within the zone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_dns_settings#min_ttl AccountDnsSettings#min_ttl}
            /// </remarks>
            [JsiiProperty(name: "minTtl", typeJson: "{\"primitive\":\"number\"}")]
            public double MinTtl
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The primary nameserver, which may be used for outbound zone transfers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_dns_settings#mname AccountDnsSettings#mname}
            /// </remarks>
            [JsiiProperty(name: "mname", typeJson: "{\"primitive\":\"string\"}")]
            public string Mname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Time in seconds after which secondary servers should re-check the SOA record to see if the zone has been updated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_dns_settings#refresh AccountDnsSettings#refresh}
            /// </remarks>
            [JsiiProperty(name: "refresh", typeJson: "{\"primitive\":\"number\"}")]
            public double Refresh
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Time in seconds after which secondary servers should retry queries after the primary server was unresponsive.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_dns_settings#retry AccountDnsSettings#retry}
            /// </remarks>
            [JsiiProperty(name: "retry", typeJson: "{\"primitive\":\"number\"}")]
            public double Retry
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The email address of the zone administrator, with the first label representing the local part of the email address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_dns_settings#rname AccountDnsSettings#rname}
            /// </remarks>
            [JsiiProperty(name: "rname", typeJson: "{\"primitive\":\"string\"}")]
            public string Rname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The time to live (TTL) of the SOA record itself.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_dns_settings#ttl AccountDnsSettings#ttl}
            /// </remarks>
            [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
            public double Ttl
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
