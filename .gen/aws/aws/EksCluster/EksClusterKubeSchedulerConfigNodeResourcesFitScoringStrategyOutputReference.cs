using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiClass(nativeType: typeof(aws.EksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyOutputReference), fullyQualifiedName: "aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyResource" />)[]</param>
        [JsiiMethod(name: "putResource", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyResource\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResource(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyResource[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyResource).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyResource).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetResource")]
        public virtual void ResetResource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "resource", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyResourceList\"}")]
        public virtual aws.EksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyResourceList Resource
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyResourceList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyResource" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategyResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy? InternalValue
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterKubeSchedulerConfigNodeResourcesFitScoringStrategy?>();
            set => SetInstanceProperty(value);
        }
    }
}
