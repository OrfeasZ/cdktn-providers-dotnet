using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousVmClusterOrdsCertificateManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousVmClusterOrdsCertificateManagementConfig), fullyQualifiedName: "oci.databaseAutonomousVmClusterOrdsCertificateManagement.DatabaseAutonomousVmClusterOrdsCertificateManagementConfig")]
    public interface IDatabaseAutonomousVmClusterOrdsCertificateManagementConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ords_certificate_management#autonomous_vm_cluster_id DatabaseAutonomousVmClusterOrdsCertificateManagement#autonomous_vm_cluster_id}.</summary>
        [JsiiProperty(name: "autonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        string AutonomousVmClusterId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ords_certificate_management#certificate_generation_type DatabaseAutonomousVmClusterOrdsCertificateManagement#certificate_generation_type}.</summary>
        [JsiiProperty(name: "certificateGenerationType", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateGenerationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ords_certificate_management#ca_bundle_id DatabaseAutonomousVmClusterOrdsCertificateManagement#ca_bundle_id}.</summary>
        [JsiiProperty(name: "caBundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaBundleId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ords_certificate_management#certificate_authority_id DatabaseAutonomousVmClusterOrdsCertificateManagement#certificate_authority_id}.</summary>
        [JsiiProperty(name: "certificateAuthorityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateAuthorityId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ords_certificate_management#certificate_id DatabaseAutonomousVmClusterOrdsCertificateManagement#certificate_id}.</summary>
        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ords_certificate_management#id DatabaseAutonomousVmClusterOrdsCertificateManagement#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ords_certificate_management#timeouts DatabaseAutonomousVmClusterOrdsCertificateManagement#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseAutonomousVmClusterOrdsCertificateManagement.DatabaseAutonomousVmClusterOrdsCertificateManagementTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseAutonomousVmClusterOrdsCertificateManagement.IDatabaseAutonomousVmClusterOrdsCertificateManagementTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousVmClusterOrdsCertificateManagementConfig), fullyQualifiedName: "oci.databaseAutonomousVmClusterOrdsCertificateManagement.DatabaseAutonomousVmClusterOrdsCertificateManagementConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousVmClusterOrdsCertificateManagement.IDatabaseAutonomousVmClusterOrdsCertificateManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ords_certificate_management#autonomous_vm_cluster_id DatabaseAutonomousVmClusterOrdsCertificateManagement#autonomous_vm_cluster_id}.</summary>
            [JsiiProperty(name: "autonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
            public string AutonomousVmClusterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ords_certificate_management#certificate_generation_type DatabaseAutonomousVmClusterOrdsCertificateManagement#certificate_generation_type}.</summary>
            [JsiiProperty(name: "certificateGenerationType", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateGenerationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ords_certificate_management#ca_bundle_id DatabaseAutonomousVmClusterOrdsCertificateManagement#ca_bundle_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "caBundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaBundleId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ords_certificate_management#certificate_authority_id DatabaseAutonomousVmClusterOrdsCertificateManagement#certificate_authority_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateAuthorityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateAuthorityId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ords_certificate_management#certificate_id DatabaseAutonomousVmClusterOrdsCertificateManagement#certificate_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ords_certificate_management#id DatabaseAutonomousVmClusterOrdsCertificateManagement#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster_ords_certificate_management#timeouts DatabaseAutonomousVmClusterOrdsCertificateManagement#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseAutonomousVmClusterOrdsCertificateManagement.DatabaseAutonomousVmClusterOrdsCertificateManagementTimeouts\"}", isOptional: true)]
            public oci.DatabaseAutonomousVmClusterOrdsCertificateManagement.IDatabaseAutonomousVmClusterOrdsCertificateManagementTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseAutonomousVmClusterOrdsCertificateManagement.IDatabaseAutonomousVmClusterOrdsCertificateManagementTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
