using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.SpacesBucket
{
    [JsiiClass(nativeType: typeof(digitalocean.SpacesBucket.SpacesBucketLifecycleRuleOutputReference), fullyQualifiedName: "digitalocean.spacesBucket.SpacesBucketLifecycleRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SpacesBucketLifecycleRuleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public SpacesBucketLifecycleRuleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected SpacesBucketLifecycleRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpacesBucketLifecycleRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExpiration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.spacesBucket.SpacesBucketLifecycleRuleExpiration\"}}]")]
        public virtual void PutExpiration(digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleExpiration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleExpiration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNoncurrentVersionExpiration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.spacesBucket.SpacesBucketLifecycleRuleNoncurrentVersionExpiration\"}}]")]
        public virtual void PutNoncurrentVersionExpiration(digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleNoncurrentVersionExpiration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleNoncurrentVersionExpiration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAbortIncompleteMultipartUploadDays")]
        public virtual void ResetAbortIncompleteMultipartUploadDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpiration")]
        public virtual void ResetExpiration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNoncurrentVersionExpiration")]
        public virtual void ResetNoncurrentVersionExpiration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrefix")]
        public virtual void ResetPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"digitalocean.spacesBucket.SpacesBucketLifecycleRuleExpirationOutputReference\"}")]
        public virtual digitalocean.SpacesBucket.SpacesBucketLifecycleRuleExpirationOutputReference Expiration
        {
            get => GetInstanceProperty<digitalocean.SpacesBucket.SpacesBucketLifecycleRuleExpirationOutputReference>()!;
        }

        [JsiiProperty(name: "noncurrentVersionExpiration", typeJson: "{\"fqn\":\"digitalocean.spacesBucket.SpacesBucketLifecycleRuleNoncurrentVersionExpirationOutputReference\"}")]
        public virtual digitalocean.SpacesBucket.SpacesBucketLifecycleRuleNoncurrentVersionExpirationOutputReference NoncurrentVersionExpiration
        {
            get => GetInstanceProperty<digitalocean.SpacesBucket.SpacesBucketLifecycleRuleNoncurrentVersionExpirationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "abortIncompleteMultipartUploadDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AbortIncompleteMultipartUploadDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expirationInput", typeJson: "{\"fqn\":\"digitalocean.spacesBucket.SpacesBucketLifecycleRuleExpiration\"}", isOptional: true)]
        public virtual digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleExpiration? ExpirationInput
        {
            get => GetInstanceProperty<digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleExpiration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "noncurrentVersionExpirationInput", typeJson: "{\"fqn\":\"digitalocean.spacesBucket.SpacesBucketLifecycleRuleNoncurrentVersionExpiration\"}", isOptional: true)]
        public virtual digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleNoncurrentVersionExpiration? NoncurrentVersionExpirationInput
        {
            get => GetInstanceProperty<digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleNoncurrentVersionExpiration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "abortIncompleteMultipartUploadDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AbortIncompleteMultipartUploadDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
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

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"digitalocean.spacesBucket.SpacesBucketLifecycleRule\"}]}}", isOptional: true)]
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
                        case digitalocean.SpacesBucket.ISpacesBucketLifecycleRule cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.SpacesBucket.ISpacesBucketLifecycleRule).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
