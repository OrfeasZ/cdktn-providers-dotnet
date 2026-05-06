using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAppCertificates), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppCertificates")]
    public interface IIdentityDomainsAppCertificates
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#cert_alias IdentityDomainsApp#cert_alias}.</summary>
        [JsiiProperty(name: "certAlias", typeJson: "{\"primitive\":\"string\"}")]
        string CertAlias
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAppCertificates), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppCertificates")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsApp.IIdentityDomainsAppCertificates
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#cert_alias IdentityDomainsApp#cert_alias}.</summary>
            [JsiiProperty(name: "certAlias", typeJson: "{\"primitive\":\"string\"}")]
            public string CertAlias
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
