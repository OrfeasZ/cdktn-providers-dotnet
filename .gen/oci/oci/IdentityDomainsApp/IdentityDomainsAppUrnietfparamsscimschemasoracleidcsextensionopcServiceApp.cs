using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiByValue(fqn: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp")]
    public class IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp : oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#service_instance_identifier IdentityDomainsApp#service_instance_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceInstanceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceInstanceIdentifier
        {
            get;
            set;
        }
    }
}
