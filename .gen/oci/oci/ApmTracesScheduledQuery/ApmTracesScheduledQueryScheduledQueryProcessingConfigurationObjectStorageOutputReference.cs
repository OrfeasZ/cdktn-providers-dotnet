using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmTracesScheduledQuery
{
    [JsiiClass(nativeType: typeof(oci.ApmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorageOutputReference), fullyQualifiedName: "oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorageOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorageOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorageOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorageOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorageOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBucket")]
        public virtual void ResetBucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNameSpace")]
        public virtual void ResetNameSpace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectNamePrefix")]
        public virtual void ResetObjectNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameSpaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameSpaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectNamePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectNamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nameSpace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameSpace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectNamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectNamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage\"}", isOptional: true)]
        public virtual oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage? InternalValue
        {
            get => GetInstanceProperty<oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage?>();
            set => SetInstanceProperty(value);
        }
    }
}
