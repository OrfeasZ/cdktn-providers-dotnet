using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsDaemonTaskDefinition
{
    [JsiiInterface(nativeType: typeof(IEcsDaemonTaskDefinitionContainerDefinition), fullyQualifiedName: "aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinition")]
    public interface IEcsDaemonTaskDefinitionContainerDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#image EcsDaemonTaskDefinition#image}.</summary>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        string Image
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#command EcsDaemonTaskDefinition#command}.</summary>
        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Command
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#cpu EcsDaemonTaskDefinition#cpu}.</summary>
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Cpu
        {
            get
            {
                return null;
            }
        }

        /// <summary>depends_on block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#depends_on EcsDaemonTaskDefinition#depends_on}
        /// </remarks>
        [JsiiProperty(name: "dependsOn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionDependsOn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DependsOn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#entry_point EcsDaemonTaskDefinition#entry_point}.</summary>
        [JsiiProperty(name: "entryPoint", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EntryPoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>environment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#environment EcsDaemonTaskDefinition#environment}
        /// </remarks>
        [JsiiProperty(name: "environment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionEnvironment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Environment
        {
            get
            {
                return null;
            }
        }

        /// <summary>environment_file block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#environment_file EcsDaemonTaskDefinition#environment_file}
        /// </remarks>
        [JsiiProperty(name: "environmentFile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionEnvironmentFile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnvironmentFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#essential EcsDaemonTaskDefinition#essential}.</summary>
        [JsiiProperty(name: "essential", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Essential
        {
            get
            {
                return null;
            }
        }

        /// <summary>firelens_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#firelens_configuration EcsDaemonTaskDefinition#firelens_configuration}
        /// </remarks>
        [JsiiProperty(name: "firelensConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionFirelensConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FirelensConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>health_check block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#health_check EcsDaemonTaskDefinition#health_check}
        /// </remarks>
        [JsiiProperty(name: "healthCheck", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionHealthCheck\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HealthCheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#interactive EcsDaemonTaskDefinition#interactive}.</summary>
        [JsiiProperty(name: "interactive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Interactive
        {
            get
            {
                return null;
            }
        }

        /// <summary>linux_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#linux_parameters EcsDaemonTaskDefinition#linux_parameters}
        /// </remarks>
        [JsiiProperty(name: "linuxParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionLinuxParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LinuxParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#log_configuration EcsDaemonTaskDefinition#log_configuration}
        /// </remarks>
        [JsiiProperty(name: "logConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionLogConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#memory EcsDaemonTaskDefinition#memory}.</summary>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Memory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#memory_reservation EcsDaemonTaskDefinition#memory_reservation}.</summary>
        [JsiiProperty(name: "memoryReservation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MemoryReservation
        {
            get
            {
                return null;
            }
        }

        /// <summary>mount_point block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#mount_point EcsDaemonTaskDefinition#mount_point}
        /// </remarks>
        [JsiiProperty(name: "mountPoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionMountPoint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MountPoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#name EcsDaemonTaskDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#privileged EcsDaemonTaskDefinition#privileged}.</summary>
        [JsiiProperty(name: "privileged", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Privileged
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#pseudo_terminal EcsDaemonTaskDefinition#pseudo_terminal}.</summary>
        [JsiiProperty(name: "pseudoTerminal", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PseudoTerminal
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#readonly_root_filesystem EcsDaemonTaskDefinition#readonly_root_filesystem}.</summary>
        [JsiiProperty(name: "readonlyRootFilesystem", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReadonlyRootFilesystem
        {
            get
            {
                return null;
            }
        }

        /// <summary>repository_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#repository_credentials EcsDaemonTaskDefinition#repository_credentials}
        /// </remarks>
        [JsiiProperty(name: "repositoryCredentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionRepositoryCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RepositoryCredentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>restart_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#restart_policy EcsDaemonTaskDefinition#restart_policy}
        /// </remarks>
        [JsiiProperty(name: "restartPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionRestartPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RestartPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>secret block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#secret EcsDaemonTaskDefinition#secret}
        /// </remarks>
        [JsiiProperty(name: "secret", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Secret
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#start_timeout EcsDaemonTaskDefinition#start_timeout}.</summary>
        [JsiiProperty(name: "startTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StartTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#stop_timeout EcsDaemonTaskDefinition#stop_timeout}.</summary>
        [JsiiProperty(name: "stopTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StopTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>system_control block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#system_control EcsDaemonTaskDefinition#system_control}
        /// </remarks>
        [JsiiProperty(name: "systemControl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionSystemControl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SystemControl
        {
            get
            {
                return null;
            }
        }

        /// <summary>ulimit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#ulimit EcsDaemonTaskDefinition#ulimit}
        /// </remarks>
        [JsiiProperty(name: "ulimit", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionUlimit\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ulimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#user EcsDaemonTaskDefinition#user}.</summary>
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? User
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#working_directory EcsDaemonTaskDefinition#working_directory}.</summary>
        [JsiiProperty(name: "workingDirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkingDirectory
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsDaemonTaskDefinitionContainerDefinition), fullyQualifiedName: "aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#image EcsDaemonTaskDefinition#image}.</summary>
            [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
            public string Image
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#command EcsDaemonTaskDefinition#command}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Command
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#cpu EcsDaemonTaskDefinition#cpu}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Cpu
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>depends_on block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#depends_on EcsDaemonTaskDefinition#depends_on}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionDependsOn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DependsOn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#entry_point EcsDaemonTaskDefinition#entry_point}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "entryPoint", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EntryPoint
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>environment block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#environment EcsDaemonTaskDefinition#environment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionEnvironment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Environment
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>environment_file block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#environment_file EcsDaemonTaskDefinition#environment_file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environmentFile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionEnvironmentFile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EnvironmentFile
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#essential EcsDaemonTaskDefinition#essential}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "essential", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Essential
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>firelens_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#firelens_configuration EcsDaemonTaskDefinition#firelens_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firelensConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionFirelensConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FirelensConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>health_check block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#health_check EcsDaemonTaskDefinition#health_check}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheck", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionHealthCheck\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HealthCheck
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#interactive EcsDaemonTaskDefinition#interactive}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "interactive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Interactive
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>linux_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#linux_parameters EcsDaemonTaskDefinition#linux_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "linuxParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionLinuxParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LinuxParameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>log_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#log_configuration EcsDaemonTaskDefinition#log_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionLogConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#memory EcsDaemonTaskDefinition#memory}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Memory
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#memory_reservation EcsDaemonTaskDefinition#memory_reservation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memoryReservation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MemoryReservation
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>mount_point block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#mount_point EcsDaemonTaskDefinition#mount_point}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mountPoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionMountPoint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MountPoint
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#name EcsDaemonTaskDefinition#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#privileged EcsDaemonTaskDefinition#privileged}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privileged", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Privileged
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#pseudo_terminal EcsDaemonTaskDefinition#pseudo_terminal}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pseudoTerminal", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PseudoTerminal
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#readonly_root_filesystem EcsDaemonTaskDefinition#readonly_root_filesystem}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "readonlyRootFilesystem", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ReadonlyRootFilesystem
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>repository_credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#repository_credentials EcsDaemonTaskDefinition#repository_credentials}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryCredentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionRepositoryCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RepositoryCredentials
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>restart_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#restart_policy EcsDaemonTaskDefinition#restart_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "restartPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionRestartPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RestartPolicy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>secret block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#secret EcsDaemonTaskDefinition#secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secret", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Secret
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#start_timeout EcsDaemonTaskDefinition#start_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StartTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#stop_timeout EcsDaemonTaskDefinition#stop_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stopTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StopTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>system_control block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#system_control EcsDaemonTaskDefinition#system_control}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "systemControl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionSystemControl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SystemControl
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ulimit block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#ulimit EcsDaemonTaskDefinition#ulimit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ulimit", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionUlimit\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ulimit
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#user EcsDaemonTaskDefinition#user}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? User
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/ecs_daemon_task_definition#working_directory EcsDaemonTaskDefinition#working_directory}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "workingDirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkingDirectory
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
