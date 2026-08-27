using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.difStack.DifStackAdb")]
    public class DifStackAdb : oci.DifStack.IDifStackAdb
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#admin_password_id DifStack#admin_password_id}.</summary>
        [JsiiProperty(name: "adminPasswordId", typeJson: "{\"primitive\":\"string\"}")]
        public string AdminPasswordId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#data_storage_size_in_tbs DifStack#data_storage_size_in_tbs}.</summary>
        [JsiiProperty(name: "dataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public double DataStorageSizeInTbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#db_version DifStack#db_version}.</summary>
        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string DbVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#db_workload DifStack#db_workload}.</summary>
        [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}")]
        public string DbWorkload
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#ecpu DifStack#ecpu}.</summary>
        [JsiiProperty(name: "ecpu", typeJson: "{\"primitive\":\"number\"}")]
        public double Ecpu
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#instance_id DifStack#instance_id}.</summary>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#artifact_object_storage_path DifStack#artifact_object_storage_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "artifactObjectStoragePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ArtifactObjectStoragePath
        {
            get;
            set;
        }

        private object? _dbCredentials;

        /// <summary>db_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#db_credentials DifStack#db_credentials}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackAdbDbCredentials" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbCredentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackAdbDbCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DbCredentials
        {
            get => _dbCredentials;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DifStack.IDifStackAdbDbCredentials[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackAdbDbCredentials).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dbCredentials = value;
            }
        }

        private object? _isMtlsConnectionRequired;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#is_mtls_connection_required DifStack#is_mtls_connection_required}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isMtlsConnectionRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsMtlsConnectionRequired
        {
            get => _isMtlsConnectionRequired;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isMtlsConnectionRequired = value;
            }
        }

        private object? _isPublic;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#is_public DifStack#is_public}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isPublic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsPublic
        {
            get => _isPublic;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isPublic = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#subnet_id DifStack#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#tools_public_access DifStack#tools_public_access}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "toolsPublicAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ToolsPublicAccess
        {
            get;
            set;
        }
    }
}
