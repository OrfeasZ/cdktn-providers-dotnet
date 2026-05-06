using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExecutionAction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseExecutionAction.DatabaseExecutionActionActionMembers")]
    public class DatabaseExecutionActionActionMembers : oci.DatabaseExecutionAction.IDatabaseExecutionActionActionMembers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_execution_action#member_id DatabaseExecutionAction#member_id}.</summary>
        [JsiiProperty(name: "memberId", typeJson: "{\"primitive\":\"string\"}")]
        public string MemberId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_execution_action#member_order DatabaseExecutionAction#member_order}.</summary>
        [JsiiProperty(name: "memberOrder", typeJson: "{\"primitive\":\"number\"}")]
        public double MemberOrder
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_execution_action#estimated_time_in_mins DatabaseExecutionAction#estimated_time_in_mins}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "estimatedTimeInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EstimatedTimeInMins
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_execution_action#status DatabaseExecutionAction#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_execution_action#total_time_taken_in_mins DatabaseExecutionAction#total_time_taken_in_mins}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "totalTimeTakenInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TotalTimeTakenInMins
        {
            get;
            set;
        }
    }
}
