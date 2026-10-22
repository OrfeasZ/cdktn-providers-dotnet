using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerInferenceComponent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationsComputeResourceRequirements")]
    public class SagemakerInferenceComponentSpecificationsComputeResourceRequirements : aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationsComputeResourceRequirements
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/sagemaker_inference_component#min_memory_required_in_mb SagemakerInferenceComponent#min_memory_required_in_mb}.</summary>
        [JsiiProperty(name: "minMemoryRequiredInMb", typeJson: "{\"primitive\":\"number\"}")]
        public double MinMemoryRequiredInMb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/sagemaker_inference_component#max_memory_required_in_mb SagemakerInferenceComponent#max_memory_required_in_mb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxMemoryRequiredInMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxMemoryRequiredInMb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/sagemaker_inference_component#number_of_accelerator_devices_required SagemakerInferenceComponent#number_of_accelerator_devices_required}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numberOfAcceleratorDevicesRequired", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumberOfAcceleratorDevicesRequired
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/sagemaker_inference_component#number_of_cpu_cores_required SagemakerInferenceComponent#number_of_cpu_cores_required}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numberOfCpuCoresRequired", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumberOfCpuCoresRequired
        {
            get;
            set;
        }
    }
}
