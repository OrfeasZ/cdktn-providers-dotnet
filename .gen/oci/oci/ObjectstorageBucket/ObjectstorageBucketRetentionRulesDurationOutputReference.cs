using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ObjectstorageBucket
{
    [JsiiClass(nativeType: typeof(oci.ObjectstorageBucket.ObjectstorageBucketRetentionRulesDurationOutputReference), fullyQualifiedName: "oci.objectstorageBucket.ObjectstorageBucketRetentionRulesDurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ObjectstorageBucketRetentionRulesDurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ObjectstorageBucketRetentionRulesDurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ObjectstorageBucketRetentionRulesDurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ObjectstorageBucketRetentionRulesDurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeAmountInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeAmountInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "timeAmount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAmount
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUnit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.objectstorageBucket.ObjectstorageBucketRetentionRulesDuration\"}", isOptional: true)]
        public virtual oci.ObjectstorageBucket.IObjectstorageBucketRetentionRulesDuration? InternalValue
        {
            get => GetInstanceProperty<oci.ObjectstorageBucket.IObjectstorageBucketRetentionRulesDuration?>();
            set => SetInstanceProperty(value);
        }
    }
}
