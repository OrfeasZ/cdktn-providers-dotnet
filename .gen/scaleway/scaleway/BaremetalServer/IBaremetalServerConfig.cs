using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.BaremetalServer
{
    [JsiiInterface(nativeType: typeof(IBaremetalServerConfig), fullyQualifiedName: "scaleway.baremetalServer.BaremetalServerConfig")]
    public interface IBaremetalServerConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>ID or name of the server offer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#offer BaremetalServer#offer}
        /// </remarks>
        [JsiiProperty(name: "offer", typeJson: "{\"primitive\":\"string\"}")]
        string Offer
        {
            get;
        }

        /// <summary>Configuration data to pass to cloud-init such as a YAML cloud config data or a user-data script.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#cloud_init BaremetalServer#cloud_init}
        /// </remarks>
        [JsiiProperty(name: "cloudInit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudInit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Some description to associate to the server, max 255 characters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#description BaremetalServer#description}
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

        /// <summary>Hostname of the server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#hostname BaremetalServer#hostname}
        /// </remarks>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Hostname
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#id BaremetalServer#id}.</summary>
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

        /// <summary>If True, this boolean allows to create a server without the install config if you want to provide it later.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#install_config_afterward BaremetalServer#install_config_afterward}
        /// </remarks>
        [JsiiProperty(name: "installConfigAfterward", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InstallConfigAfterward
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#name BaremetalServer#name}
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

        /// <summary>options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#options BaremetalServer#options}
        /// </remarks>
        [JsiiProperty(name: "options", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.baremetalServer.BaremetalServerOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Options
        {
            get
            {
                return null;
            }
        }

        /// <summary>The base image of the server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#os BaremetalServer#os}
        /// </remarks>
        [JsiiProperty(name: "os", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Os
        {
            get
            {
                return null;
            }
        }

        /// <summary>The partitioning schema in json format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#partitioning BaremetalServer#partitioning}
        /// </remarks>
        [JsiiProperty(name: "partitioning", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Partitioning
        {
            get
            {
                return null;
            }
        }

        /// <summary>Password used for the installation. Only one of `password` or `password_wo` should be specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#password BaremetalServer#password}
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

        /// <summary>Password used for the installation in [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) mode. Only one of `password` or `password_wo` should be specified. `password_wo` will not be set in the Terraform state. To update the `password_wo`, you must also update the `password_wo_version`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#password_wo BaremetalServer#password_wo}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#password_wo_version BaremetalServer#password_wo_version}
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

        /// <summary>private_ips block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#private_ips BaremetalServer#private_ips}
        /// </remarks>
        [JsiiProperty(name: "privateIps", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.baremetalServer.BaremetalServerPrivateIps\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrivateIps
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#private_network BaremetalServer#private_network}
        /// </remarks>
        [JsiiProperty(name: "privateNetwork", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.baremetalServer.BaremetalServerPrivateNetwork\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrivateNetwork
        {
            get
            {
                return null;
            }
        }

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#project_id BaremetalServer#project_id}
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

        /// <summary>If true, the baremetal server is protected against accidental deletion via the Scaleway API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#protected BaremetalServer#protected}
        /// </remarks>
        [JsiiProperty(name: "protected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Protected
        {
            get
            {
                return null;
            }
        }

        /// <summary>If True, this boolean allows to reinstall the server on SSH key IDs, user or password changes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#reinstall_on_config_changes BaremetalServer#reinstall_on_config_changes}
        /// </remarks>
        [JsiiProperty(name: "reinstallOnConfigChanges", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReinstallOnConfigChanges
        {
            get
            {
                return null;
            }
        }

        /// <summary>Password used for the service to install. Only one of `service_password` or `service_password_wo` should be specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#service_password BaremetalServer#service_password}
        /// </remarks>
        [JsiiProperty(name: "servicePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServicePassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Password used for the service to install in [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) mode. Only one of `service_password` or `service_password_wo` should be specified. `service_password_wo` will not be set in the Terraform state. To update the `service_password_wo`, you must also update the `service_password_wo_version`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#service_password_wo BaremetalServer#service_password_wo}
        /// </remarks>
        [JsiiProperty(name: "servicePasswordWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServicePasswordWo
        {
            get
            {
                return null;
            }
        }

        /// <summary>The version of the [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) service password. To update the `service_password_wo`, you must also update the `service_password_wo_version`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#service_password_wo_version BaremetalServer#service_password_wo_version}
        /// </remarks>
        [JsiiProperty(name: "servicePasswordWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ServicePasswordWoVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>User used for the service to install.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#service_user BaremetalServer#service_user}
        /// </remarks>
        [JsiiProperty(name: "serviceUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>Array of SSH key IDs allowed to SSH to the server.</summary>
        /// <remarks>
        /// <strong>NOTE</strong> : If you are attempting to update your SSH key IDs, it will induce the reinstall of your server.
        /// If this behaviour is wanted, please set 'reinstall_on_ssh_key_changes' argument to true.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#ssh_key_ids BaremetalServer#ssh_key_ids}
        /// </remarks>
        [JsiiProperty(name: "sshKeyIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SshKeyIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Array of tags to associate with the server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#tags BaremetalServer#tags}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#timeouts BaremetalServer#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.baremetalServer.BaremetalServerTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.BaremetalServer.IBaremetalServerTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>User used for the installation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#user BaremetalServer#user}
        /// </remarks>
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? User
        {
            get
            {
                return null;
            }
        }

        /// <summary>The zone you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#zone BaremetalServer#zone}
        /// </remarks>
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Zone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBaremetalServerConfig), fullyQualifiedName: "scaleway.baremetalServer.BaremetalServerConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.BaremetalServer.IBaremetalServerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID or name of the server offer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#offer BaremetalServer#offer}
            /// </remarks>
            [JsiiProperty(name: "offer", typeJson: "{\"primitive\":\"string\"}")]
            public string Offer
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Configuration data to pass to cloud-init such as a YAML cloud config data or a user-data script.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#cloud_init BaremetalServer#cloud_init}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudInit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudInit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Some description to associate to the server, max 255 characters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#description BaremetalServer#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Hostname of the server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#hostname BaremetalServer#hostname}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Hostname
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#id BaremetalServer#id}.</summary>
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

            /// <summary>If True, this boolean allows to create a server without the install config if you want to provide it later.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#install_config_afterward BaremetalServer#install_config_afterward}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "installConfigAfterward", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? InstallConfigAfterward
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Name of the server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#name BaremetalServer#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#options BaremetalServer#options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "options", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.baremetalServer.BaremetalServerOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Options
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The base image of the server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#os BaremetalServer#os}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "os", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Os
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The partitioning schema in json format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#partitioning BaremetalServer#partitioning}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "partitioning", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Partitioning
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Password used for the installation. Only one of `password` or `password_wo` should be specified.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#password BaremetalServer#password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Password used for the installation in [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) mode. Only one of `password` or `password_wo` should be specified. `password_wo` will not be set in the Terraform state. To update the `password_wo`, you must also update the `password_wo_version`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#password_wo BaremetalServer#password_wo}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwordWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordWo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The version of the [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) password. To update the `password_wo`, you must also update the `password_wo_version`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#password_wo_version BaremetalServer#password_wo_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwordWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PasswordWoVersion
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>private_ips block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#private_ips BaremetalServer#private_ips}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateIps", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.baremetalServer.BaremetalServerPrivateIps\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PrivateIps
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>private_network block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#private_network BaremetalServer#private_network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateNetwork", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.baremetalServer.BaremetalServerPrivateNetwork\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PrivateNetwork
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#project_id BaremetalServer#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If true, the baremetal server is protected against accidental deletion via the Scaleway API.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#protected BaremetalServer#protected}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Protected
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>If True, this boolean allows to reinstall the server on SSH key IDs, user or password changes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#reinstall_on_config_changes BaremetalServer#reinstall_on_config_changes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reinstallOnConfigChanges", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ReinstallOnConfigChanges
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Password used for the service to install. Only one of `service_password` or `service_password_wo` should be specified.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#service_password BaremetalServer#service_password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "servicePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServicePassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Password used for the service to install in [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) mode. Only one of `service_password` or `service_password_wo` should be specified. `service_password_wo` will not be set in the Terraform state. To update the `service_password_wo`, you must also update the `service_password_wo_version`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#service_password_wo BaremetalServer#service_password_wo}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "servicePasswordWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServicePasswordWo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The version of the [write-only](https://registry.terraform.io/providers/scaleway/scaleway/latest/docs/guides/using-write-only-arguments) service password. To update the `service_password_wo`, you must also update the `service_password_wo_version`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#service_password_wo_version BaremetalServer#service_password_wo_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "servicePasswordWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ServicePasswordWoVersion
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>User used for the service to install.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#service_user BaremetalServer#service_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceUser
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Array of SSH key IDs allowed to SSH to the server.</summary>
            /// <remarks>
            /// <strong>NOTE</strong> : If you are attempting to update your SSH key IDs, it will induce the reinstall of your server.
            /// If this behaviour is wanted, please set 'reinstall_on_ssh_key_changes' argument to true.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#ssh_key_ids BaremetalServer#ssh_key_ids}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sshKeyIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SshKeyIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Array of tags to associate with the server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#tags BaremetalServer#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#timeouts BaremetalServer#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.baremetalServer.BaremetalServerTimeouts\"}", isOptional: true)]
            public scaleway.BaremetalServer.IBaremetalServerTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.BaremetalServer.IBaremetalServerTimeouts?>();
            }

            /// <summary>User used for the installation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#user BaremetalServer#user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? User
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The zone you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/baremetal_server#zone BaremetalServer#zone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Zone
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
