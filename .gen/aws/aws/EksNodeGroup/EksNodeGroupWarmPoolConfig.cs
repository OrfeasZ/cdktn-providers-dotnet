using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksNodeGroup
{
    [JsiiByValue(fqn: "aws.eksNodeGroup.EksNodeGroupWarmPoolConfig")]
    public class EksNodeGroupWarmPoolConfig : aws.EksNodeGroup.IEksNodeGroupWarmPoolConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/eks_node_group#max_group_prepared_capacity EksNodeGroup#max_group_prepared_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxGroupPreparedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxGroupPreparedCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/eks_node_group#min_size EksNodeGroup#min_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/eks_node_group#pool_state EksNodeGroup#pool_state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "poolState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PoolState
        {
            get;
            set;
        }

        private object? _reuseOnScaleIn;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/eks_node_group#reuse_on_scale_in EksNodeGroup#reuse_on_scale_in}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reuseOnScaleIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ReuseOnScaleIn
        {
            get => _reuseOnScaleIn;
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
                _reuseOnScaleIn = value;
            }
        }
    }
}
