using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ApiToken
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.apiToken.ApiTokenPoliciesPermissionGroups")]
    public class ApiTokenPoliciesPermissionGroups : cloudflare.ApiToken.IApiTokenPoliciesPermissionGroups
    {
        /// <summary>Identifier of the permission group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/api_token#id ApiToken#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }
    }
}
