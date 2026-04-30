using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepRoute53HealthCheckConfigRecordSet")]
    public class ArcregionswitchPlanWorkflowStepRoute53HealthCheckConfigRecordSet : aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepRoute53HealthCheckConfigRecordSet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#record_set_identifier ArcregionswitchPlan#record_set_identifier}.</summary>
        [JsiiProperty(name: "recordSetIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string RecordSetIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/arcregionswitch_plan#region ArcregionswitchPlan#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public string Region
        {
            get;
            set;
        }
    }
}
