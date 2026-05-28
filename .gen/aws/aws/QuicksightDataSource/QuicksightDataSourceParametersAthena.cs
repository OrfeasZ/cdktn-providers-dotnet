using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    [JsiiByValue(fqn: "aws.quicksightDataSource.QuicksightDataSourceParametersAthena")]
    public class QuicksightDataSourceParametersAthena : aws.QuicksightDataSource.IQuicksightDataSourceParametersAthena
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/quicksight_data_source#role_arn QuicksightDataSource#role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/quicksight_data_source#work_group QuicksightDataSource#work_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "workGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WorkGroup
        {
            get;
            set;
        }
    }
}
