using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchComputeEnvironment
{
    [JsiiByValue(fqn: "aws.batchComputeEnvironment.BatchComputeEnvironmentComputeResourcesEc2Configuration")]
    public class BatchComputeEnvironmentComputeResourcesEc2Configuration : aws.BatchComputeEnvironment.IBatchComputeEnvironmentComputeResourcesEc2Configuration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/batch_compute_environment#image_id_override BatchComputeEnvironment#image_id_override}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageIdOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageIdOverride
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/batch_compute_environment#image_kubernetes_version BatchComputeEnvironment#image_kubernetes_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageKubernetesVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageKubernetesVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/batch_compute_environment#image_type BatchComputeEnvironment#image_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageType
        {
            get;
            set;
        }
    }
}
