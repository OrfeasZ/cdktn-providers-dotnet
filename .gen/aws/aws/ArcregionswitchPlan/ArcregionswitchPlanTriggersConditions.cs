using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.arcregionswitchPlan.ArcregionswitchPlanTriggersConditions")]
    public class ArcregionswitchPlanTriggersConditions : aws.ArcregionswitchPlan.IArcregionswitchPlanTriggersConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#associated_alarm_name ArcregionswitchPlan#associated_alarm_name}.</summary>
        [JsiiProperty(name: "associatedAlarmName", typeJson: "{\"primitive\":\"string\"}")]
        public string AssociatedAlarmName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#condition ArcregionswitchPlan#condition}.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
        public string Condition
        {
            get;
            set;
        }
    }
}
