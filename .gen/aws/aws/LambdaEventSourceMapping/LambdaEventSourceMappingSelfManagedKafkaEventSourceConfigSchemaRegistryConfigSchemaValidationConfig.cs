using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    [JsiiByValue(fqn: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingSelfManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig")]
    public class LambdaEventSourceMappingSelfManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig : aws.LambdaEventSourceMapping.ILambdaEventSourceMappingSelfManagedKafkaEventSourceConfigSchemaRegistryConfigSchemaValidationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lambda_event_source_mapping#attribute LambdaEventSourceMapping#attribute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Attribute
        {
            get;
            set;
        }
    }
}
