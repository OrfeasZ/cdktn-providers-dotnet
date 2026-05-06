using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityAuthenticationPolicy
{
    [JsiiInterface(nativeType: typeof(IIdentityAuthenticationPolicyNetworkPolicy), fullyQualifiedName: "oci.identityAuthenticationPolicy.IdentityAuthenticationPolicyNetworkPolicy")]
    public interface IIdentityAuthenticationPolicyNetworkPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_authentication_policy#network_source_ids IdentityAuthenticationPolicy#network_source_ids}.</summary>
        [JsiiProperty(name: "networkSourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NetworkSourceIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityAuthenticationPolicyNetworkPolicy), fullyQualifiedName: "oci.identityAuthenticationPolicy.IdentityAuthenticationPolicyNetworkPolicy")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityAuthenticationPolicy.IIdentityAuthenticationPolicyNetworkPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_authentication_policy#network_source_ids IdentityAuthenticationPolicy#network_source_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkSourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NetworkSourceIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
