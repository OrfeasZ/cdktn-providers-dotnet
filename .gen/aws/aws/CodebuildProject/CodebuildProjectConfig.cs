using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codebuildProject.CodebuildProjectConfig")]
    public class CodebuildProjectConfig : aws.CodebuildProject.ICodebuildProjectConfig
    {
        /// <summary>artifacts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#artifacts CodebuildProject#artifacts}
        /// </remarks>
        [JsiiProperty(name: "artifacts", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectArtifacts\"}")]
        public aws.CodebuildProject.ICodebuildProjectArtifacts Artifacts
        {
            get;
            set;
        }

        /// <summary>environment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#environment CodebuildProject#environment}
        /// </remarks>
        [JsiiProperty(name: "environment", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectEnvironment\"}")]
        public aws.CodebuildProject.ICodebuildProjectEnvironment Environment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#name CodebuildProject#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#service_role CodebuildProject#service_role}.</summary>
        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceRole
        {
            get;
            set;
        }

        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#source CodebuildProject#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSource\"}")]
        public aws.CodebuildProject.ICodebuildProjectSource Source
        {
            get;
            set;
        }

        /// <summary>Maximum number of additional automatic retries after a failed build. The default value is 0.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#auto_retry_limit CodebuildProject#auto_retry_limit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoRetryLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AutoRetryLimit
        {
            get;
            set;
        }

        private object? _badgeEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#badge_enabled CodebuildProject#badge_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "badgeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? BadgeEnabled
        {
            get => _badgeEnabled;
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
                _badgeEnabled = value;
            }
        }

        /// <summary>build_batch_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#build_batch_config CodebuildProject#build_batch_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "buildBatchConfig", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectBuildBatchConfig\"}", isOptional: true)]
        public aws.CodebuildProject.ICodebuildProjectBuildBatchConfig? BuildBatchConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#build_timeout CodebuildProject#build_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "buildTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BuildTimeout
        {
            get;
            set;
        }

        /// <summary>cache block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#cache CodebuildProject#cache}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectCache\"}", isOptional: true)]
        public aws.CodebuildProject.ICodebuildProjectCache? Cache
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#concurrent_build_limit CodebuildProject#concurrent_build_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "concurrentBuildLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConcurrentBuildLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#description CodebuildProject#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#encryption_key CodebuildProject#encryption_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EncryptionKey
        {
            get;
            set;
        }

        private object? _fileSystemLocations;

        /// <summary>file_system_locations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#file_system_locations CodebuildProject#file_system_locations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystemLocations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectFileSystemLocations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FileSystemLocations
        {
            get => _fileSystemLocations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CodebuildProject.ICodebuildProjectFileSystemLocations[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CodebuildProject.ICodebuildProjectFileSystemLocations).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fileSystemLocations = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#id CodebuildProject#id}.</summary>
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

        /// <summary>logs_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#logs_config CodebuildProject#logs_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logsConfig", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectLogsConfig\"}", isOptional: true)]
        public aws.CodebuildProject.ICodebuildProjectLogsConfig? LogsConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#project_visibility CodebuildProject#project_visibility}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "projectVisibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProjectVisibility
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#queued_timeout CodebuildProject#queued_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queuedTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? QueuedTimeout
        {
            get;
            set;
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#region CodebuildProject#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#resource_access_role CodebuildProject#resource_access_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAccessRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceAccessRole
        {
            get;
            set;
        }

        private object? _secondaryArtifacts;

        /// <summary>secondary_artifacts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#secondary_artifacts CodebuildProject#secondary_artifacts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryArtifacts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondaryArtifacts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SecondaryArtifacts
        {
            get => _secondaryArtifacts;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CodebuildProject.ICodebuildProjectSecondaryArtifacts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CodebuildProject.ICodebuildProjectSecondaryArtifacts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secondaryArtifacts = value;
            }
        }

        private object? _secondarySources;

        /// <summary>secondary_sources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#secondary_sources CodebuildProject#secondary_sources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secondarySources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SecondarySources
        {
            get => _secondarySources;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CodebuildProject.ICodebuildProjectSecondarySources[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CodebuildProject.ICodebuildProjectSecondarySources).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secondarySources = value;
            }
        }

        private object? _secondarySourceVersion;

        /// <summary>secondary_source_version block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#secondary_source_version CodebuildProject#secondary_source_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secondarySourceVersion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySourceVersion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SecondarySourceVersion
        {
            get => _secondarySourceVersion;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CodebuildProject.ICodebuildProjectSecondarySourceVersion[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CodebuildProject.ICodebuildProjectSecondarySourceVersion).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secondarySourceVersion = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#source_version CodebuildProject#source_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#tags CodebuildProject#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#tags_all CodebuildProject#tags_all}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get;
            set;
        }

        /// <summary>vpc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/codebuild_project#vpc_config CodebuildProject#vpc_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectVpcConfig\"}", isOptional: true)]
        public aws.CodebuildProject.ICodebuildProjectVpcConfig? VpcConfig
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
