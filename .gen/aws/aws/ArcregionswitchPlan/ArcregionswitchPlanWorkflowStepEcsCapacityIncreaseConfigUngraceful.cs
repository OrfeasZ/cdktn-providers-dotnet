using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepEcsCapacityIncreaseConfigUngraceful")]
    public class ArcregionswitchPlanWorkflowStepEcsCapacityIncreaseConfigUngraceful : aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepEcsCapacityIncreaseConfigUngraceful
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#minimum_success_percentage ArcregionswitchPlan#minimum_success_percentage}.</summary>
        [JsiiProperty(name: "minimumSuccessPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public double MinimumSuccessPercentage
        {
            get;
            set;
        }
    }
}
