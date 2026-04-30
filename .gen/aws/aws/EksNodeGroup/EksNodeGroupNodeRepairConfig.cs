using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksNodeGroup
{
    [JsiiByValue(fqn: "aws.eksNodeGroup.EksNodeGroupNodeRepairConfig")]
    public class EksNodeGroupNodeRepairConfig : aws.EksNodeGroup.IEksNodeGroupNodeRepairConfig
    {
        private object? _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_node_group#enabled EksNodeGroup#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_node_group#max_parallel_nodes_repaired_count EksNodeGroup#max_parallel_nodes_repaired_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxParallelNodesRepairedCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxParallelNodesRepairedCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_node_group#max_parallel_nodes_repaired_percentage EksNodeGroup#max_parallel_nodes_repaired_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxParallelNodesRepairedPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxParallelNodesRepairedPercentage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_node_group#max_unhealthy_node_threshold_count EksNodeGroup#max_unhealthy_node_threshold_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUnhealthyNodeThresholdCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxUnhealthyNodeThresholdCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_node_group#max_unhealthy_node_threshold_percentage EksNodeGroup#max_unhealthy_node_threshold_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUnhealthyNodeThresholdPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxUnhealthyNodeThresholdPercentage
        {
            get;
            set;
        }

        private object? _nodeRepairConfigOverrides;

        /// <summary>node_repair_config_overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/eks_node_group#node_repair_config_overrides EksNodeGroup#node_repair_config_overrides}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeRepairConfigOverrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupNodeRepairConfigNodeRepairConfigOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NodeRepairConfigOverrides
        {
            get => _nodeRepairConfigOverrides;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EksNodeGroup.IEksNodeGroupNodeRepairConfigNodeRepairConfigOverrides[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EksNodeGroup.IEksNodeGroupNodeRepairConfigNodeRepairConfigOverrides).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _nodeRepairConfigOverrides = value;
            }
        }
    }
}
