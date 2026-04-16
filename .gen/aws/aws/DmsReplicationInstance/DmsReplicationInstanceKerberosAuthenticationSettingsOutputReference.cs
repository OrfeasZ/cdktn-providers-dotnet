using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsReplicationInstance
{
    [JsiiClass(nativeType: typeof(aws.DmsReplicationInstance.DmsReplicationInstanceKerberosAuthenticationSettingsOutputReference), fullyQualifiedName: "aws.dmsReplicationInstance.DmsReplicationInstanceKerberosAuthenticationSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DmsReplicationInstanceKerberosAuthenticationSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DmsReplicationInstanceKerberosAuthenticationSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DmsReplicationInstanceKerberosAuthenticationSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsReplicationInstanceKerberosAuthenticationSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyCacheSecretIamArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyCacheSecretIamArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyCacheSecretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyCacheSecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "krb5FileContentsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Krb5FileContentsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "keyCacheSecretIamArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyCacheSecretIamArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyCacheSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyCacheSecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "krb5FileContents", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Krb5FileContents
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dmsReplicationInstance.DmsReplicationInstanceKerberosAuthenticationSettings\"}", isOptional: true)]
        public virtual aws.DmsReplicationInstance.IDmsReplicationInstanceKerberosAuthenticationSettings? InternalValue
        {
            get => GetInstanceProperty<aws.DmsReplicationInstance.IDmsReplicationInstanceKerberosAuthenticationSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
