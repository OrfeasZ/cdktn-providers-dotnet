using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseScheduledAction
{
    [JsiiInterface(nativeType: typeof(IDatabaseScheduledActionActionMembers), fullyQualifiedName: "oci.databaseScheduledAction.DatabaseScheduledActionActionMembers")]
    public interface IDatabaseScheduledActionActionMembers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduled_action#member_id DatabaseScheduledAction#member_id}.</summary>
        [JsiiProperty(name: "memberId", typeJson: "{\"primitive\":\"string\"}")]
        string MemberId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduled_action#member_order DatabaseScheduledAction#member_order}.</summary>
        [JsiiProperty(name: "memberOrder", typeJson: "{\"primitive\":\"number\"}")]
        double MemberOrder
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduled_action#estimated_time_in_mins DatabaseScheduledAction#estimated_time_in_mins}.</summary>
        [JsiiProperty(name: "estimatedTimeInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EstimatedTimeInMins
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseScheduledActionActionMembers), fullyQualifiedName: "oci.databaseScheduledAction.DatabaseScheduledActionActionMembers")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseScheduledAction.IDatabaseScheduledActionActionMembers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduled_action#member_id DatabaseScheduledAction#member_id}.</summary>
            [JsiiProperty(name: "memberId", typeJson: "{\"primitive\":\"string\"}")]
            public string MemberId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduled_action#member_order DatabaseScheduledAction#member_order}.</summary>
            [JsiiProperty(name: "memberOrder", typeJson: "{\"primitive\":\"number\"}")]
            public double MemberOrder
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_scheduled_action#estimated_time_in_mins DatabaseScheduledAction#estimated_time_in_mins}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "estimatedTimeInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EstimatedTimeInMins
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
