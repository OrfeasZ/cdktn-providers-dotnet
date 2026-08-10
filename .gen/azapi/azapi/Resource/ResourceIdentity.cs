using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azapi.Resource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azapi.resource.ResourceIdentity")]
    public class ResourceIdentity : azapi.Resource.IResourceIdentity
    {
        /// <summary>The Type of Identity which should be used for this azure resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#type Resource#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>A list of User Managed Identity ID's which should be assigned to the azure resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/resources/resource#identity_ids Resource#identity_ids}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IdentityIds
        {
            get;
            set;
        }
    }
}
