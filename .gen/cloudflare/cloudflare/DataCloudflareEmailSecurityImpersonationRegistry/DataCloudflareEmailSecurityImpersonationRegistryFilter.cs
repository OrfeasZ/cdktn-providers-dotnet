using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareEmailSecurityImpersonationRegistry
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareEmailSecurityImpersonationRegistry.DataCloudflareEmailSecurityImpersonationRegistryFilter")]
    public class DataCloudflareEmailSecurityImpersonationRegistryFilter : cloudflare.DataCloudflareEmailSecurityImpersonationRegistry.IDataCloudflareEmailSecurityImpersonationRegistryFilter
    {
        /// <summary>The sorting direction. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_impersonation_registry#direction DataCloudflareEmailSecurityImpersonationRegistry#direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }

        /// <summary>The field to sort by. Available values: "name", "email", "created_at".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_impersonation_registry#order DataCloudflareEmailSecurityImpersonationRegistry#order}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Order
        {
            get;
            set;
        }

        /// <summary>Available values: "A1S_INTERNAL", "SNOOPY-CASB_OFFICE_365", "SNOOPY-OFFICE_365", "SNOOPY-GOOGLE_DIRECTORY".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_impersonation_registry#provenance DataCloudflareEmailSecurityImpersonationRegistry#provenance}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provenance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Provenance
        {
            get;
            set;
        }

        /// <summary>Allows searching in multiple properties of a record simultaneously.</summary>
        /// <remarks>
        /// This parameter is intended for human users, not automation. Its exact
        /// behavior is intentionally left unspecified and is subject to change
        /// in the future.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/email_security_impersonation_registry#search DataCloudflareEmailSecurityImpersonationRegistry#search}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "search", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Search
        {
            get;
            set;
        }
    }
}
