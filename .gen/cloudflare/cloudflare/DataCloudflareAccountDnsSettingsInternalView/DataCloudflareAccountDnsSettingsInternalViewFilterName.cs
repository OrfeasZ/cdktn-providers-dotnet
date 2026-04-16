using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccountDnsSettingsInternalView
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareAccountDnsSettingsInternalView.DataCloudflareAccountDnsSettingsInternalViewFilterName")]
    public class DataCloudflareAccountDnsSettingsInternalViewFilterName : cloudflare.DataCloudflareAccountDnsSettingsInternalView.IDataCloudflareAccountDnsSettingsInternalViewFilterName
    {
        /// <summary>Substring of the DNS view name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_view#contains DataCloudflareAccountDnsSettingsInternalView#contains}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Contains
        {
            get;
            set;
        }

        /// <summary>Suffix of the DNS view name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_view#endswith DataCloudflareAccountDnsSettingsInternalView#endswith}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endswith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Endswith
        {
            get;
            set;
        }

        /// <summary>Exact value of the DNS view name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_view#exact DataCloudflareAccountDnsSettingsInternalView#exact}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Exact
        {
            get;
            set;
        }

        /// <summary>Prefix of the DNS view name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/account_dns_settings_internal_view#startswith DataCloudflareAccountDnsSettingsInternalView#startswith}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startswith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Startswith
        {
            get;
            set;
        }
    }
}
