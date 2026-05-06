using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StreamingStreamPool
{
    [JsiiInterface(nativeType: typeof(IStreamingStreamPoolCustomEncryptionKey), fullyQualifiedName: "oci.streamingStreamPool.StreamingStreamPoolCustomEncryptionKey")]
    public interface IStreamingStreamPoolCustomEncryptionKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#kms_key_id StreamingStreamPool#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        string KmsKeyId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStreamingStreamPoolCustomEncryptionKey), fullyQualifiedName: "oci.streamingStreamPool.StreamingStreamPoolCustomEncryptionKey")]
        internal sealed class _Proxy : DeputyBase, oci.StreamingStreamPool.IStreamingStreamPoolCustomEncryptionKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#kms_key_id StreamingStreamPool#kms_key_id}.</summary>
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KmsKeyId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
