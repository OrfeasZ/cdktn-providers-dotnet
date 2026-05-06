using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityAuthenticationPolicy
{
    [JsiiByValue(fqn: "oci.identityAuthenticationPolicy.IdentityAuthenticationPolicyNetworkPolicy")]
    public class IdentityAuthenticationPolicyNetworkPolicy : oci.IdentityAuthenticationPolicy.IIdentityAuthenticationPolicyNetworkPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_authentication_policy#network_source_ids IdentityAuthenticationPolicy#network_source_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkSourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NetworkSourceIds
        {
            get;
            set;
        }
    }
}
