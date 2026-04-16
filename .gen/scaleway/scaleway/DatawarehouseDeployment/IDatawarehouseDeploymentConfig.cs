using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DatawarehouseDeployment
{
    [JsiiInterface(nativeType: typeof(IDatawarehouseDeploymentConfig), fullyQualifiedName: "scaleway.datawarehouseDeployment.DatawarehouseDeploymentConfig")]
    public interface IDatawarehouseDeploymentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Maximum CPU count.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#cpu_max DatawarehouseDeployment#cpu_max}
        /// </remarks>
        [JsiiProperty(name: "cpuMax", typeJson: "{\"primitive\":\"number\"}")]
        double CpuMax
        {
            get;
        }

        /// <summary>Minimum CPU count.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#cpu_min DatawarehouseDeployment#cpu_min}
        /// </remarks>
        [JsiiProperty(name: "cpuMin", typeJson: "{\"primitive\":\"number\"}")]
        double CpuMin
        {
            get;
        }

        /// <summary>Name of the Datawarehouse deployment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#name DatawarehouseDeployment#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>RAM per CPU (GB).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#ram_per_cpu DatawarehouseDeployment#ram_per_cpu}
        /// </remarks>
        [JsiiProperty(name: "ramPerCpu", typeJson: "{\"primitive\":\"number\"}")]
        double RamPerCpu
        {
            get;
        }

        /// <summary>Number of replicas.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#replica_count DatawarehouseDeployment#replica_count}
        /// </remarks>
        [JsiiProperty(name: "replicaCount", typeJson: "{\"primitive\":\"number\"}")]
        double ReplicaCount
        {
            get;
        }

        /// <summary>ClickHouse version to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#version DatawarehouseDeployment#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#id DatawarehouseDeployment#id}.</summary>
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

        /// <summary>Password for the first user of the deployment. Only one of `password` or `password_wo` should be specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#password DatawarehouseDeployment#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>Password for the first user of the deployment in [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) mode. Only one of `password` or `password_wo` should be specified. `password_wo` will not be set in the Terraform state. To update the `password_wo`, you must also update the `password_wo_version`. When updating, the password is rotated via the Data Warehouse Users API (the initial user is selected as an admin user when present, otherwise the first user by name).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#password_wo DatawarehouseDeployment#password_wo}
        /// </remarks>
        [JsiiProperty(name: "passwordWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswordWo
        {
            get
            {
                return null;
            }
        }

        /// <summary>The version of the [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) password. To update the `password_wo`, you must also update the `password_wo_version`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#password_wo_version DatawarehouseDeployment#password_wo_version}
        /// </remarks>
        [JsiiProperty(name: "passwordWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PasswordWoVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#private_network DatawarehouseDeployment#private_network}
        /// </remarks>
        [JsiiProperty(name: "privateNetwork", typeJson: "{\"fqn\":\"scaleway.datawarehouseDeployment.DatawarehouseDeploymentPrivateNetwork\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.DatawarehouseDeployment.IDatawarehouseDeploymentPrivateNetwork? PrivateNetwork
        {
            get
            {
                return null;
            }
        }

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#project_id DatawarehouseDeployment#project_id}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#region DatawarehouseDeployment#region}
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

        /// <summary>Whether the deployment should be running (`true`) or stopped (`false`).</summary>
        /// <remarks>
        /// Maps to the Start deployment and Stop deployment API actions.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#started DatawarehouseDeployment#started}
        /// </remarks>
        [JsiiProperty(name: "started", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Started
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of tags to apply.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#tags DatawarehouseDeployment#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#timeouts DatawarehouseDeployment#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.datawarehouseDeployment.DatawarehouseDeploymentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.DatawarehouseDeployment.IDatawarehouseDeploymentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatawarehouseDeploymentConfig), fullyQualifiedName: "scaleway.datawarehouseDeployment.DatawarehouseDeploymentConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.DatawarehouseDeployment.IDatawarehouseDeploymentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Maximum CPU count.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#cpu_max DatawarehouseDeployment#cpu_max}
            /// </remarks>
            [JsiiProperty(name: "cpuMax", typeJson: "{\"primitive\":\"number\"}")]
            public double CpuMax
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Minimum CPU count.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#cpu_min DatawarehouseDeployment#cpu_min}
            /// </remarks>
            [JsiiProperty(name: "cpuMin", typeJson: "{\"primitive\":\"number\"}")]
            public double CpuMin
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Name of the Datawarehouse deployment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#name DatawarehouseDeployment#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>RAM per CPU (GB).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#ram_per_cpu DatawarehouseDeployment#ram_per_cpu}
            /// </remarks>
            [JsiiProperty(name: "ramPerCpu", typeJson: "{\"primitive\":\"number\"}")]
            public double RamPerCpu
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Number of replicas.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#replica_count DatawarehouseDeployment#replica_count}
            /// </remarks>
            [JsiiProperty(name: "replicaCount", typeJson: "{\"primitive\":\"number\"}")]
            public double ReplicaCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>ClickHouse version to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#version DatawarehouseDeployment#version}
            /// </remarks>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#id DatawarehouseDeployment#id}.</summary>
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

            /// <summary>Password for the first user of the deployment. Only one of `password` or `password_wo` should be specified.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#password DatawarehouseDeployment#password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Password for the first user of the deployment in [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) mode. Only one of `password` or `password_wo` should be specified. `password_wo` will not be set in the Terraform state. To update the `password_wo`, you must also update the `password_wo_version`. When updating, the password is rotated via the Data Warehouse Users API (the initial user is selected as an admin user when present, otherwise the first user by name).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#password_wo DatawarehouseDeployment#password_wo}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwordWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordWo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The version of the [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) password. To update the `password_wo`, you must also update the `password_wo_version`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#password_wo_version DatawarehouseDeployment#password_wo_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwordWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PasswordWoVersion
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>private_network block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#private_network DatawarehouseDeployment#private_network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateNetwork", typeJson: "{\"fqn\":\"scaleway.datawarehouseDeployment.DatawarehouseDeploymentPrivateNetwork\"}", isOptional: true)]
            public scaleway.DatawarehouseDeployment.IDatawarehouseDeploymentPrivateNetwork? PrivateNetwork
            {
                get => GetInstanceProperty<scaleway.DatawarehouseDeployment.IDatawarehouseDeploymentPrivateNetwork?>();
            }

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#project_id DatawarehouseDeployment#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The region you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#region DatawarehouseDeployment#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether the deployment should be running (`true`) or stopped (`false`).</summary>
            /// <remarks>
            /// Maps to the Start deployment and Stop deployment API actions.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#started DatawarehouseDeployment#started}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "started", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Started
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>List of tags to apply.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#tags DatawarehouseDeployment#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/datawarehouse_deployment#timeouts DatawarehouseDeployment#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.datawarehouseDeployment.DatawarehouseDeploymentTimeouts\"}", isOptional: true)]
            public scaleway.DatawarehouseDeployment.IDatawarehouseDeploymentTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.DatawarehouseDeployment.IDatawarehouseDeploymentTimeouts?>();
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
