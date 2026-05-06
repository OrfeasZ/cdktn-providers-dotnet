using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsKey
{
    [JsiiInterface(nativeType: typeof(IKmsKeyRestoreFromFile), fullyQualifiedName: "oci.kmsKey.KmsKeyRestoreFromFile")]
    public interface IKmsKeyRestoreFromFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#content_length KmsKey#content_length}.</summary>
        [JsiiProperty(name: "contentLength", typeJson: "{\"primitive\":\"string\"}")]
        string ContentLength
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#restore_key_from_file_details KmsKey#restore_key_from_file_details}.</summary>
        [JsiiProperty(name: "restoreKeyFromFileDetails", typeJson: "{\"primitive\":\"string\"}")]
        string RestoreKeyFromFileDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#content_md5 KmsKey#content_md5}.</summary>
        [JsiiProperty(name: "contentMd5", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentMd5
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKmsKeyRestoreFromFile), fullyQualifiedName: "oci.kmsKey.KmsKeyRestoreFromFile")]
        internal sealed class _Proxy : DeputyBase, oci.KmsKey.IKmsKeyRestoreFromFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#content_length KmsKey#content_length}.</summary>
            [JsiiProperty(name: "contentLength", typeJson: "{\"primitive\":\"string\"}")]
            public string ContentLength
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#restore_key_from_file_details KmsKey#restore_key_from_file_details}.</summary>
            [JsiiProperty(name: "restoreKeyFromFileDetails", typeJson: "{\"primitive\":\"string\"}")]
            public string RestoreKeyFromFileDetails
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#content_md5 KmsKey#content_md5}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contentMd5", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentMd5
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
