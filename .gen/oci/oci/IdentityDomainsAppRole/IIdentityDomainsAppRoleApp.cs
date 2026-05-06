using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsAppRole
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAppRoleApp), fullyQualifiedName: "oci.identityDomainsAppRole.IdentityDomainsAppRoleApp")]
    public interface IIdentityDomainsAppRoleApp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app_role#value IdentityDomainsAppRole#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAppRoleApp), fullyQualifiedName: "oci.identityDomainsAppRole.IdentityDomainsAppRoleApp")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsAppRole.IIdentityDomainsAppRoleApp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app_role#value IdentityDomainsAppRole#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
