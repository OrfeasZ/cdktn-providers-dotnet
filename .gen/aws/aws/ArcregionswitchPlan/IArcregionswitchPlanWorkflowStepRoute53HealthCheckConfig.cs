using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanWorkflowStepRoute53HealthCheckConfig), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepRoute53HealthCheckConfig")]
    public interface IArcregionswitchPlanWorkflowStepRoute53HealthCheckConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#hosted_zone_id ArcregionswitchPlan#hosted_zone_id}.</summary>
        [JsiiProperty(name: "hostedZoneId", typeJson: "{\"primitive\":\"string\"}")]
        string HostedZoneId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#record_name ArcregionswitchPlan#record_name}.</summary>
        [JsiiProperty(name: "recordName", typeJson: "{\"primitive\":\"string\"}")]
        string RecordName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#cross_account_role ArcregionswitchPlan#cross_account_role}.</summary>
        [JsiiProperty(name: "crossAccountRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CrossAccountRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#external_id ArcregionswitchPlan#external_id}.</summary>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalId
        {
            get
            {
                return null;
            }
        }

        /// <summary>record_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#record_set ArcregionswitchPlan#record_set}
        /// </remarks>
        [JsiiProperty(name: "recordSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepRoute53HealthCheckConfigRecordSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecordSet
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#timeout_minutes ArcregionswitchPlan#timeout_minutes}.</summary>
        [JsiiProperty(name: "timeoutMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeoutMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanWorkflowStepRoute53HealthCheckConfig), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepRoute53HealthCheckConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepRoute53HealthCheckConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#hosted_zone_id ArcregionswitchPlan#hosted_zone_id}.</summary>
            [JsiiProperty(name: "hostedZoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string HostedZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#record_name ArcregionswitchPlan#record_name}.</summary>
            [JsiiProperty(name: "recordName", typeJson: "{\"primitive\":\"string\"}")]
            public string RecordName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#cross_account_role ArcregionswitchPlan#cross_account_role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "crossAccountRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CrossAccountRole
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#external_id ArcregionswitchPlan#external_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>record_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#record_set ArcregionswitchPlan#record_set}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recordSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepRoute53HealthCheckConfigRecordSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RecordSet
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#timeout_minutes ArcregionswitchPlan#timeout_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimeoutMinutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
