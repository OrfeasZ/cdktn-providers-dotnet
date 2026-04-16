using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesBackendStage
{
    [JsiiByValue(fqn: "scaleway.edgeServicesBackendStage.EdgeServicesBackendStageS3BackendConfig")]
    public class EdgeServicesBackendStageS3BackendConfig : scaleway.EdgeServicesBackendStage.IEdgeServicesBackendStageS3BackendConfig
    {
        /// <summary>The name of the Bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_backend_stage#bucket_name EdgeServicesBackendStage#bucket_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketName
        {
            get;
            set;
        }

        /// <summary>The region of the Bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_backend_stage#bucket_region EdgeServicesBackendStage#bucket_region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bucketRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketRegion
        {
            get;
            set;
        }

        private object? _isWebsite;

        /// <summary>Defines whether the bucket website feature is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/edge_services_backend_stage#is_website EdgeServicesBackendStage#is_website}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isWebsite", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsWebsite
        {
            get => _isWebsite;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isWebsite = value;
            }
        }
    }
}
