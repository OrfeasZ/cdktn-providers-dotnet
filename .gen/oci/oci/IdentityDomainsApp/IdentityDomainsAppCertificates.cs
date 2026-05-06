using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsApp.IdentityDomainsAppCertificates")]
    public class IdentityDomainsAppCertificates : oci.IdentityDomainsApp.IIdentityDomainsAppCertificates
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#cert_alias IdentityDomainsApp#cert_alias}.</summary>
        [JsiiProperty(name: "certAlias", typeJson: "{\"primitive\":\"string\"}")]
        public string CertAlias
        {
            get;
            set;
        }
    }
}
