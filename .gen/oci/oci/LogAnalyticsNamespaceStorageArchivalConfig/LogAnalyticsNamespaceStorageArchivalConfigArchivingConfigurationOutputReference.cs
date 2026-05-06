using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceStorageArchivalConfig
{
    [JsiiClass(nativeType: typeof(oci.LogAnalyticsNamespaceStorageArchivalConfig.LogAnalyticsNamespaceStorageArchivalConfigArchivingConfigurationOutputReference), fullyQualifiedName: "oci.logAnalyticsNamespaceStorageArchivalConfig.LogAnalyticsNamespaceStorageArchivalConfigArchivingConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LogAnalyticsNamespaceStorageArchivalConfigArchivingConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LogAnalyticsNamespaceStorageArchivalConfigArchivingConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LogAnalyticsNamespaceStorageArchivalConfigArchivingConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LogAnalyticsNamespaceStorageArchivalConfigArchivingConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetActiveStorageDuration")]
        public virtual void ResetActiveStorageDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetArchivalStorageDuration")]
        public virtual void ResetArchivalStorageDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeStorageDurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActiveStorageDurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "archivalStorageDurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArchivalStorageDurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "activeStorageDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActiveStorageDuration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "archivalStorageDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArchivalStorageDuration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceStorageArchivalConfig.LogAnalyticsNamespaceStorageArchivalConfigArchivingConfiguration\"}", isOptional: true)]
        public virtual oci.LogAnalyticsNamespaceStorageArchivalConfig.ILogAnalyticsNamespaceStorageArchivalConfigArchivingConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.LogAnalyticsNamespaceStorageArchivalConfig.ILogAnalyticsNamespaceStorageArchivalConfigArchivingConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
