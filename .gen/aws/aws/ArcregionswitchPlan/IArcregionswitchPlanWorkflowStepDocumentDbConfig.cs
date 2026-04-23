using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanWorkflowStepDocumentDbConfig), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepDocumentDbConfig")]
    public interface IArcregionswitchPlanWorkflowStepDocumentDbConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#behavior ArcregionswitchPlan#behavior}.</summary>
        [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}")]
        string Behavior
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#database_cluster_arns ArcregionswitchPlan#database_cluster_arns}.</summary>
        [JsiiProperty(name: "databaseClusterArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DatabaseClusterArns
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#global_cluster_identifier ArcregionswitchPlan#global_cluster_identifier}.</summary>
        [JsiiProperty(name: "globalClusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string GlobalClusterIdentifier
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#timeout_minutes ArcregionswitchPlan#timeout_minutes}.</summary>
        [JsiiProperty(name: "timeoutMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeoutMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>ungraceful block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#ungraceful ArcregionswitchPlan#ungraceful}
        /// </remarks>
        [JsiiProperty(name: "ungraceful", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepDocumentDbConfigUngraceful\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ungraceful
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanWorkflowStepDocumentDbConfig), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepDocumentDbConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepDocumentDbConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#behavior ArcregionswitchPlan#behavior}.</summary>
            [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}")]
            public string Behavior
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#database_cluster_arns ArcregionswitchPlan#database_cluster_arns}.</summary>
            [JsiiProperty(name: "databaseClusterArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DatabaseClusterArns
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#global_cluster_identifier ArcregionswitchPlan#global_cluster_identifier}.</summary>
            [JsiiProperty(name: "globalClusterIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string GlobalClusterIdentifier
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#timeout_minutes ArcregionswitchPlan#timeout_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimeoutMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>ungraceful block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/arcregionswitch_plan#ungraceful ArcregionswitchPlan#ungraceful}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ungraceful", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepDocumentDbConfigUngraceful\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ungraceful
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
