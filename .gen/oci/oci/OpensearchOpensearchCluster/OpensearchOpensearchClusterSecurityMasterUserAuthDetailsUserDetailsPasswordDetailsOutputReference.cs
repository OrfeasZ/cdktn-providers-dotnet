using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    [JsiiClass(nativeType: typeof(oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetailsOutputReference), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPlainPassword")]
        public virtual void ResetPlainPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVaultSecretId")]
        public virtual void ResetVaultSecretId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "plainPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlainPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vaultSecretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VaultSecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "plainPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlainPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vaultSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultSecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetails\"}", isOptional: true)]
        public virtual oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetails? InternalValue
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsPasswordDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
