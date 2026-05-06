using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZoneDnsSettings
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zoneDnsSettings.ZoneDnsSettingsSoa")]
    public class ZoneDnsSettingsSoa : cloudflare.ZoneDnsSettings.IZoneDnsSettingsSoa
    {
        /// <summary>Time in seconds of being unable to query the primary server after which secondary servers should stop serving the zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zone_dns_settings#expire ZoneDnsSettings#expire}
        /// </remarks>
        [JsiiProperty(name: "expire", typeJson: "{\"primitive\":\"number\"}")]
        public double Expire
        {
            get;
            set;
        }

        /// <summary>The time to live (TTL) for negative caching of records within the zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zone_dns_settings#min_ttl ZoneDnsSettings#min_ttl}
        /// </remarks>
        [JsiiProperty(name: "minTtl", typeJson: "{\"primitive\":\"number\"}")]
        public double MinTtl
        {
            get;
            set;
        }

        /// <summary>The primary nameserver, which may be used for outbound zone transfers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zone_dns_settings#mname ZoneDnsSettings#mname}
        /// </remarks>
        [JsiiProperty(name: "mname", typeJson: "{\"primitive\":\"string\"}")]
        public string Mname
        {
            get;
            set;
        }

        /// <summary>Time in seconds after which secondary servers should re-check the SOA record to see if the zone has been updated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zone_dns_settings#refresh ZoneDnsSettings#refresh}
        /// </remarks>
        [JsiiProperty(name: "refresh", typeJson: "{\"primitive\":\"number\"}")]
        public double Refresh
        {
            get;
            set;
        }

        /// <summary>Time in seconds after which secondary servers should retry queries after the primary server was unresponsive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zone_dns_settings#retry ZoneDnsSettings#retry}
        /// </remarks>
        [JsiiProperty(name: "retry", typeJson: "{\"primitive\":\"number\"}")]
        public double Retry
        {
            get;
            set;
        }

        /// <summary>The email address of the zone administrator, with the first label representing the local part of the email address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zone_dns_settings#rname ZoneDnsSettings#rname}
        /// </remarks>
        [JsiiProperty(name: "rname", typeJson: "{\"primitive\":\"string\"}")]
        public string Rname
        {
            get;
            set;
        }

        /// <summary>The time to live (TTL) of the SOA record itself.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zone_dns_settings#ttl ZoneDnsSettings#ttl}
        /// </remarks>
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        public double Ttl
        {
            get;
            set;
        }
    }
}
