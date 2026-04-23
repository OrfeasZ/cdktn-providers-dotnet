using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticsearchDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticsearchDomain.ElasticsearchDomainConfig")]
    public class ElasticsearchDomainConfig : aws.ElasticsearchDomain.IElasticsearchDomainConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#domain_name ElasticsearchDomain#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#access_policies ElasticsearchDomain#access_policies}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessPolicies", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessPolicies
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#advanced_options ElasticsearchDomain#advanced_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "advancedOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? AdvancedOptions
        {
            get;
            set;
        }

        /// <summary>advanced_security_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#advanced_security_options ElasticsearchDomain#advanced_security_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "advancedSecurityOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainAdvancedSecurityOptions\"}", isOptional: true)]
        public aws.ElasticsearchDomain.IElasticsearchDomainAdvancedSecurityOptions? AdvancedSecurityOptions
        {
            get;
            set;
        }

        /// <summary>auto_tune_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#auto_tune_options ElasticsearchDomain#auto_tune_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoTuneOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainAutoTuneOptions\"}", isOptional: true)]
        public aws.ElasticsearchDomain.IElasticsearchDomainAutoTuneOptions? AutoTuneOptions
        {
            get;
            set;
        }

        /// <summary>cluster_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#cluster_config ElasticsearchDomain#cluster_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainClusterConfig\"}", isOptional: true)]
        public aws.ElasticsearchDomain.IElasticsearchDomainClusterConfig? ClusterConfig
        {
            get;
            set;
        }

        /// <summary>cognito_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#cognito_options ElasticsearchDomain#cognito_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cognitoOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainCognitoOptions\"}", isOptional: true)]
        public aws.ElasticsearchDomain.IElasticsearchDomainCognitoOptions? CognitoOptions
        {
            get;
            set;
        }

        /// <summary>domain_endpoint_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#domain_endpoint_options ElasticsearchDomain#domain_endpoint_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "domainEndpointOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainDomainEndpointOptions\"}", isOptional: true)]
        public aws.ElasticsearchDomain.IElasticsearchDomainDomainEndpointOptions? DomainEndpointOptions
        {
            get;
            set;
        }

        /// <summary>ebs_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#ebs_options ElasticsearchDomain#ebs_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ebsOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainEbsOptions\"}", isOptional: true)]
        public aws.ElasticsearchDomain.IElasticsearchDomainEbsOptions? EbsOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#elasticsearch_version ElasticsearchDomain#elasticsearch_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ElasticsearchVersion
        {
            get;
            set;
        }

        /// <summary>encrypt_at_rest block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#encrypt_at_rest ElasticsearchDomain#encrypt_at_rest}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptAtRest", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainEncryptAtRest\"}", isOptional: true)]
        public aws.ElasticsearchDomain.IElasticsearchDomainEncryptAtRest? EncryptAtRest
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#id ElasticsearchDomain#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        private object? _logPublishingOptions;

        /// <summary>log_publishing_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#log_publishing_options ElasticsearchDomain#log_publishing_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainLogPublishingOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LogPublishingOptions
        {
            get => _logPublishingOptions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ElasticsearchDomain.IElasticsearchDomainLogPublishingOptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ElasticsearchDomain.IElasticsearchDomainLogPublishingOptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logPublishingOptions = value;
            }
        }

        /// <summary>node_to_node_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#node_to_node_encryption ElasticsearchDomain#node_to_node_encryption}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeToNodeEncryption", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainNodeToNodeEncryption\"}", isOptional: true)]
        public aws.ElasticsearchDomain.IElasticsearchDomainNodeToNodeEncryption? NodeToNodeEncryption
        {
            get;
            set;
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#region ElasticsearchDomain#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>snapshot_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#snapshot_options ElasticsearchDomain#snapshot_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainSnapshotOptions\"}", isOptional: true)]
        public aws.ElasticsearchDomain.IElasticsearchDomainSnapshotOptions? SnapshotOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#tags ElasticsearchDomain#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#tags_all ElasticsearchDomain#tags_all}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#timeouts ElasticsearchDomain#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainTimeouts\"}", isOptional: true)]
        public aws.ElasticsearchDomain.IElasticsearchDomainTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>vpc_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/elasticsearch_domain#vpc_options ElasticsearchDomain#vpc_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcOptions", typeJson: "{\"fqn\":\"aws.elasticsearchDomain.ElasticsearchDomainVpcOptions\"}", isOptional: true)]
        public aws.ElasticsearchDomain.IElasticsearchDomainVpcOptions? VpcOptions
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
