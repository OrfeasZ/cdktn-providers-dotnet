using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeBucketWithServer
{
    [JsiiInterface(nativeType: typeof(INetappVolumeBucketWithServerServer), fullyQualifiedName: "azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerServer")]
    public interface INetappVolumeBucketWithServerServer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/netapp_volume_bucket_with_server#fqdn NetappVolumeBucketWithServer#fqdn}.</summary>
        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
        string Fqdn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/netapp_volume_bucket_with_server#certificate_pem NetappVolumeBucketWithServer#certificate_pem}.</summary>
        [JsiiProperty(name: "certificatePem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificatePem
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/netapp_volume_bucket_with_server#on_certificate_conflict_action NetappVolumeBucketWithServer#on_certificate_conflict_action}.</summary>
        [JsiiProperty(name: "onCertificateConflictAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OnCertificateConflictAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetappVolumeBucketWithServerServer), fullyQualifiedName: "azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerServer")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerServer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/netapp_volume_bucket_with_server#fqdn NetappVolumeBucketWithServer#fqdn}.</summary>
            [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
            public string Fqdn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/netapp_volume_bucket_with_server#certificate_pem NetappVolumeBucketWithServer#certificate_pem}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificatePem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificatePem
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/netapp_volume_bucket_with_server#on_certificate_conflict_action NetappVolumeBucketWithServer#on_certificate_conflict_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onCertificateConflictAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnCertificateConflictAction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
