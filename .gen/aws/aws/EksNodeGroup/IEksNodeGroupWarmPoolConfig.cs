using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksNodeGroup
{
    [JsiiInterface(nativeType: typeof(IEksNodeGroupWarmPoolConfig), fullyQualifiedName: "aws.eksNodeGroup.EksNodeGroupWarmPoolConfig")]
    public interface IEksNodeGroupWarmPoolConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/eks_node_group#max_group_prepared_capacity EksNodeGroup#max_group_prepared_capacity}.</summary>
        [JsiiProperty(name: "maxGroupPreparedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxGroupPreparedCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/eks_node_group#min_size EksNodeGroup#min_size}.</summary>
        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/eks_node_group#pool_state EksNodeGroup#pool_state}.</summary>
        [JsiiProperty(name: "poolState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PoolState
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/eks_node_group#reuse_on_scale_in EksNodeGroup#reuse_on_scale_in}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "reuseOnScaleIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReuseOnScaleIn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksNodeGroupWarmPoolConfig), fullyQualifiedName: "aws.eksNodeGroup.EksNodeGroupWarmPoolConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EksNodeGroup.IEksNodeGroupWarmPoolConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/eks_node_group#max_group_prepared_capacity EksNodeGroup#max_group_prepared_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxGroupPreparedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxGroupPreparedCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/eks_node_group#min_size EksNodeGroup#min_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/eks_node_group#pool_state EksNodeGroup#pool_state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "poolState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PoolState
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/eks_node_group#reuse_on_scale_in EksNodeGroup#reuse_on_scale_in}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reuseOnScaleIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ReuseOnScaleIn
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
