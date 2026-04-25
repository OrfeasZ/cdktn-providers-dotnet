using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOrganization
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterContaining")]
    public class DataCloudflareOrganizationFilterContaining : cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterContaining
    {
        /// <summary>Filter the list of organizations to the ones that contain this particular account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/organization#account DataCloudflareOrganization#account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "account", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Account
        {
            get;
            set;
        }

        /// <summary>Filter the list of organizations to the ones that contain this particular organization.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/organization#organization DataCloudflareOrganization#organization}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "organization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Organization
        {
            get;
            set;
        }

        /// <summary>Filter the list of organizations to the ones that contain this particular user.</summary>
        /// <remarks>
        /// IMPORTANT: Just because an organization "contains" a user is not a
        /// representation of any authorization or privilege to manage any resources
        /// therein. An organization "containing" a user simply means the user is managed by
        /// that organization.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/organization#user DataCloudflareOrganization#user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? User
        {
            get;
            set;
        }
    }
}
