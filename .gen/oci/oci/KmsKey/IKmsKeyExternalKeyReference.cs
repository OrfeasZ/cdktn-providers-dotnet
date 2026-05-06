using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsKey
{
    [JsiiInterface(nativeType: typeof(IKmsKeyExternalKeyReference), fullyQualifiedName: "oci.kmsKey.KmsKeyExternalKeyReference")]
    public interface IKmsKeyExternalKeyReference
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#external_key_id KmsKey#external_key_id}.</summary>
        [JsiiProperty(name: "externalKeyId", typeJson: "{\"primitive\":\"string\"}")]
        string ExternalKeyId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKmsKeyExternalKeyReference), fullyQualifiedName: "oci.kmsKey.KmsKeyExternalKeyReference")]
        internal sealed class _Proxy : DeputyBase, oci.KmsKey.IKmsKeyExternalKeyReference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#external_key_id KmsKey#external_key_id}.</summary>
            [JsiiProperty(name: "externalKeyId", typeJson: "{\"primitive\":\"string\"}")]
            public string ExternalKeyId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
