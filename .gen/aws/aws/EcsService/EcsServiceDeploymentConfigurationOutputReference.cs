using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiClass(nativeType: typeof(aws.EcsService.EcsServiceDeploymentConfigurationOutputReference), fullyQualifiedName: "aws.ecsService.EcsServiceDeploymentConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EcsServiceDeploymentConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EcsServiceDeploymentConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EcsServiceDeploymentConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsServiceDeploymentConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCanaryConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationCanaryConfiguration\"}}]")]
        public virtual void PutCanaryConfiguration(aws.EcsService.IEcsServiceDeploymentConfigurationCanaryConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsService.IEcsServiceDeploymentConfigurationCanaryConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLifecycleHook", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationLifecycleHook\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLifecycleHook(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.EcsService.IEcsServiceDeploymentConfigurationLifecycleHook[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsService.IEcsServiceDeploymentConfigurationLifecycleHook).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsService.IEcsServiceDeploymentConfigurationLifecycleHook).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLinearConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationLinearConfiguration\"}}]")]
        public virtual void PutLinearConfiguration(aws.EcsService.IEcsServiceDeploymentConfigurationLinearConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsService.IEcsServiceDeploymentConfigurationLinearConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBakeTimeInMinutes")]
        public virtual void ResetBakeTimeInMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCanaryConfiguration")]
        public virtual void ResetCanaryConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLifecycleHook")]
        public virtual void ResetLifecycleHook()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLinearConfiguration")]
        public virtual void ResetLinearConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStrategy")]
        public virtual void ResetStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "canaryConfiguration", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationCanaryConfigurationOutputReference\"}")]
        public virtual aws.EcsService.EcsServiceDeploymentConfigurationCanaryConfigurationOutputReference CanaryConfiguration
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceDeploymentConfigurationCanaryConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleHook", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationLifecycleHookList\"}")]
        public virtual aws.EcsService.EcsServiceDeploymentConfigurationLifecycleHookList LifecycleHook
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceDeploymentConfigurationLifecycleHookList>()!;
        }

        [JsiiProperty(name: "linearConfiguration", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationLinearConfigurationOutputReference\"}")]
        public virtual aws.EcsService.EcsServiceDeploymentConfigurationLinearConfigurationOutputReference LinearConfiguration
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceDeploymentConfigurationLinearConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bakeTimeInMinutesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BakeTimeInMinutesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "canaryConfigurationInput", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationCanaryConfiguration\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceDeploymentConfigurationCanaryConfiguration? CanaryConfigurationInput
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceDeploymentConfigurationCanaryConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lifecycleHookInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationLifecycleHook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LifecycleHookInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linearConfigurationInput", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfigurationLinearConfiguration\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceDeploymentConfigurationLinearConfiguration? LinearConfigurationInput
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceDeploymentConfigurationLinearConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "strategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bakeTimeInMinutes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BakeTimeInMinutes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Strategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceDeploymentConfiguration\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceDeploymentConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceDeploymentConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
