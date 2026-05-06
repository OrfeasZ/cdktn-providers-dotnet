using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsNetworkPerimeter
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsNetworkPerimeterTags), fullyQualifiedName: "oci.identityDomainsNetworkPerimeter.IdentityDomainsNetworkPerimeterTags")]
    public interface IIdentityDomainsNetworkPerimeterTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_network_perimeter#key IdentityDomainsNetworkPerimeter#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_network_perimeter#value IdentityDomainsNetworkPerimeter#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsNetworkPerimeterTags), fullyQualifiedName: "oci.identityDomainsNetworkPerimeter.IdentityDomainsNetworkPerimeterTags")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsNetworkPerimeter.IIdentityDomainsNetworkPerimeterTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_network_perimeter#key IdentityDomainsNetworkPerimeter#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_network_perimeter#value IdentityDomainsNetworkPerimeter#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
