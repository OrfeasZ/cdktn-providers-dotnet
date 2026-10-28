using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerInferenceComponent
{
    [JsiiInterface(nativeType: typeof(ISagemakerInferenceComponentRuntimeConfig), fullyQualifiedName: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentRuntimeConfig")]
    public interface ISagemakerInferenceComponentRuntimeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#copy_count SagemakerInferenceComponent#copy_count}.</summary>
        [JsiiProperty(name: "copyCount", typeJson: "{\"primitive\":\"number\"}")]
        double CopyCount
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerInferenceComponentRuntimeConfig), fullyQualifiedName: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentRuntimeConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerInferenceComponent.ISagemakerInferenceComponentRuntimeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#copy_count SagemakerInferenceComponent#copy_count}.</summary>
            [JsiiProperty(name: "copyCount", typeJson: "{\"primitive\":\"number\"}")]
            public double CopyCount
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
