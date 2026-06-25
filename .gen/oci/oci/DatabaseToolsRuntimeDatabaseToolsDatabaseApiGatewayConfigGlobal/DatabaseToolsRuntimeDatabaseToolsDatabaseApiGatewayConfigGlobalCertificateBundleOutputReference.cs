using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal
{
    [JsiiClass(nativeType: typeof(oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleOutputReference), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCertificatePrivateKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKey\"}}]")]
        public virtual void PutCertificatePrivateKey(oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCertificatePublic", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePublic\"}}]")]
        public virtual void PutCertificatePublic(oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePublic @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePublic)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCertificatePrivateKey")]
        public virtual void ResetCertificatePrivateKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificatePublic")]
        public virtual void ResetCertificatePublic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "certificatePrivateKey", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKeyOutputReference\"}")]
        public virtual oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKeyOutputReference CertificatePrivateKey
        {
            get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKeyOutputReference>()!;
        }

        [JsiiProperty(name: "certificatePublic", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePublicOutputReference\"}")]
        public virtual oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePublicOutputReference CertificatePublic
        {
            get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePublicOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificatePrivateKeyInput", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKey\"}", isOptional: true)]
        public virtual oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKey? CertificatePrivateKeyInput
        {
            get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKey?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificatePublicInput", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePublic\"}", isOptional: true)]
        public virtual oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePublic? CertificatePublicInput
        {
            get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePublic?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundle\"}", isOptional: true)]
        public virtual oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundle? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundle?>();
            set => SetInstanceProperty(value);
        }
    }
}
