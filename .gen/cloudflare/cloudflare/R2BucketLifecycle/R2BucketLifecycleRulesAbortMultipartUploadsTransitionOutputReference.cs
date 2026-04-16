using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketLifecycle
{
    [JsiiClass(nativeType: typeof(cloudflare.R2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransitionOutputReference), fullyQualifiedName: "cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransitionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class R2BucketLifecycleRulesAbortMultipartUploadsTransitionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public R2BucketLifecycleRulesAbortMultipartUploadsTransitionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected R2BucketLifecycleRulesAbortMultipartUploadsTransitionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected R2BucketLifecycleRulesAbortMultipartUploadsTransitionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransitionCondition\"}}]")]
        public virtual void PutCondition(cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesAbortMultipartUploadsTransitionCondition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesAbortMultipartUploadsTransitionCondition)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCondition")]
        public virtual void ResetCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransitionConditionOutputReference\"}")]
        public virtual cloudflare.R2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransitionConditionOutputReference Condition
        {
            get => GetInstanceProperty<cloudflare.R2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransitionConditionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "conditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransitionCondition\"}]}}", isOptional: true)]
        public virtual object? ConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransition\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesAbortMultipartUploadsTransition cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesAbortMultipartUploadsTransition).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
