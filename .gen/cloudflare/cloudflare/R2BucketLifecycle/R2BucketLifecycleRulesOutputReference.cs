using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketLifecycle
{
    [JsiiClass(nativeType: typeof(cloudflare.R2BucketLifecycle.R2BucketLifecycleRulesOutputReference), fullyQualifiedName: "cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class R2BucketLifecycleRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public R2BucketLifecycleRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected R2BucketLifecycleRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected R2BucketLifecycleRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAbortMultipartUploadsTransition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransition\"}}]")]
        public virtual void PutAbortMultipartUploadsTransition(cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesAbortMultipartUploadsTransition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesAbortMultipartUploadsTransition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConditions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesConditions\"}}]")]
        public virtual void PutConditions(cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesConditions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesConditions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeleteObjectsTransition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesDeleteObjectsTransition\"}}]")]
        public virtual void PutDeleteObjectsTransition(cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesDeleteObjectsTransition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesDeleteObjectsTransition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageClassTransitions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStorageClassTransitions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesStorageClassTransitions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesStorageClassTransitions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesStorageClassTransitions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAbortMultipartUploadsTransition")]
        public virtual void ResetAbortMultipartUploadsTransition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteObjectsTransition")]
        public virtual void ResetDeleteObjectsTransition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageClassTransitions")]
        public virtual void ResetStorageClassTransitions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "abortMultipartUploadsTransition", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransitionOutputReference\"}")]
        public virtual cloudflare.R2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransitionOutputReference AbortMultipartUploadsTransition
        {
            get => GetInstanceProperty<cloudflare.R2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransitionOutputReference>()!;
        }

        [JsiiProperty(name: "conditions", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesConditionsOutputReference\"}")]
        public virtual cloudflare.R2BucketLifecycle.R2BucketLifecycleRulesConditionsOutputReference Conditions
        {
            get => GetInstanceProperty<cloudflare.R2BucketLifecycle.R2BucketLifecycleRulesConditionsOutputReference>()!;
        }

        [JsiiProperty(name: "deleteObjectsTransition", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesDeleteObjectsTransitionOutputReference\"}")]
        public virtual cloudflare.R2BucketLifecycle.R2BucketLifecycleRulesDeleteObjectsTransitionOutputReference DeleteObjectsTransition
        {
            get => GetInstanceProperty<cloudflare.R2BucketLifecycle.R2BucketLifecycleRulesDeleteObjectsTransitionOutputReference>()!;
        }

        [JsiiProperty(name: "storageClassTransitions", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitionsList\"}")]
        public virtual cloudflare.R2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitionsList StorageClassTransitions
        {
            get => GetInstanceProperty<cloudflare.R2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "abortMultipartUploadsTransitionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransition\"}]}}", isOptional: true)]
        public virtual object? AbortMultipartUploadsTransitionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "conditionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesConditions\"}]}}", isOptional: true)]
        public virtual object? ConditionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteObjectsTransitionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesDeleteObjectsTransition\"}]}}", isOptional: true)]
        public virtual object? DeleteObjectsTransitionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageClassTransitionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StorageClassTransitionsInput
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRules\"}]}}", isOptional: true)]
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
                        case cloudflare.R2BucketLifecycle.IR2BucketLifecycleRules cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.R2BucketLifecycle.IR2BucketLifecycleRules).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
