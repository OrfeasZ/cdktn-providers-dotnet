using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksNodeGroup
{
    [JsiiClass(nativeType: typeof(aws.EksNodeGroup.EksNodeGroupNodeRepairConfigOutputReference), fullyQualifiedName: "aws.eksNodeGroup.EksNodeGroupNodeRepairConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EksNodeGroupNodeRepairConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EksNodeGroupNodeRepairConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EksNodeGroupNodeRepairConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksNodeGroupNodeRepairConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNodeRepairConfigOverrides", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupNodeRepairConfigNodeRepairConfigOverrides\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNodeRepairConfigOverrides(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.EksNodeGroup.IEksNodeGroupNodeRepairConfigNodeRepairConfigOverrides[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EksNodeGroup.IEksNodeGroupNodeRepairConfigNodeRepairConfigOverrides).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EksNodeGroup.IEksNodeGroupNodeRepairConfigNodeRepairConfigOverrides).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxParallelNodesRepairedCount")]
        public virtual void ResetMaxParallelNodesRepairedCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxParallelNodesRepairedPercentage")]
        public virtual void ResetMaxParallelNodesRepairedPercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxUnhealthyNodeThresholdCount")]
        public virtual void ResetMaxUnhealthyNodeThresholdCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxUnhealthyNodeThresholdPercentage")]
        public virtual void ResetMaxUnhealthyNodeThresholdPercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeRepairConfigOverrides")]
        public virtual void ResetNodeRepairConfigOverrides()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "nodeRepairConfigOverrides", typeJson: "{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupNodeRepairConfigNodeRepairConfigOverridesList\"}")]
        public virtual aws.EksNodeGroup.EksNodeGroupNodeRepairConfigNodeRepairConfigOverridesList NodeRepairConfigOverrides
        {
            get => GetInstanceProperty<aws.EksNodeGroup.EksNodeGroupNodeRepairConfigNodeRepairConfigOverridesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxParallelNodesRepairedCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxParallelNodesRepairedCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxParallelNodesRepairedPercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxParallelNodesRepairedPercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxUnhealthyNodeThresholdCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxUnhealthyNodeThresholdCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxUnhealthyNodeThresholdPercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxUnhealthyNodeThresholdPercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeRepairConfigOverridesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupNodeRepairConfigNodeRepairConfigOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NodeRepairConfigOverridesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "maxParallelNodesRepairedCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxParallelNodesRepairedCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxParallelNodesRepairedPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxParallelNodesRepairedPercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxUnhealthyNodeThresholdCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxUnhealthyNodeThresholdCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxUnhealthyNodeThresholdPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxUnhealthyNodeThresholdPercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eksNodeGroup.EksNodeGroupNodeRepairConfig\"}", isOptional: true)]
        public virtual aws.EksNodeGroup.IEksNodeGroupNodeRepairConfig? InternalValue
        {
            get => GetInstanceProperty<aws.EksNodeGroup.IEksNodeGroupNodeRepairConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
