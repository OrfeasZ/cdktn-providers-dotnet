using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreaminfluxdbDbCluster
{
    [JsiiInterface(nativeType: typeof(ITimestreaminfluxdbDbClusterLogDeliveryConfigurationS3Configuration), fullyQualifiedName: "aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterLogDeliveryConfigurationS3Configuration")]
    public interface ITimestreaminfluxdbDbClusterLogDeliveryConfigurationS3Configuration
    {
        /// <summary>The name of the S3 bucket to deliver logs to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/timestreaminfluxdb_db_cluster#bucket_name TimestreaminfluxdbDbCluster#bucket_name}
        /// </remarks>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        string BucketName
        {
            get;
        }

        /// <summary>Indicates whether log delivery to the S3 bucket is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/timestreaminfluxdb_db_cluster#enabled TimestreaminfluxdbDbCluster#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITimestreaminfluxdbDbClusterLogDeliveryConfigurationS3Configuration), fullyQualifiedName: "aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterLogDeliveryConfigurationS3Configuration")]
        internal sealed class _Proxy : DeputyBase, aws.TimestreaminfluxdbDbCluster.ITimestreaminfluxdbDbClusterLogDeliveryConfigurationS3Configuration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the S3 bucket to deliver logs to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/timestreaminfluxdb_db_cluster#bucket_name TimestreaminfluxdbDbCluster#bucket_name}
            /// </remarks>
            [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Indicates whether log delivery to the S3 bucket is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/timestreaminfluxdb_db_cluster#enabled TimestreaminfluxdbDbCluster#enabled}
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
