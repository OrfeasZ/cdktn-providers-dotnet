using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IotRoute
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.iotRoute.IotRouteS3")]
    public class IotRouteS3 : scaleway.IotRoute.IIotRouteS3
    {
        /// <summary>The name of the S3 route's destination bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#bucket_name IotRoute#bucket_name}
        /// </remarks>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketName
        {
            get;
            set;
        }

        /// <summary>The region of the S3 route's destination bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#bucket_region IotRoute#bucket_region}
        /// </remarks>
        [JsiiProperty(name: "bucketRegion", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketRegion
        {
            get;
            set;
        }

        /// <summary>How the S3 route's objects will be created: one per topic or one per message.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#strategy IotRoute#strategy}
        /// </remarks>
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
        public string Strategy
        {
            get;
            set;
        }

        /// <summary>The string to prefix object names with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#object_prefix IotRoute#object_prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "objectPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObjectPrefix
        {
            get;
            set;
        }
    }
}
