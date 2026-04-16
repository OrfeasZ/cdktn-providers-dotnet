using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfig")]
    public class ArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfig : aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#capacity_monitoring_approach ArcregionswitchPlan#capacity_monitoring_approach}.</summary>
        [JsiiProperty(name: "capacityMonitoringApproach", typeJson: "{\"primitive\":\"string\"}")]
        public string CapacityMonitoringApproach
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#target_percent ArcregionswitchPlan#target_percent}.</summary>
        [JsiiProperty(name: "targetPercent", typeJson: "{\"primitive\":\"number\"}")]
        public double TargetPercent
        {
            get;
            set;
        }

        private object? _eksClusters;

        /// <summary>eks_clusters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#eks_clusters ArcregionswitchPlan#eks_clusters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eksClusters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigEksClusters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EksClusters
        {
            get => _eksClusters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigEksClusters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigEksClusters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _eksClusters = value;
            }
        }

        private object? _kubernetesResourceType;

        /// <summary>kubernetes_resource_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#kubernetes_resource_type ArcregionswitchPlan#kubernetes_resource_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kubernetesResourceType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigKubernetesResourceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? KubernetesResourceType
        {
            get => _kubernetesResourceType;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigKubernetesResourceType[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigKubernetesResourceType).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _kubernetesResourceType = value;
            }
        }

        private object? _scalingResources;

        /// <summary>scaling_resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#scaling_resources ArcregionswitchPlan#scaling_resources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scalingResources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigScalingResources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ScalingResources
        {
            get => _scalingResources;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigScalingResources[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigScalingResources).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scalingResources = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#timeout_minutes ArcregionswitchPlan#timeout_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutMinutes
        {
            get;
            set;
        }

        private object? _ungraceful;

        /// <summary>ungraceful block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/arcregionswitch_plan#ungraceful ArcregionswitchPlan#ungraceful}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ungraceful", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigUngraceful\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ungraceful
        {
            get => _ungraceful;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigUngraceful[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigUngraceful).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ungraceful = value;
            }
        }
    }
}
