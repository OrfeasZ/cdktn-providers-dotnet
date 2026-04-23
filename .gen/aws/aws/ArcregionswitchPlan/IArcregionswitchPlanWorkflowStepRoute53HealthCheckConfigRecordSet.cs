using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanWorkflowStepRoute53HealthCheckConfigRecordSet), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepRoute53HealthCheckConfigRecordSet")]
    public interface IArcregionswitchPlanWorkflowStepRoute53HealthCheckConfigRecordSet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#record_set_identifier ArcregionswitchPlan#record_set_identifier}.</summary>
        [JsiiProperty(name: "recordSetIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string RecordSetIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#region ArcregionswitchPlan#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanWorkflowStepRoute53HealthCheckConfigRecordSet), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepRoute53HealthCheckConfigRecordSet")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepRoute53HealthCheckConfigRecordSet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#record_set_identifier ArcregionswitchPlan#record_set_identifier}.</summary>
            [JsiiProperty(name: "recordSetIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string RecordSetIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#region ArcregionswitchPlan#region}.</summary>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
