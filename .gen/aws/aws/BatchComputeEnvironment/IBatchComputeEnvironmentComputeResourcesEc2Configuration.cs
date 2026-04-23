using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchComputeEnvironment
{
    [JsiiInterface(nativeType: typeof(IBatchComputeEnvironmentComputeResourcesEc2Configuration), fullyQualifiedName: "aws.batchComputeEnvironment.BatchComputeEnvironmentComputeResourcesEc2Configuration")]
    public interface IBatchComputeEnvironmentComputeResourcesEc2Configuration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/batch_compute_environment#image_id_override BatchComputeEnvironment#image_id_override}.</summary>
        [JsiiProperty(name: "imageIdOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageIdOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/batch_compute_environment#image_kubernetes_version BatchComputeEnvironment#image_kubernetes_version}.</summary>
        [JsiiProperty(name: "imageKubernetesVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageKubernetesVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/batch_compute_environment#image_type BatchComputeEnvironment#image_type}.</summary>
        [JsiiProperty(name: "imageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchComputeEnvironmentComputeResourcesEc2Configuration), fullyQualifiedName: "aws.batchComputeEnvironment.BatchComputeEnvironmentComputeResourcesEc2Configuration")]
        internal sealed class _Proxy : DeputyBase, aws.BatchComputeEnvironment.IBatchComputeEnvironmentComputeResourcesEc2Configuration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/batch_compute_environment#image_id_override BatchComputeEnvironment#image_id_override}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageIdOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageIdOverride
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/batch_compute_environment#image_kubernetes_version BatchComputeEnvironment#image_kubernetes_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageKubernetesVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageKubernetesVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/batch_compute_environment#image_type BatchComputeEnvironment#image_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
