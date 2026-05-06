using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceOperationCertificateManagementsManagement
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstanceOperationCertificateManagementsManagementConfig), fullyQualifiedName: "oci.bdsBdsInstanceOperationCertificateManagementsManagement.BdsBdsInstanceOperationCertificateManagementsManagementConfig")]
    public interface IBdsBdsInstanceOperationCertificateManagementsManagementConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#bds_instance_id BdsBdsInstanceOperationCertificateManagementsManagement#bds_instance_id}.</summary>
        [JsiiProperty(name: "bdsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        string BdsInstanceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#cluster_admin_password BdsBdsInstanceOperationCertificateManagementsManagement#cluster_admin_password}.</summary>
        [JsiiProperty(name: "clusterAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterAdminPassword
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#enable_operation_certificate_management BdsBdsInstanceOperationCertificateManagementsManagement#enable_operation_certificate_management}.</summary>
        [JsiiProperty(name: "enableOperationCertificateManagement", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object EnableOperationCertificateManagement
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#renew_operation_certificate_management BdsBdsInstanceOperationCertificateManagementsManagement#renew_operation_certificate_management}.</summary>
        [JsiiProperty(name: "renewOperationCertificateManagement", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object RenewOperationCertificateManagement
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#services BdsBdsInstanceOperationCertificateManagementsManagement#services}.</summary>
        [JsiiProperty(name: "services", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Services
        {
            get;
        }

        /// <summary>host_cert_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#host_cert_details BdsBdsInstanceOperationCertificateManagementsManagement#host_cert_details}
        /// </remarks>
        [JsiiProperty(name: "hostCertDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.bdsBdsInstanceOperationCertificateManagementsManagement.BdsBdsInstanceOperationCertificateManagementsManagementHostCertDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HostCertDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#id BdsBdsInstanceOperationCertificateManagementsManagement#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#root_certificate BdsBdsInstanceOperationCertificateManagementsManagement#root_certificate}.</summary>
        [JsiiProperty(name: "rootCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RootCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#server_key_password BdsBdsInstanceOperationCertificateManagementsManagement#server_key_password}.</summary>
        [JsiiProperty(name: "serverKeyPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServerKeyPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#timeouts BdsBdsInstanceOperationCertificateManagementsManagement#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceOperationCertificateManagementsManagement.BdsBdsInstanceOperationCertificateManagementsManagementTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.BdsBdsInstanceOperationCertificateManagementsManagement.IBdsBdsInstanceOperationCertificateManagementsManagementTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstanceOperationCertificateManagementsManagementConfig), fullyQualifiedName: "oci.bdsBdsInstanceOperationCertificateManagementsManagement.BdsBdsInstanceOperationCertificateManagementsManagementConfig")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstanceOperationCertificateManagementsManagement.IBdsBdsInstanceOperationCertificateManagementsManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#bds_instance_id BdsBdsInstanceOperationCertificateManagementsManagement#bds_instance_id}.</summary>
            [JsiiProperty(name: "bdsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string BdsInstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#cluster_admin_password BdsBdsInstanceOperationCertificateManagementsManagement#cluster_admin_password}.</summary>
            [JsiiProperty(name: "clusterAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterAdminPassword
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#enable_operation_certificate_management BdsBdsInstanceOperationCertificateManagementsManagement#enable_operation_certificate_management}.</summary>
            [JsiiProperty(name: "enableOperationCertificateManagement", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object EnableOperationCertificateManagement
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#renew_operation_certificate_management BdsBdsInstanceOperationCertificateManagementsManagement#renew_operation_certificate_management}.</summary>
            [JsiiProperty(name: "renewOperationCertificateManagement", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object RenewOperationCertificateManagement
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#services BdsBdsInstanceOperationCertificateManagementsManagement#services}.</summary>
            [JsiiProperty(name: "services", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Services
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>host_cert_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#host_cert_details BdsBdsInstanceOperationCertificateManagementsManagement#host_cert_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostCertDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.bdsBdsInstanceOperationCertificateManagementsManagement.BdsBdsInstanceOperationCertificateManagementsManagementHostCertDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HostCertDetails
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#id BdsBdsInstanceOperationCertificateManagementsManagement#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#root_certificate BdsBdsInstanceOperationCertificateManagementsManagement#root_certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rootCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RootCertificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#server_key_password BdsBdsInstanceOperationCertificateManagementsManagement#server_key_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serverKeyPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServerKeyPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#timeouts BdsBdsInstanceOperationCertificateManagementsManagement#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.bdsBdsInstanceOperationCertificateManagementsManagement.BdsBdsInstanceOperationCertificateManagementsManagementTimeouts\"}", isOptional: true)]
            public oci.BdsBdsInstanceOperationCertificateManagementsManagement.IBdsBdsInstanceOperationCertificateManagementsManagementTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.BdsBdsInstanceOperationCertificateManagementsManagement.IBdsBdsInstanceOperationCertificateManagementsManagementTimeouts?>();
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
