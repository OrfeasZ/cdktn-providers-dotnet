using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanTriggersConditions), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanTriggersConditions")]
    public interface IArcregionswitchPlanTriggersConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#associated_alarm_name ArcregionswitchPlan#associated_alarm_name}.</summary>
        [JsiiProperty(name: "associatedAlarmName", typeJson: "{\"primitive\":\"string\"}")]
        string AssociatedAlarmName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#condition ArcregionswitchPlan#condition}.</summary>
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
        string Condition
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanTriggersConditions), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanTriggersConditions")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanTriggersConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#associated_alarm_name ArcregionswitchPlan#associated_alarm_name}.</summary>
            [JsiiProperty(name: "associatedAlarmName", typeJson: "{\"primitive\":\"string\"}")]
            public string AssociatedAlarmName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#condition ArcregionswitchPlan#condition}.</summary>
            [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}")]
            public string Condition
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
