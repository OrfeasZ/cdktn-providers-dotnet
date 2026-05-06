using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExecutionAction
{
    [JsiiInterface(nativeType: typeof(IDatabaseExecutionActionActionMembers), fullyQualifiedName: "oci.databaseExecutionAction.DatabaseExecutionActionActionMembers")]
    public interface IDatabaseExecutionActionActionMembers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_execution_action#member_id DatabaseExecutionAction#member_id}.</summary>
        [JsiiProperty(name: "memberId", typeJson: "{\"primitive\":\"string\"}")]
        string MemberId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_execution_action#member_order DatabaseExecutionAction#member_order}.</summary>
        [JsiiProperty(name: "memberOrder", typeJson: "{\"primitive\":\"number\"}")]
        double MemberOrder
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_execution_action#estimated_time_in_mins DatabaseExecutionAction#estimated_time_in_mins}.</summary>
        [JsiiProperty(name: "estimatedTimeInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EstimatedTimeInMins
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_execution_action#status DatabaseExecutionAction#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_execution_action#total_time_taken_in_mins DatabaseExecutionAction#total_time_taken_in_mins}.</summary>
        [JsiiProperty(name: "totalTimeTakenInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TotalTimeTakenInMins
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseExecutionActionActionMembers), fullyQualifiedName: "oci.databaseExecutionAction.DatabaseExecutionActionActionMembers")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseExecutionAction.IDatabaseExecutionActionActionMembers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_execution_action#member_id DatabaseExecutionAction#member_id}.</summary>
            [JsiiProperty(name: "memberId", typeJson: "{\"primitive\":\"string\"}")]
            public string MemberId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_execution_action#member_order DatabaseExecutionAction#member_order}.</summary>
            [JsiiProperty(name: "memberOrder", typeJson: "{\"primitive\":\"number\"}")]
            public double MemberOrder
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_execution_action#estimated_time_in_mins DatabaseExecutionAction#estimated_time_in_mins}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "estimatedTimeInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EstimatedTimeInMins
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_execution_action#status DatabaseExecutionAction#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_execution_action#total_time_taken_in_mins DatabaseExecutionAction#total_time_taken_in_mins}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "totalTimeTakenInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalTimeTakenInMins
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
