using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOrganization
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterName")]
    public class DataCloudflareOrganizationFilterName : cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterName
    {
        /// <summary>(case-insensitive) Filter the list of organizations to where the name contains a particular string.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/organization#contains DataCloudflareOrganization#contains}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Contains
        {
            get;
            set;
        }

        /// <summary>(case-insensitive) Filter the list of organizations to where the name ends with a particular string.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/organization#ends_with DataCloudflareOrganization#ends_with}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endsWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndsWith
        {
            get;
            set;
        }

        /// <summary>(case-insensitive) Filter the list of organizations to where the name starts with a particular string.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/organization#starts_with DataCloudflareOrganization#starts_with}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startsWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartsWith
        {
            get;
            set;
        }
    }
}
