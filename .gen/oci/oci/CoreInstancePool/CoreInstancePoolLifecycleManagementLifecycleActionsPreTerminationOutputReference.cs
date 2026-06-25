using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiClass(nativeType: typeof(oci.CoreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOutputReference), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOnTimeout", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout\"}}]")]
        public virtual void PutOnTimeout(oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout)}, new object[]{@value});
        }

        [JsiiProperty(name: "onTimeout", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeoutOutputReference\"}")]
        public virtual oci.CoreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeoutOutputReference OnTimeout
        {
            get => GetInstanceProperty<oci.CoreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeoutOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onTimeoutInput", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout\"}", isOptional: true)]
        public virtual oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout? OnTimeoutInput
        {
            get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsEnabled
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

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Timeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTermination\"}", isOptional: true)]
        public virtual oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTermination? InternalValue
        {
            get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTermination?>();
            set => SetInstanceProperty(value);
        }
    }
}
