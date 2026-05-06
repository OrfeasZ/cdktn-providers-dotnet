using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationUsageStatementEmailRecipientsGroup
{
    [JsiiByValue(fqn: "oci.meteringComputationUsageStatementEmailRecipientsGroup.MeteringComputationUsageStatementEmailRecipientsGroupTimeouts")]
    public class MeteringComputationUsageStatementEmailRecipientsGroupTimeouts : oci.MeteringComputationUsageStatementEmailRecipientsGroup.IMeteringComputationUsageStatementEmailRecipientsGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_statement_email_recipients_group#create MeteringComputationUsageStatementEmailRecipientsGroup#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_statement_email_recipients_group#delete MeteringComputationUsageStatementEmailRecipientsGroup#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_statement_email_recipients_group#update MeteringComputationUsageStatementEmailRecipientsGroup#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
