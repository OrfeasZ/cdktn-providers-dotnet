using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanAssociatedAlarms), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanAssociatedAlarms")]
    public interface IArcregionswitchPlanAssociatedAlarms
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#alarm_type ArcregionswitchPlan#alarm_type}.</summary>
        [JsiiProperty(name: "alarmType", typeJson: "{\"primitive\":\"string\"}")]
        string AlarmType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#map_block_key ArcregionswitchPlan#map_block_key}.</summary>
        [JsiiProperty(name: "mapBlockKey", typeJson: "{\"primitive\":\"string\"}")]
        string MapBlockKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#resource_identifier ArcregionswitchPlan#resource_identifier}.</summary>
        [JsiiProperty(name: "resourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#cross_account_role ArcregionswitchPlan#cross_account_role}.</summary>
        [JsiiProperty(name: "crossAccountRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CrossAccountRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#external_id ArcregionswitchPlan#external_id}.</summary>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanAssociatedAlarms), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanAssociatedAlarms")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanAssociatedAlarms
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#alarm_type ArcregionswitchPlan#alarm_type}.</summary>
            [JsiiProperty(name: "alarmType", typeJson: "{\"primitive\":\"string\"}")]
            public string AlarmType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#map_block_key ArcregionswitchPlan#map_block_key}.</summary>
            [JsiiProperty(name: "mapBlockKey", typeJson: "{\"primitive\":\"string\"}")]
            public string MapBlockKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#resource_identifier ArcregionswitchPlan#resource_identifier}.</summary>
            [JsiiProperty(name: "resourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#cross_account_role ArcregionswitchPlan#cross_account_role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "crossAccountRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CrossAccountRole
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#external_id ArcregionswitchPlan#external_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
