using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsCloudGateMapping
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingCloudGate")]
    public class IdentityDomainsCloudGateMappingCloudGate : oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingCloudGate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#value IdentityDomainsCloudGateMapping#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
