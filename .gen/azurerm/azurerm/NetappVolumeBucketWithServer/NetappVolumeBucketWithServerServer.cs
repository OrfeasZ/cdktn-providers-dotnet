using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeBucketWithServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerServer")]
    public class NetappVolumeBucketWithServerServer : azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerServer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/netapp_volume_bucket_with_server#fqdn NetappVolumeBucketWithServer#fqdn}.</summary>
        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
        public string Fqdn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/netapp_volume_bucket_with_server#certificate_pem NetappVolumeBucketWithServer#certificate_pem}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificatePem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificatePem
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/netapp_volume_bucket_with_server#on_certificate_conflict_action NetappVolumeBucketWithServer#on_certificate_conflict_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onCertificateConflictAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OnCertificateConflictAction
        {
            get;
            set;
        }
    }
}
