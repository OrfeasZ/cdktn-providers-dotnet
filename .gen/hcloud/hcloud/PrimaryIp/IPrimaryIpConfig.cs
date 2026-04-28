using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.PrimaryIp
{
    [JsiiInterface(nativeType: typeof(IPrimaryIpConfig), fullyQualifiedName: "hcloud.primaryIp.PrimaryIpConfig")]
    public interface IPrimaryIpConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Whether auto delete is enabled.</summary>
        /// <remarks>
        /// Setting <c>auto_delete</c> to <c>false</c> is recommended, because if a server assigned to the managed ip is getting deleted, it will also delete the primary IP which will break the terraform state.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/primary_ip#auto_delete PrimaryIp#auto_delete}
        /// </remarks>
        [JsiiProperty(name: "autoDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object AutoDelete
        {
            get;
        }

        /// <summary>Name of the Primary IP.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/primary_ip#name PrimaryIp#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Type of the Primary IP (`ipv4` or `ipv6`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/primary_ip#type PrimaryIp#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>ID of the resource the Primary IP should be assigned to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/primary_ip#assignee_id PrimaryIp#assignee_id}
        /// </remarks>
        [JsiiProperty(name: "assigneeId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AssigneeId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Type of the resource the Primary IP should be assigned to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/primary_ip#assignee_type PrimaryIp#assignee_type}
        /// </remarks>
        [JsiiProperty(name: "assigneeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AssigneeType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the Datacenter for the Primary IP. See the [Hetzner Docs](https://docs.hetzner.com/cloud/general/locations/#what-datacenters-are-there) for more details about datacenters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/primary_ip#datacenter PrimaryIp#datacenter}
        /// </remarks>
        [JsiiProperty(name: "datacenter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Datacenter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether delete protection is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/primary_ip#delete_protection PrimaryIp#delete_protection}
        /// </remarks>
        [JsiiProperty(name: "deleteProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeleteProtection
        {
            get
            {
                return null;
            }
        }

        /// <summary>User-defined [labels](https://docs.hetzner.cloud/reference/cloud#labels) (key-value pairs) for the resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/primary_ip#labels PrimaryIp#labels}
        /// </remarks>
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Labels
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the Location for the Primary IP. See the [Hetzner Docs](https://docs.hetzner.com/cloud/general/locations/#what-locations-are-there) for more details about locations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/primary_ip#location PrimaryIp#location}
        /// </remarks>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Location
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPrimaryIpConfig), fullyQualifiedName: "hcloud.primaryIp.PrimaryIpConfig")]
        internal sealed class _Proxy : DeputyBase, hcloud.PrimaryIp.IPrimaryIpConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether auto delete is enabled.</summary>
            /// <remarks>
            /// Setting <c>auto_delete</c> to <c>false</c> is recommended, because if a server assigned to the managed ip is getting deleted, it will also delete the primary IP which will break the terraform state.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/primary_ip#auto_delete PrimaryIp#auto_delete}
            /// </remarks>
            [JsiiProperty(name: "autoDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object AutoDelete
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Name of the Primary IP.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/primary_ip#name PrimaryIp#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Type of the Primary IP (`ipv4` or `ipv6`).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/primary_ip#type PrimaryIp#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ID of the resource the Primary IP should be assigned to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/primary_ip#assignee_id PrimaryIp#assignee_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "assigneeId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AssigneeId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Type of the resource the Primary IP should be assigned to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/primary_ip#assignee_type PrimaryIp#assignee_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "assigneeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AssigneeType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the Datacenter for the Primary IP. See the [Hetzner Docs](https://docs.hetzner.com/cloud/general/locations/#what-datacenters-are-there) for more details about datacenters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/primary_ip#datacenter PrimaryIp#datacenter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "datacenter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Datacenter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether delete protection is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/primary_ip#delete_protection PrimaryIp#delete_protection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deleteProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DeleteProtection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>User-defined [labels](https://docs.hetzner.cloud/reference/cloud#labels) (key-value pairs) for the resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/primary_ip#labels PrimaryIp#labels}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Labels
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Name of the Location for the Primary IP. See the [Hetzner Docs](https://docs.hetzner.com/cloud/general/locations/#what-locations-are-there) for more details about locations.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/primary_ip#location PrimaryIp#location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Location
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
