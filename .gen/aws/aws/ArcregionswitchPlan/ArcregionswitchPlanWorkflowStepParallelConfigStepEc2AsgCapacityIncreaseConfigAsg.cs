using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEc2AsgCapacityIncreaseConfigAsg")]
    public class ArcregionswitchPlanWorkflowStepParallelConfigStepEc2AsgCapacityIncreaseConfigAsg : aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEc2AsgCapacityIncreaseConfigAsg
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#arn ArcregionswitchPlan#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public string Arn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#cross_account_role ArcregionswitchPlan#cross_account_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "crossAccountRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CrossAccountRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#external_id ArcregionswitchPlan#external_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExternalId
        {
            get;
            set;
        }
    }
}
