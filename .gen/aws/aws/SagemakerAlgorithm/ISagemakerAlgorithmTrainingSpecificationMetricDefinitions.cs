using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiInterface(nativeType: typeof(ISagemakerAlgorithmTrainingSpecificationMetricDefinitions), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationMetricDefinitions")]
    public interface ISagemakerAlgorithmTrainingSpecificationMetricDefinitions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#name SagemakerAlgorithm#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#regex SagemakerAlgorithm#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}")]
        string Regex
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAlgorithmTrainingSpecificationMetricDefinitions), fullyQualifiedName: "aws.sagemakerAlgorithm.SagemakerAlgorithmTrainingSpecificationMetricDefinitions")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerAlgorithm.ISagemakerAlgorithmTrainingSpecificationMetricDefinitions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#name SagemakerAlgorithm#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_algorithm#regex SagemakerAlgorithm#regex}.</summary>
            [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}")]
            public string Regex
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
