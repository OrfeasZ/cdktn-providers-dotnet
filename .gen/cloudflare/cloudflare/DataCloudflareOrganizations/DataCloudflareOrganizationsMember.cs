using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOrganizations
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareOrganizations.DataCloudflareOrganizationsMember")]
    public class DataCloudflareOrganizationsMember : cloudflare.DataCloudflareOrganizations.IDataCloudflareOrganizationsMember
    {
        /// <summary>Filter organizations to those where the given user, by email, is an active member of that exact organization.</summary>
        /// <remarks>
        /// This does not include hierarchy-derived access.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/data-sources/organizations#email DataCloudflareOrganizations#email}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Email
        {
            get;
            set;
        }
    }
}
