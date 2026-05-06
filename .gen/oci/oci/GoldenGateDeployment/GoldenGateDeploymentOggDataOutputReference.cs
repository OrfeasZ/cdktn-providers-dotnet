using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateDeployment
{
    [JsiiClass(nativeType: typeof(oci.GoldenGateDeployment.GoldenGateDeploymentOggDataOutputReference), fullyQualifiedName: "oci.goldenGateDeployment.GoldenGateDeploymentOggDataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GoldenGateDeploymentOggDataOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GoldenGateDeploymentOggDataOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GoldenGateDeploymentOggDataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GoldenGateDeploymentOggDataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGroupToRolesMapping", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.goldenGateDeployment.GoldenGateDeploymentOggDataGroupToRolesMapping\"}}]")]
        public virtual void PutGroupToRolesMapping(oci.GoldenGateDeployment.IGoldenGateDeploymentOggDataGroupToRolesMapping @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GoldenGateDeployment.IGoldenGateDeploymentOggDataGroupToRolesMapping)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdminPassword")]
        public virtual void ResetAdminPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdminUsername")]
        public virtual void ResetAdminUsername()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificate")]
        public virtual void ResetCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCredentialStore")]
        public virtual void ResetCredentialStore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroupToRolesMapping")]
        public virtual void ResetGroupToRolesMapping()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentityDomainId")]
        public virtual void ResetIdentityDomainId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKey")]
        public virtual void ResetKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOggVersion")]
        public virtual void ResetOggVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPasswordSecretId")]
        public virtual void ResetPasswordSecretId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "groupToRolesMapping", typeJson: "{\"fqn\":\"oci.goldenGateDeployment.GoldenGateDeploymentOggDataGroupToRolesMappingOutputReference\"}")]
        public virtual oci.GoldenGateDeployment.GoldenGateDeploymentOggDataGroupToRolesMappingOutputReference GroupToRolesMapping
        {
            get => GetInstanceProperty<oci.GoldenGateDeployment.GoldenGateDeploymentOggDataGroupToRolesMappingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminUsernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminUsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialStoreInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CredentialStoreInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeploymentNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupToRolesMappingInput", typeJson: "{\"fqn\":\"oci.goldenGateDeployment.GoldenGateDeploymentOggDataGroupToRolesMapping\"}", isOptional: true)]
        public virtual oci.GoldenGateDeployment.IGoldenGateDeploymentOggDataGroupToRolesMapping? GroupToRolesMappingInput
        {
            get => GetInstanceProperty<oci.GoldenGateDeployment.IGoldenGateDeploymentOggDataGroupToRolesMapping?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityDomainIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentityDomainIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oggVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OggVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordSecretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordSecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminUsername
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Certificate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "credentialStore", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CredentialStore
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "identityDomainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityDomainId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "oggVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OggVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordSecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.goldenGateDeployment.GoldenGateDeploymentOggData\"}", isOptional: true)]
        public virtual oci.GoldenGateDeployment.IGoldenGateDeploymentOggData? InternalValue
        {
            get => GetInstanceProperty<oci.GoldenGateDeployment.IGoldenGateDeploymentOggData?>();
            set => SetInstanceProperty(value);
        }
    }
}
