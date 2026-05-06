using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsEkmsPrivateEndpoint
{
    [JsiiByValue(fqn: "oci.kmsEkmsPrivateEndpoint.KmsEkmsPrivateEndpointTimeouts")]
    public class KmsEkmsPrivateEndpointTimeouts : oci.KmsEkmsPrivateEndpoint.IKmsEkmsPrivateEndpointTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_ekms_private_endpoint#create KmsEkmsPrivateEndpoint#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_ekms_private_endpoint#delete KmsEkmsPrivateEndpoint#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_ekms_private_endpoint#update KmsEkmsPrivateEndpoint#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
