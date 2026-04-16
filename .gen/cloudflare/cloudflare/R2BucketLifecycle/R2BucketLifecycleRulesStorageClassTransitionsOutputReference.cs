using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketLifecycle
{
    [JsiiClass(nativeType: typeof(cloudflare.R2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitionsOutputReference), fullyQualifiedName: "cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class R2BucketLifecycleRulesStorageClassTransitionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public R2BucketLifecycleRulesStorageClassTransitionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected R2BucketLifecycleRulesStorageClassTransitionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected R2BucketLifecycleRulesStorageClassTransitionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitionsCondition\"}}]")]
        public virtual void PutCondition(cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesStorageClassTransitionsCondition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesStorageClassTransitionsCondition)}, new object[]{@value});
        }

        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitionsConditionOutputReference\"}")]
        public virtual cloudflare.R2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitionsConditionOutputReference Condition
        {
            get => GetInstanceProperty<cloudflare.R2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitionsConditionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "conditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitionsCondition\"}]}}", isOptional: true)]
        public virtual object? ConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageClassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageClassInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageClass
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitions\"}]}}", isOptional: true)]
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
                        case cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesStorageClassTransitions cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesStorageClassTransitions).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
