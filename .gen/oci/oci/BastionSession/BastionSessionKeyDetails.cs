using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BastionSession
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.bastionSession.BastionSessionKeyDetails")]
    public class BastionSessionKeyDetails : oci.BastionSession.IBastionSessionKeyDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#public_key_content BastionSession#public_key_content}.</summary>
        [JsiiProperty(name: "publicKeyContent", typeJson: "{\"primitive\":\"string\"}")]
        public string PublicKeyContent
        {
            get;
            set;
        }
    }
}
