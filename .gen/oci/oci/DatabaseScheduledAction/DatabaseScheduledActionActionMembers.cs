using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseScheduledAction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseScheduledAction.DatabaseScheduledActionActionMembers")]
    public class DatabaseScheduledActionActionMembers : oci.DatabaseScheduledAction.IDatabaseScheduledActionActionMembers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduled_action#member_id DatabaseScheduledAction#member_id}.</summary>
        [JsiiProperty(name: "memberId", typeJson: "{\"primitive\":\"string\"}")]
        public string MemberId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduled_action#member_order DatabaseScheduledAction#member_order}.</summary>
        [JsiiProperty(name: "memberOrder", typeJson: "{\"primitive\":\"number\"}")]
        public double MemberOrder
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduled_action#estimated_time_in_mins DatabaseScheduledAction#estimated_time_in_mins}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "estimatedTimeInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EstimatedTimeInMins
        {
            get;
            set;
        }
    }
}
