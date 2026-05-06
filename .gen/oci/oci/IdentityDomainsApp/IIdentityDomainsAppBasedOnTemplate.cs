using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAppBasedOnTemplate), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppBasedOnTemplate")]
    public interface IIdentityDomainsAppBasedOnTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#value IdentityDomainsApp#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#well_known_id IdentityDomainsApp#well_known_id}.</summary>
        [JsiiProperty(name: "wellKnownId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WellKnownId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAppBasedOnTemplate), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppBasedOnTemplate")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsApp.IIdentityDomainsAppBasedOnTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#value IdentityDomainsApp#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#well_known_id IdentityDomainsApp#well_known_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "wellKnownId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WellKnownId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
