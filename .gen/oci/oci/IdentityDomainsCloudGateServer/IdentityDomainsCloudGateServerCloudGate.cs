using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsCloudGateServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsCloudGateServer.IdentityDomainsCloudGateServerCloudGate")]
    public class IdentityDomainsCloudGateServerCloudGate : oci.IdentityDomainsCloudGateServer.IIdentityDomainsCloudGateServerCloudGate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_server#value IdentityDomainsCloudGateServer#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
