using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOrganization
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilter")]
    public class DataCloudflareOrganizationFilter : cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/organization#containing DataCloudflareOrganization#containing}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containing", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterContaining\"}", isOptional: true)]
        public cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterContaining? Containing
        {
            get;
            set;
        }

        /// <summary>Only return organizations with the specified IDs (ex. id=foo&amp;id=bar). Send multiple elements by repeating the query value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/organization#id DataCloudflareOrganization#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/organization#name DataCloudflareOrganization#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterName\"}", isOptional: true)]
        public cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterName? Name
        {
            get;
            set;
        }

        /// <summary>The amount of items to return. Defaults to 10.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/organization#page_size DataCloudflareOrganization#page_size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pageSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PageSize
        {
            get;
            set;
        }

        /// <summary>An opaque token returned from the last list response that when provided will retrieve the next page.</summary>
        /// <remarks>
        /// Parameters used to filter the retrieved list must remain in subsequent
        /// requests with a page token.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/organization#page_token DataCloudflareOrganization#page_token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pageToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PageToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/organization#parent DataCloudflareOrganization#parent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parent", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganization.DataCloudflareOrganizationFilterParent\"}", isOptional: true)]
        public cloudflare.DataCloudflareOrganization.IDataCloudflareOrganizationFilterParent? Parent
        {
            get;
            set;
        }
    }
}
