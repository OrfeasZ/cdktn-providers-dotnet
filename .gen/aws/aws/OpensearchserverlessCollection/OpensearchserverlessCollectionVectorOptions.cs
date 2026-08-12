using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchserverlessCollection
{
    [JsiiByValue(fqn: "aws.opensearchserverlessCollection.OpensearchserverlessCollectionVectorOptions")]
    public class OpensearchserverlessCollectionVectorOptions : aws.OpensearchserverlessCollection.IOpensearchserverlessCollectionVectorOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/opensearchserverless_collection#serverless_vector_acceleration OpensearchserverlessCollection#serverless_vector_acceleration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverlessVectorAcceleration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServerlessVectorAcceleration
        {
            get;
            set;
        }
    }
}
