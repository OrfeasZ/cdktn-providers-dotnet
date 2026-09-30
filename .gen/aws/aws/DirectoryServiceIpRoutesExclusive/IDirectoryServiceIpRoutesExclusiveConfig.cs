using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DirectoryServiceIpRoutesExclusive
{
    [JsiiInterface(nativeType: typeof(IDirectoryServiceIpRoutesExclusiveConfig), fullyQualifiedName: "aws.directoryServiceIpRoutesExclusive.DirectoryServiceIpRoutesExclusiveConfig")]
    public interface IDirectoryServiceIpRoutesExclusiveConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.67.0/docs/resources/directory_service_ip_routes_exclusive#directory_id DirectoryServiceIpRoutesExclusive#directory_id}.</summary>
        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
        string DirectoryId
        {
            get;
        }

        /// <summary>ip_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.67.0/docs/resources/directory_service_ip_routes_exclusive#ip_route DirectoryServiceIpRoutesExclusive#ip_route}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DirectoryServiceIpRoutesExclusive.IDirectoryServiceIpRoutesExclusiveIpRoute" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ipRoute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.directoryServiceIpRoutesExclusive.DirectoryServiceIpRoutesExclusiveIpRoute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IpRoute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.67.0/docs/resources/directory_service_ip_routes_exclusive#region DirectoryServiceIpRoutesExclusive#region}
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.67.0/docs/resources/directory_service_ip_routes_exclusive#timeouts DirectoryServiceIpRoutesExclusive#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.directoryServiceIpRoutesExclusive.DirectoryServiceIpRoutesExclusiveTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DirectoryServiceIpRoutesExclusive.IDirectoryServiceIpRoutesExclusiveTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.67.0/docs/resources/directory_service_ip_routes_exclusive#update_security_group_for_directory_controllers DirectoryServiceIpRoutesExclusive#update_security_group_for_directory_controllers}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "updateSecurityGroupForDirectoryControllers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UpdateSecurityGroupForDirectoryControllers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDirectoryServiceIpRoutesExclusiveConfig), fullyQualifiedName: "aws.directoryServiceIpRoutesExclusive.DirectoryServiceIpRoutesExclusiveConfig")]
        internal sealed class _Proxy : DeputyBase, aws.DirectoryServiceIpRoutesExclusive.IDirectoryServiceIpRoutesExclusiveConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.67.0/docs/resources/directory_service_ip_routes_exclusive#directory_id DirectoryServiceIpRoutesExclusive#directory_id}.</summary>
            [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
            public string DirectoryId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ip_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.67.0/docs/resources/directory_service_ip_routes_exclusive#ip_route DirectoryServiceIpRoutesExclusive#ip_route}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DirectoryServiceIpRoutesExclusive.IDirectoryServiceIpRoutesExclusiveIpRoute" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipRoute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.directoryServiceIpRoutesExclusive.DirectoryServiceIpRoutesExclusiveIpRoute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IpRoute
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.67.0/docs/resources/directory_service_ip_routes_exclusive#region DirectoryServiceIpRoutesExclusive#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.67.0/docs/resources/directory_service_ip_routes_exclusive#timeouts DirectoryServiceIpRoutesExclusive#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.directoryServiceIpRoutesExclusive.DirectoryServiceIpRoutesExclusiveTimeouts\"}", isOptional: true)]
            public aws.DirectoryServiceIpRoutesExclusive.IDirectoryServiceIpRoutesExclusiveTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.DirectoryServiceIpRoutesExclusive.IDirectoryServiceIpRoutesExclusiveTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.67.0/docs/resources/directory_service_ip_routes_exclusive#update_security_group_for_directory_controllers DirectoryServiceIpRoutesExclusive#update_security_group_for_directory_controllers}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "updateSecurityGroupForDirectoryControllers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UpdateSecurityGroupForDirectoryControllers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
