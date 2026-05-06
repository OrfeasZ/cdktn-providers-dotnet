using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ObjectstorageBucket
{
    [JsiiClass(nativeType: typeof(oci.ObjectstorageBucket.ObjectstorageBucketRetentionRulesOutputReference), fullyQualifiedName: "oci.objectstorageBucket.ObjectstorageBucketRetentionRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ObjectstorageBucketRetentionRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ObjectstorageBucketRetentionRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ObjectstorageBucketRetentionRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ObjectstorageBucketRetentionRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDuration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.objectstorageBucket.ObjectstorageBucketRetentionRulesDuration\"}}]")]
        public virtual void PutDuration(oci.ObjectstorageBucket.IObjectstorageBucketRetentionRulesDuration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ObjectstorageBucket.IObjectstorageBucketRetentionRulesDuration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDuration")]
        public virtual void ResetDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeRuleLocked")]
        public virtual void ResetTimeRuleLocked()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"oci.objectstorageBucket.ObjectstorageBucketRetentionRulesDurationOutputReference\"}")]
        public virtual oci.ObjectstorageBucket.ObjectstorageBucketRetentionRulesDurationOutputReference Duration
        {
            get => GetInstanceProperty<oci.ObjectstorageBucket.ObjectstorageBucketRetentionRulesDurationOutputReference>()!;
        }

        [JsiiProperty(name: "retentionRuleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RetentionRuleId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "durationInput", typeJson: "{\"fqn\":\"oci.objectstorageBucket.ObjectstorageBucketRetentionRulesDuration\"}", isOptional: true)]
        public virtual oci.ObjectstorageBucket.IObjectstorageBucketRetentionRulesDuration? DurationInput
        {
            get => GetInstanceProperty<oci.ObjectstorageBucket.IObjectstorageBucketRetentionRulesDuration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeRuleLockedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeRuleLockedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeRuleLocked", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeRuleLocked
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.objectstorageBucket.ObjectstorageBucketRetentionRules\"}]}}", isOptional: true)]
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
                        case oci.ObjectstorageBucket.IObjectstorageBucketRetentionRules cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ObjectstorageBucket.IObjectstorageBucketRetentionRules).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
