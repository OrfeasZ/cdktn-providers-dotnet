using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareUserGroup
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareUserGroup.DataCloudflareUserGroupFilter")]
    public class DataCloudflareUserGroupFilter : cloudflare.DataCloudflareUserGroup.IDataCloudflareUserGroupFilter
    {
        /// <summary>The sort order of returned user groups by name (ascending or descending). Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/user_group#direction DataCloudflareUserGroup#direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }

        /// <summary>A string used for searching for user groups containing that substring.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/user_group#fuzzy_name DataCloudflareUserGroup#fuzzy_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fuzzyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FuzzyName
        {
            get;
            set;
        }

        /// <summary>ID of the user group to be fetched.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/user_group#id DataCloudflareUserGroup#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Name of the user group to be fetched.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/user_group#name DataCloudflareUserGroup#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
