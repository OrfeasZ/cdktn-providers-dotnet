using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StreamingStreamPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.streamingStreamPool.StreamingStreamPoolCustomEncryptionKey")]
    public class StreamingStreamPoolCustomEncryptionKey : oci.StreamingStreamPool.IStreamingStreamPoolCustomEncryptionKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#kms_key_id StreamingStreamPool#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KmsKeyId
        {
            get;
            set;
        }
    }
}
