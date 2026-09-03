using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepAuroraProvisionedScalingConfig")]
    public class ArcregionswitchPlanWorkflowStepAuroraProvisionedScalingConfig : aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepAuroraProvisionedScalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/arcregionswitch_plan#global_cluster_identifier ArcregionswitchPlan#global_cluster_identifier}.</summary>
        [JsiiProperty(name: "globalClusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string GlobalClusterIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/arcregionswitch_plan#instance_arns ArcregionswitchPlan#instance_arns}.</summary>
        [JsiiProperty(name: "instanceArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, string> InstanceArns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/arcregionswitch_plan#region_database_cluster_arns ArcregionswitchPlan#region_database_cluster_arns}.</summary>
        [JsiiProperty(name: "regionDatabaseClusterArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, string> RegionDatabaseClusterArns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/arcregionswitch_plan#cross_account_role ArcregionswitchPlan#cross_account_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "crossAccountRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CrossAccountRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/arcregionswitch_plan#external_id ArcregionswitchPlan#external_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExternalId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/arcregionswitch_plan#timeout_minutes ArcregionswitchPlan#timeout_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutMinutes
        {
            get;
            set;
        }
    }
}
