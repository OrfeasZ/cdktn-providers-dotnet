using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanWorkflowStepParallelConfigStepRoute53HealthCheckConfigRecordSet), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRoute53HealthCheckConfigRecordSet")]
    public interface IArcregionswitchPlanWorkflowStepParallelConfigStepRoute53HealthCheckConfigRecordSet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#record_set_identifier ArcregionswitchPlan#record_set_identifier}.</summary>
        [JsiiProperty(name: "recordSetIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string RecordSetIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#region ArcregionswitchPlan#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanWorkflowStepParallelConfigStepRoute53HealthCheckConfigRecordSet), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRoute53HealthCheckConfigRecordSet")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepRoute53HealthCheckConfigRecordSet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#record_set_identifier ArcregionswitchPlan#record_set_identifier}.</summary>
            [JsiiProperty(name: "recordSetIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string RecordSetIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#region ArcregionswitchPlan#region}.</summary>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
