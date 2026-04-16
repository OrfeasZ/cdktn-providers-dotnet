using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IotRoute
{
    [JsiiInterface(nativeType: typeof(IIotRouteS3), fullyQualifiedName: "scaleway.iotRoute.IotRouteS3")]
    public interface IIotRouteS3
    {
        /// <summary>The name of the S3 route's destination bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#bucket_name IotRoute#bucket_name}
        /// </remarks>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        string BucketName
        {
            get;
        }

        /// <summary>The region of the S3 route's destination bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#bucket_region IotRoute#bucket_region}
        /// </remarks>
        [JsiiProperty(name: "bucketRegion", typeJson: "{\"primitive\":\"string\"}")]
        string BucketRegion
        {
            get;
        }

        /// <summary>How the S3 route's objects will be created: one per topic or one per message.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#strategy IotRoute#strategy}
        /// </remarks>
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
        string Strategy
        {
            get;
        }

        /// <summary>The string to prefix object names with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#object_prefix IotRoute#object_prefix}
        /// </remarks>
        [JsiiProperty(name: "objectPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ObjectPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotRouteS3), fullyQualifiedName: "scaleway.iotRoute.IotRouteS3")]
        internal sealed class _Proxy : DeputyBase, scaleway.IotRoute.IIotRouteS3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the S3 route's destination bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#bucket_name IotRoute#bucket_name}
            /// </remarks>
            [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The region of the S3 route's destination bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#bucket_region IotRoute#bucket_region}
            /// </remarks>
            [JsiiProperty(name: "bucketRegion", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketRegion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>How the S3 route's objects will be created: one per topic or one per message.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#strategy IotRoute#strategy}
            /// </remarks>
            [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
            public string Strategy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The string to prefix object names with.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#object_prefix IotRoute#object_prefix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "objectPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ObjectPrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
