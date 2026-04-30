using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiByValue(fqn: "aws.sagemakerTrainingJob.SagemakerTrainingJobDebugHookConfigCollectionConfigurations")]
    public class SagemakerTrainingJobDebugHookConfigCollectionConfigurations : aws.SagemakerTrainingJob.ISagemakerTrainingJobDebugHookConfigCollectionConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#collection_name SagemakerTrainingJob#collection_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "collectionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CollectionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/sagemaker_training_job#collection_parameters SagemakerTrainingJob#collection_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "collectionParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? CollectionParameters
        {
            get;
            set;
        }
    }
}
