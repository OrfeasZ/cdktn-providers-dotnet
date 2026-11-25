using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateConnection
{
    [JsiiClass(nativeType: typeof(oci.GoldenGateConnection.GoldenGateConnectionWarehouseStorageOutputReference), fullyQualifiedName: "oci.goldenGateConnection.GoldenGateConnectionWarehouseStorageOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GoldenGateConnectionWarehouseStorageOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GoldenGateConnectionWarehouseStorageOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GoldenGateConnectionWarehouseStorageOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GoldenGateConnectionWarehouseStorageOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAccessKeyId")]
        public virtual void ResetAccessKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAccountKey")]
        public virtual void ResetAccountKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAccountKeySecretId")]
        public virtual void ResetAccountKeySecretId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAccountName")]
        public virtual void ResetAccountName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndpointUrl")]
        public virtual void ResetEndpointUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamespace")]
        public virtual void ResetNamespace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecretAccessKey")]
        public virtual void ResetSecretAccessKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecretAccessKeySecretId")]
        public virtual void ResetSecretAccessKeySecretId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrustStore")]
        public virtual void ResetTrustStore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrustStoreSecretId")]
        public virtual void ResetTrustStoreSecretId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountKeySecretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountKeySecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretAccessKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretAccessKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretAccessKeySecretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretAccessKeySecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trustStoreInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrustStoreInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trustStoreSecretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrustStoreSecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accountKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accountKeySecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountKeySecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endpointUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secretAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretAccessKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secretAccessKeySecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretAccessKeySecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trustStore", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrustStore
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trustStoreSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrustStoreSecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.goldenGateConnection.GoldenGateConnectionWarehouseStorage\"}", isOptional: true)]
        public virtual oci.GoldenGateConnection.IGoldenGateConnectionWarehouseStorage? InternalValue
        {
            get => GetInstanceProperty<oci.GoldenGateConnection.IGoldenGateConnectionWarehouseStorage?>();
            set => SetInstanceProperty(value);
        }
    }
}
