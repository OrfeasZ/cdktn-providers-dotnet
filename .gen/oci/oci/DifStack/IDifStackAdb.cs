using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiInterface(nativeType: typeof(IDifStackAdb), fullyQualifiedName: "oci.difStack.DifStackAdb")]
    public interface IDifStackAdb
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#admin_password_id DifStack#admin_password_id}.</summary>
        [JsiiProperty(name: "adminPasswordId", typeJson: "{\"primitive\":\"string\"}")]
        string AdminPasswordId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#data_storage_size_in_tbs DifStack#data_storage_size_in_tbs}.</summary>
        [JsiiProperty(name: "dataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        double DataStorageSizeInTbs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#db_version DifStack#db_version}.</summary>
        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}")]
        string DbVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#db_workload DifStack#db_workload}.</summary>
        [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}")]
        string DbWorkload
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#ecpu DifStack#ecpu}.</summary>
        [JsiiProperty(name: "ecpu", typeJson: "{\"primitive\":\"number\"}")]
        double Ecpu
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#instance_id DifStack#instance_id}.</summary>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#artifact_object_storage_path DifStack#artifact_object_storage_path}.</summary>
        [JsiiProperty(name: "artifactObjectStoragePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ArtifactObjectStoragePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>db_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#db_credentials DifStack#db_credentials}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackAdbDbCredentials" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "dbCredentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackAdbDbCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DbCredentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#is_mtls_connection_required DifStack#is_mtls_connection_required}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isMtlsConnectionRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMtlsConnectionRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#is_public DifStack#is_public}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isPublic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsPublic
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#subnet_id DifStack#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#tools_public_access DifStack#tools_public_access}.</summary>
        [JsiiProperty(name: "toolsPublicAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ToolsPublicAccess
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDifStackAdb), fullyQualifiedName: "oci.difStack.DifStackAdb")]
        internal sealed class _Proxy : DeputyBase, oci.DifStack.IDifStackAdb
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#admin_password_id DifStack#admin_password_id}.</summary>
            [JsiiProperty(name: "adminPasswordId", typeJson: "{\"primitive\":\"string\"}")]
            public string AdminPasswordId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#data_storage_size_in_tbs DifStack#data_storage_size_in_tbs}.</summary>
            [JsiiProperty(name: "dataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
            public double DataStorageSizeInTbs
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#db_version DifStack#db_version}.</summary>
            [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string DbVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#db_workload DifStack#db_workload}.</summary>
            [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}")]
            public string DbWorkload
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#ecpu DifStack#ecpu}.</summary>
            [JsiiProperty(name: "ecpu", typeJson: "{\"primitive\":\"number\"}")]
            public double Ecpu
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#instance_id DifStack#instance_id}.</summary>
            [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#artifact_object_storage_path DifStack#artifact_object_storage_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "artifactObjectStoragePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ArtifactObjectStoragePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>db_credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#db_credentials DifStack#db_credentials}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackAdbDbCredentials" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbCredentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackAdbDbCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DbCredentials
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#is_mtls_connection_required DifStack#is_mtls_connection_required}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isMtlsConnectionRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsMtlsConnectionRequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#is_public DifStack#is_public}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isPublic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsPublic
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#subnet_id DifStack#subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/dif_stack#tools_public_access DifStack#tools_public_access}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "toolsPublicAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ToolsPublicAccess
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
