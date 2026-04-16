using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.JobDefinition
{
    [JsiiInterface(nativeType: typeof(IJobDefinitionConfig), fullyQualifiedName: "scaleway.jobDefinition.JobDefinitionConfig")]
    public interface IJobDefinitionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>CPU limit of the job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#cpu_limit JobDefinition#cpu_limit}
        /// </remarks>
        [JsiiProperty(name: "cpuLimit", typeJson: "{\"primitive\":\"number\"}")]
        double CpuLimit
        {
            get;
        }

        /// <summary>Image URI to use for the job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#image_uri JobDefinition#image_uri}
        /// </remarks>
        [JsiiProperty(name: "imageUri", typeJson: "{\"primitive\":\"string\"}")]
        string ImageUri
        {
            get;
        }

        /// <summary>Local storage capacity of the job in MiB.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#local_storage_capacity JobDefinition#local_storage_capacity}
        /// </remarks>
        [JsiiProperty(name: "localStorageCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double LocalStorageCapacity
        {
            get;
        }

        /// <summary>Memory limit of the job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#memory_limit JobDefinition#memory_limit}
        /// </remarks>
        [JsiiProperty(name: "memoryLimit", typeJson: "{\"primitive\":\"number\"}")]
        double MemoryLimit
        {
            get;
        }

        /// <summary>Job arguments in list format. Overrides the default arguments defined in the job image.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#args JobDefinition#args}
        /// </remarks>
        [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Args
        {
            get
            {
                return null;
            }
        }

        /// <summary>Command to use for the job (in string format).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#command JobDefinition#command}
        /// </remarks>
        [JsiiProperty(name: "command", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Command
        {
            get
            {
                return null;
            }
        }

        /// <summary>cron block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#cron JobDefinition#cron}
        /// </remarks>
        [JsiiProperty(name: "cron", typeJson: "{\"fqn\":\"scaleway.jobDefinition.JobDefinitionCron\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.JobDefinition.IJobDefinitionCron? Cron
        {
            get
            {
                return null;
            }
        }

        /// <summary>The job description.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#description JobDefinition#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Environment variables to pass to the job.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#env JobDefinition#env}
        /// </remarks>
        [JsiiProperty(name: "env", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Env
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#id JobDefinition#id}.</summary>
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

        /// <summary>The job name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#name JobDefinition#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#project_id JobDefinition#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The region you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#region JobDefinition#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>secret_reference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#secret_reference JobDefinition#secret_reference}
        /// </remarks>
        [JsiiProperty(name: "secretReference", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.jobDefinition.JobDefinitionSecretReference\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecretReference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Command to use for the job (in list format). Overrides the default command defined in the job image.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#startup_command JobDefinition#startup_command}
        /// </remarks>
        [JsiiProperty(name: "startupCommand", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? StartupCommand
        {
            get
            {
                return null;
            }
        }

        /// <summary>Timeout for the job in seconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#timeout JobDefinition#timeout}
        /// </remarks>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Timeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJobDefinitionConfig), fullyQualifiedName: "scaleway.jobDefinition.JobDefinitionConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.JobDefinition.IJobDefinitionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>CPU limit of the job.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#cpu_limit JobDefinition#cpu_limit}
            /// </remarks>
            [JsiiProperty(name: "cpuLimit", typeJson: "{\"primitive\":\"number\"}")]
            public double CpuLimit
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Image URI to use for the job.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#image_uri JobDefinition#image_uri}
            /// </remarks>
            [JsiiProperty(name: "imageUri", typeJson: "{\"primitive\":\"string\"}")]
            public string ImageUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Local storage capacity of the job in MiB.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#local_storage_capacity JobDefinition#local_storage_capacity}
            /// </remarks>
            [JsiiProperty(name: "localStorageCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double LocalStorageCapacity
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Memory limit of the job.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#memory_limit JobDefinition#memory_limit}
            /// </remarks>
            [JsiiProperty(name: "memoryLimit", typeJson: "{\"primitive\":\"number\"}")]
            public double MemoryLimit
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Job arguments in list format. Overrides the default arguments defined in the job image.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#args JobDefinition#args}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Args
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Command to use for the job (in string format).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#command JobDefinition#command}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "command", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Command
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>cron block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#cron JobDefinition#cron}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cron", typeJson: "{\"fqn\":\"scaleway.jobDefinition.JobDefinitionCron\"}", isOptional: true)]
            public scaleway.JobDefinition.IJobDefinitionCron? Cron
            {
                get => GetInstanceProperty<scaleway.JobDefinition.IJobDefinitionCron?>();
            }

            /// <summary>The job description.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#description JobDefinition#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Environment variables to pass to the job.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#env JobDefinition#env}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "env", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Env
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#id JobDefinition#id}.</summary>
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

            /// <summary>The job name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#name JobDefinition#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#project_id JobDefinition#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The region you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#region JobDefinition#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>secret_reference block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#secret_reference JobDefinition#secret_reference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretReference", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.jobDefinition.JobDefinitionSecretReference\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SecretReference
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Command to use for the job (in list format). Overrides the default command defined in the job image.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#startup_command JobDefinition#startup_command}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startupCommand", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? StartupCommand
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Timeout for the job in seconds.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/job_definition#timeout JobDefinition#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Timeout
            {
                get => GetInstanceProperty<string?>();
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
