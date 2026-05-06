using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousVmClusterSslCertificateManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ssl_certificate_management oci_database_autonomous_vm_cluster_ssl_certificate_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseAutonomousVmClusterSslCertificateManagement.DatabaseAutonomousVmClusterSslCertificateManagement), fullyQualifiedName: "oci.databaseAutonomousVmClusterSslCertificateManagement.DatabaseAutonomousVmClusterSslCertificateManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseAutonomousVmClusterSslCertificateManagement.DatabaseAutonomousVmClusterSslCertificateManagementConfig\"}}]")]
    public class DatabaseAutonomousVmClusterSslCertificateManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ssl_certificate_management oci_database_autonomous_vm_cluster_ssl_certificate_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseAutonomousVmClusterSslCertificateManagement(Constructs.Construct scope, string id, oci.DatabaseAutonomousVmClusterSslCertificateManagement.IDatabaseAutonomousVmClusterSslCertificateManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseAutonomousVmClusterSslCertificateManagement.IDatabaseAutonomousVmClusterSslCertificateManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseAutonomousVmClusterSslCertificateManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseAutonomousVmClusterSslCertificateManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseAutonomousVmClusterSslCertificateManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseAutonomousVmClusterSslCertificateManagement to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseAutonomousVmClusterSslCertificateManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseAutonomousVmClusterSslCertificateManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseAutonomousVmClusterSslCertificateManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ssl_certificate_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseAutonomousVmClusterSslCertificateManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseAutonomousVmClusterSslCertificateManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseAutonomousVmClusterSslCertificateManagement.DatabaseAutonomousVmClusterSslCertificateManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseAutonomousVmClusterSslCertificateManagement.DatabaseAutonomousVmClusterSslCertificateManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseAutonomousVmClusterSslCertificateManagement.IDatabaseAutonomousVmClusterSslCertificateManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseAutonomousVmClusterSslCertificateManagement.IDatabaseAutonomousVmClusterSslCertificateManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCaBundleId")]
        public virtual void ResetCaBundleId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateAuthorityId")]
        public virtual void ResetCertificateAuthorityId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateId")]
        public virtual void ResetCertificateId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DatabaseAutonomousVmClusterSslCertificateManagement.DatabaseAutonomousVmClusterSslCertificateManagement))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseAutonomousVmClusterSslCertificateManagement.DatabaseAutonomousVmClusterSslCertificateManagementTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseAutonomousVmClusterSslCertificateManagement.DatabaseAutonomousVmClusterSslCertificateManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseAutonomousVmClusterSslCertificateManagement.DatabaseAutonomousVmClusterSslCertificateManagementTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autonomousVmClusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutonomousVmClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "caBundleIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CaBundleIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateAuthorityIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateAuthorityIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateGenerationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateGenerationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseAutonomousVmClusterSslCertificateManagement.DatabaseAutonomousVmClusterSslCertificateManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "autonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousVmClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "caBundleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CaBundleId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateAuthorityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateAuthorityId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateGenerationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateGenerationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
