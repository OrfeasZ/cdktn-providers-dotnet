using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksNodeGroup
{
    [JsiiInterface(nativeType: typeof(IEksNodeGroupNodeRepairConfig), fullyQualifiedName: "aws.eksNodeGroup.EksNodeGroupNodeRepairConfig")]
    public interface IEksNodeGroupNodeRepairConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#enabled EksNodeGroup#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#max_parallel_nodes_repaired_count EksNodeGroup#max_parallel_nodes_repaired_count}.</summary>
        [JsiiProperty(name: "maxParallelNodesRepairedCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxParallelNodesRepairedCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#max_parallel_nodes_repaired_percentage EksNodeGroup#max_parallel_nodes_repaired_percentage}.</summary>
        [JsiiProperty(name: "maxParallelNodesRepairedPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxParallelNodesRepairedPercentage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#max_unhealthy_node_threshold_count EksNodeGroup#max_unhealthy_node_threshold_count}.</summary>
        [JsiiProperty(name: "maxUnhealthyNodeThresholdCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUnhealthyNodeThresholdCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#max_unhealthy_node_threshold_percentage EksNodeGroup#max_unhealthy_node_threshold_percentage}.</summary>
        [JsiiProperty(name: "maxUnhealthyNodeThresholdPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUnhealthyNodeThresholdPercentage
        {
            get
            {
                return null;
            }
        }

        /// <summary>node_repair_config_overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#node_repair_config_overrides EksNodeGroup#node_repair_config_overrides}
        /// </remarks>
        [JsiiProperty(name: "nodeRepairConfigOverrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupNodeRepairConfigNodeRepairConfigOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NodeRepairConfigOverrides
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksNodeGroupNodeRepairConfig), fullyQualifiedName: "aws.eksNodeGroup.EksNodeGroupNodeRepairConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EksNodeGroup.IEksNodeGroupNodeRepairConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#enabled EksNodeGroup#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#max_parallel_nodes_repaired_count EksNodeGroup#max_parallel_nodes_repaired_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxParallelNodesRepairedCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxParallelNodesRepairedCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#max_parallel_nodes_repaired_percentage EksNodeGroup#max_parallel_nodes_repaired_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxParallelNodesRepairedPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxParallelNodesRepairedPercentage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#max_unhealthy_node_threshold_count EksNodeGroup#max_unhealthy_node_threshold_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUnhealthyNodeThresholdCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUnhealthyNodeThresholdCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#max_unhealthy_node_threshold_percentage EksNodeGroup#max_unhealthy_node_threshold_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUnhealthyNodeThresholdPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUnhealthyNodeThresholdPercentage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>node_repair_config_overrides block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#node_repair_config_overrides EksNodeGroup#node_repair_config_overrides}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeRepairConfigOverrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupNodeRepairConfigNodeRepairConfigOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NodeRepairConfigOverrides
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
