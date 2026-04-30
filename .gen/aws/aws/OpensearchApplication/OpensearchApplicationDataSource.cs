using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchApplication
{
    [JsiiByValue(fqn: "aws.opensearchApplication.OpensearchApplicationDataSource")]
    public class OpensearchApplicationDataSource : aws.OpensearchApplication.IOpensearchApplicationDataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_application#data_source_arn OpensearchApplication#data_source_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataSourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataSourceArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearch_application#data_source_description OpensearchApplication#data_source_description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataSourceDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataSourceDescription
        {
            get;
            set;
        }
    }
}
