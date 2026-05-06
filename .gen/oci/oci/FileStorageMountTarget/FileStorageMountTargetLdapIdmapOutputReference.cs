using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageMountTarget
{
    [JsiiClass(nativeType: typeof(oci.FileStorageMountTarget.FileStorageMountTargetLdapIdmapOutputReference), fullyQualifiedName: "oci.fileStorageMountTarget.FileStorageMountTargetLdapIdmapOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FileStorageMountTargetLdapIdmapOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FileStorageMountTargetLdapIdmapOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FileStorageMountTargetLdapIdmapOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FileStorageMountTargetLdapIdmapOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCacheLifetimeSeconds")]
        public virtual void ResetCacheLifetimeSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCacheRefreshIntervalSeconds")]
        public virtual void ResetCacheRefreshIntervalSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroupSearchBase")]
        public virtual void ResetGroupSearchBase()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNegativeCacheLifetimeSeconds")]
        public virtual void ResetNegativeCacheLifetimeSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutboundConnector1Id")]
        public virtual void ResetOutboundConnector1Id()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutboundConnector2Id")]
        public virtual void ResetOutboundConnector2Id()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchemaType")]
        public virtual void ResetSchemaType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserSearchBase")]
        public virtual void ResetUserSearchBase()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheLifetimeSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CacheLifetimeSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheRefreshIntervalSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CacheRefreshIntervalSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupSearchBaseInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupSearchBaseInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "negativeCacheLifetimeSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NegativeCacheLifetimeSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outboundConnector1IdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutboundConnector1IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outboundConnector2IdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutboundConnector2IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchemaTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userSearchBaseInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserSearchBaseInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cacheLifetimeSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CacheLifetimeSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cacheRefreshIntervalSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CacheRefreshIntervalSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "groupSearchBase", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupSearchBase
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "negativeCacheLifetimeSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NegativeCacheLifetimeSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outboundConnector1Id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutboundConnector1Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outboundConnector2Id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutboundConnector2Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schemaType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchemaType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userSearchBase", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserSearchBase
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fileStorageMountTarget.FileStorageMountTargetLdapIdmap\"}", isOptional: true)]
        public virtual oci.FileStorageMountTarget.IFileStorageMountTargetLdapIdmap? InternalValue
        {
            get => GetInstanceProperty<oci.FileStorageMountTarget.IFileStorageMountTargetLdapIdmap?>();
            set => SetInstanceProperty(value);
        }
    }
}
