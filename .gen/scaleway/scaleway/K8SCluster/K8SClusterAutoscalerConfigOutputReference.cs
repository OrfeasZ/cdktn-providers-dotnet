using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.K8SCluster
{
    [JsiiClass(nativeType: typeof(scaleway.K8SCluster.K8SClusterAutoscalerConfigOutputReference), fullyQualifiedName: "scaleway.k8SCluster.K8SClusterAutoscalerConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class K8SClusterAutoscalerConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public K8SClusterAutoscalerConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected K8SClusterAutoscalerConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected K8SClusterAutoscalerConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBalanceSimilarNodeGroups")]
        public virtual void ResetBalanceSimilarNodeGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisableScaleDown")]
        public virtual void ResetDisableScaleDown()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEstimator")]
        public virtual void ResetEstimator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpander")]
        public virtual void ResetExpander()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpendablePodsPriorityCutoff")]
        public virtual void ResetExpendablePodsPriorityCutoff()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIgnoreDaemonsetsUtilization")]
        public virtual void ResetIgnoreDaemonsetsUtilization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxGracefulTerminationSec")]
        public virtual void ResetMaxGracefulTerminationSec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScaleDownDelayAfterAdd")]
        public virtual void ResetScaleDownDelayAfterAdd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScaleDownUnneededTime")]
        public virtual void ResetScaleDownUnneededTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScaleDownUtilizationThreshold")]
        public virtual void ResetScaleDownUtilizationThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "balanceSimilarNodeGroupsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? BalanceSimilarNodeGroupsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableScaleDownInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DisableScaleDownInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "estimatorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EstimatorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expanderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExpanderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expendablePodsPriorityCutoffInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ExpendablePodsPriorityCutoffInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ignoreDaemonsetsUtilizationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IgnoreDaemonsetsUtilizationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxGracefulTerminationSecInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxGracefulTerminationSecInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleDownDelayAfterAddInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScaleDownDelayAfterAddInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleDownUnneededTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScaleDownUnneededTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleDownUtilizationThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ScaleDownUtilizationThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "balanceSimilarNodeGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object BalanceSimilarNodeGroups
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

        [JsiiProperty(name: "disableScaleDown", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DisableScaleDown
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

        [JsiiProperty(name: "estimator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Estimator
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "expander", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Expander
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "expendablePodsPriorityCutoff", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpendablePodsPriorityCutoff
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ignoreDaemonsetsUtilization", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IgnoreDaemonsetsUtilization
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

        [JsiiProperty(name: "maxGracefulTerminationSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxGracefulTerminationSec
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scaleDownDelayAfterAdd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScaleDownDelayAfterAdd
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scaleDownUnneededTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScaleDownUnneededTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scaleDownUtilizationThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScaleDownUtilizationThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.k8SCluster.K8SClusterAutoscalerConfig\"}", isOptional: true)]
        public virtual scaleway.K8SCluster.IK8SClusterAutoscalerConfig? InternalValue
        {
            get => GetInstanceProperty<scaleway.K8SCluster.IK8SClusterAutoscalerConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
