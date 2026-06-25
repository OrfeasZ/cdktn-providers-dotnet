using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal
{
    [JsiiClass(nativeType: typeof(oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKeyOutputReference), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKeyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKeyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKeyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKeyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKeyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFormat")]
        public virtual void ResetFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPath")]
        public virtual void ResetPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "formatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Format
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKey\"}", isOptional: true)]
        public virtual oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKey? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKey?>();
            set => SetInstanceProperty(value);
        }
    }
}
