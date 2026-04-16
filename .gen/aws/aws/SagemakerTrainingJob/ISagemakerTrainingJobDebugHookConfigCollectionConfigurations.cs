using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerTrainingJobDebugHookConfigCollectionConfigurations), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobDebugHookConfigCollectionConfigurations")]
    public interface ISagemakerTrainingJobDebugHookConfigCollectionConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#collection_name SagemakerTrainingJob#collection_name}.</summary>
        [JsiiProperty(name: "collectionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CollectionName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#collection_parameters SagemakerTrainingJob#collection_parameters}.</summary>
        [JsiiProperty(name: "collectionParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? CollectionParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerTrainingJobDebugHookConfigCollectionConfigurations), fullyQualifiedName: "aws.sagemakerTrainingJob.SagemakerTrainingJobDebugHookConfigCollectionConfigurations")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerTrainingJob.ISagemakerTrainingJobDebugHookConfigCollectionConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#collection_name SagemakerTrainingJob#collection_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "collectionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CollectionName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/sagemaker_training_job#collection_parameters SagemakerTrainingJob#collection_parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "collectionParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? CollectionParameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
