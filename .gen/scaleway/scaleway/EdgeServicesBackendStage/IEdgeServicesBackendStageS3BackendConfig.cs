using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesBackendStage
{
    [JsiiInterface(nativeType: typeof(IEdgeServicesBackendStageS3BackendConfig), fullyQualifiedName: "scaleway.edgeServicesBackendStage.EdgeServicesBackendStageS3BackendConfig")]
    public interface IEdgeServicesBackendStageS3BackendConfig
    {
        /// <summary>The name of the Bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_backend_stage#bucket_name EdgeServicesBackendStage#bucket_name}
        /// </remarks>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The region of the Bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_backend_stage#bucket_region EdgeServicesBackendStage#bucket_region}
        /// </remarks>
        [JsiiProperty(name: "bucketRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketRegion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines whether the bucket website feature is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_backend_stage#is_website EdgeServicesBackendStage#is_website}
        /// </remarks>
        [JsiiProperty(name: "isWebsite", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsWebsite
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEdgeServicesBackendStageS3BackendConfig), fullyQualifiedName: "scaleway.edgeServicesBackendStage.EdgeServicesBackendStageS3BackendConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.EdgeServicesBackendStage.IEdgeServicesBackendStageS3BackendConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the Bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_backend_stage#bucket_name EdgeServicesBackendStage#bucket_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The region of the Bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_backend_stage#bucket_region EdgeServicesBackendStage#bucket_region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bucketRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketRegion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines whether the bucket website feature is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/edge_services_backend_stage#is_website EdgeServicesBackendStage#is_website}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isWebsite", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsWebsite
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
