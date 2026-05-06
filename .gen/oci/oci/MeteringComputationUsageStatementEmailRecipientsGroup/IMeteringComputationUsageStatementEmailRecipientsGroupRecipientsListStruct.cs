using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationUsageStatementEmailRecipientsGroup
{
    [JsiiInterface(nativeType: typeof(IMeteringComputationUsageStatementEmailRecipientsGroupRecipientsListStruct), fullyQualifiedName: "oci.meteringComputationUsageStatementEmailRecipientsGroup.MeteringComputationUsageStatementEmailRecipientsGroupRecipientsListStruct")]
    public interface IMeteringComputationUsageStatementEmailRecipientsGroupRecipientsListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_statement_email_recipients_group#email_id MeteringComputationUsageStatementEmailRecipientsGroup#email_id}.</summary>
        [JsiiProperty(name: "emailId", typeJson: "{\"primitive\":\"string\"}")]
        string EmailId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_statement_email_recipients_group#state MeteringComputationUsageStatementEmailRecipientsGroup#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        string State
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_statement_email_recipients_group#first_name MeteringComputationUsageStatementEmailRecipientsGroup#first_name}.</summary>
        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FirstName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_statement_email_recipients_group#last_name MeteringComputationUsageStatementEmailRecipientsGroup#last_name}.</summary>
        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LastName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMeteringComputationUsageStatementEmailRecipientsGroupRecipientsListStruct), fullyQualifiedName: "oci.meteringComputationUsageStatementEmailRecipientsGroup.MeteringComputationUsageStatementEmailRecipientsGroupRecipientsListStruct")]
        internal sealed class _Proxy : DeputyBase, oci.MeteringComputationUsageStatementEmailRecipientsGroup.IMeteringComputationUsageStatementEmailRecipientsGroupRecipientsListStruct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_statement_email_recipients_group#email_id MeteringComputationUsageStatementEmailRecipientsGroup#email_id}.</summary>
            [JsiiProperty(name: "emailId", typeJson: "{\"primitive\":\"string\"}")]
            public string EmailId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_statement_email_recipients_group#state MeteringComputationUsageStatementEmailRecipientsGroup#state}.</summary>
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
            public string State
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_statement_email_recipients_group#first_name MeteringComputationUsageStatementEmailRecipientsGroup#first_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FirstName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_usage_statement_email_recipients_group#last_name MeteringComputationUsageStatementEmailRecipientsGroup#last_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LastName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
