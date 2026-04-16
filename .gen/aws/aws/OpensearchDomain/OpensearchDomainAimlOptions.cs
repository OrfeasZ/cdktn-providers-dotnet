using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiByValue(fqn: "aws.opensearchDomain.OpensearchDomainAimlOptions")]
    public class OpensearchDomainAimlOptions : aws.OpensearchDomain.IOpensearchDomainAimlOptions
    {
        /// <summary>natural_language_query_generation_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearch_domain#natural_language_query_generation_options OpensearchDomain#natural_language_query_generation_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "naturalLanguageQueryGenerationOptions", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptions\"}", isOptional: true)]
        public aws.OpensearchDomain.IOpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptions? NaturalLanguageQueryGenerationOptions
        {
            get;
            set;
        }

        /// <summary>s3_vectors_engine block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearch_domain#s3_vectors_engine OpensearchDomain#s3_vectors_engine}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3VectorsEngine", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAimlOptionsS3VectorsEngine\"}", isOptional: true)]
        public aws.OpensearchDomain.IOpensearchDomainAimlOptionsS3VectorsEngine? S3VectorsEngine
        {
            get;
            set;
        }

        /// <summary>serverless_vector_acceleration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearch_domain#serverless_vector_acceleration OpensearchDomain#serverless_vector_acceleration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverlessVectorAcceleration", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAimlOptionsServerlessVectorAcceleration\"}", isOptional: true)]
        public aws.OpensearchDomain.IOpensearchDomainAimlOptionsServerlessVectorAcceleration? ServerlessVectorAcceleration
        {
            get;
            set;
        }
    }
}
