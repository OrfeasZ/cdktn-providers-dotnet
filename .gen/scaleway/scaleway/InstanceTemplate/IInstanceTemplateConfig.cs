using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstanceTemplate
{
    [JsiiInterface(nativeType: typeof(IInstanceTemplateConfig), fullyQualifiedName: "scaleway.instanceTemplate.InstanceTemplateConfig")]
    public interface IInstanceTemplateConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The commercial type of the server defined by the Instance Template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#server_type InstanceTemplate#server_type}
        /// </remarks>
        [JsiiProperty(name: "serverType", typeJson: "{\"primitive\":\"string\"}")]
        string ServerType
        {
            get;
        }

        /// <summary>The IDs of the filesystems to attach to the servers created using the Instance Template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#filesystem_ids InstanceTemplate#filesystem_ids}
        /// </remarks>
        [JsiiProperty(name: "filesystemIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? FilesystemIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the Instance Template. If not provided, a random name will be generated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#name InstanceTemplate#name}
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

        /// <summary>The ID of the placement group to attach to the servers created using the Instance Template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#placement_group_id InstanceTemplate#placement_group_id}
        /// </remarks>
        [JsiiProperty(name: "placementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlacementGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The IDs of the private networks to attach to the servers created using the Instance Template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#private_networks InstanceTemplate#private_networks}
        /// </remarks>
        [JsiiProperty(name: "privateNetworks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PrivateNetworks
        {
            get
            {
                return null;
            }
        }

        /// <summary>The project ID the Instance Template belongs to. Defaults to the provider's project ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#project_id InstanceTemplate#project_id}
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

        /// <summary>The number of public IPv4 to attach to the servers created using the Instance Template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#public_ipv4_count InstanceTemplate#public_ipv4_count}
        /// </remarks>
        [JsiiProperty(name: "publicIpv4Count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PublicIpv4Count
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of public IPv6 to attach to the servers created using the Instance Template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#public_ipv6_count InstanceTemplate#public_ipv6_count}
        /// </remarks>
        [JsiiProperty(name: "publicIpv6Count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PublicIpv6Count
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the security group to attach to the servers created using the Instance Template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#security_group_id InstanceTemplate#security_group_id}
        /// </remarks>
        [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The tags that will be assigned to the servers created using the Instance Template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#server_tags InstanceTemplate#server_tags}
        /// </remarks>
        [JsiiProperty(name: "serverTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ServerTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>The tags associated with the Instance Template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#tags InstanceTemplate#tags}
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

        /// <summary>The specs of the volumes of the servers created using the Instance Template.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#volumes InstanceTemplate#volumes}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="scaleway.InstanceTemplate.IInstanceTemplateVolumes" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "volumes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.instanceTemplate.InstanceTemplateVolumes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Volumes
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the IAM SSH key used to encrypt the initial admin password on a Windows server.</summary>
        /// <remarks>
        /// This will be repeated on all servers created using the Instance Template.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#windows_rdp_ssh_key_id InstanceTemplate#windows_rdp_ssh_key_id}
        /// </remarks>
        [JsiiProperty(name: "windowsRdpSshKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WindowsRdpSshKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The zone the Instance Template is in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#zone InstanceTemplate#zone}
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

        [JsiiTypeProxy(nativeType: typeof(IInstanceTemplateConfig), fullyQualifiedName: "scaleway.instanceTemplate.InstanceTemplateConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.InstanceTemplate.IInstanceTemplateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The commercial type of the server defined by the Instance Template.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#server_type InstanceTemplate#server_type}
            /// </remarks>
            [JsiiProperty(name: "serverType", typeJson: "{\"primitive\":\"string\"}")]
            public string ServerType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The IDs of the filesystems to attach to the servers created using the Instance Template.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#filesystem_ids InstanceTemplate#filesystem_ids}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filesystemIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? FilesystemIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The name of the Instance Template. If not provided, a random name will be generated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#name InstanceTemplate#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ID of the placement group to attach to the servers created using the Instance Template.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#placement_group_id InstanceTemplate#placement_group_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "placementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlacementGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The IDs of the private networks to attach to the servers created using the Instance Template.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#private_networks InstanceTemplate#private_networks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateNetworks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PrivateNetworks
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The project ID the Instance Template belongs to. Defaults to the provider's project ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#project_id InstanceTemplate#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of public IPv4 to attach to the servers created using the Instance Template.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#public_ipv4_count InstanceTemplate#public_ipv4_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicIpv4Count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PublicIpv4Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The number of public IPv6 to attach to the servers created using the Instance Template.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#public_ipv6_count InstanceTemplate#public_ipv6_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicIpv6Count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PublicIpv6Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The ID of the security group to attach to the servers created using the Instance Template.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#security_group_id InstanceTemplate#security_group_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The tags that will be assigned to the servers created using the Instance Template.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#server_tags InstanceTemplate#server_tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serverTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ServerTags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The tags associated with the Instance Template.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#tags InstanceTemplate#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The specs of the volumes of the servers created using the Instance Template.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#volumes InstanceTemplate#volumes}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="scaleway.InstanceTemplate.IInstanceTemplateVolumes" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.instanceTemplate.InstanceTemplateVolumes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Volumes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The ID of the IAM SSH key used to encrypt the initial admin password on a Windows server.</summary>
            /// <remarks>
            /// This will be repeated on all servers created using the Instance Template.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#windows_rdp_ssh_key_id InstanceTemplate#windows_rdp_ssh_key_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "windowsRdpSshKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WindowsRdpSshKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The zone the Instance Template is in.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/instance_template#zone InstanceTemplate#zone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Zone
            {
                get => GetInstanceProperty<string?>();
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
