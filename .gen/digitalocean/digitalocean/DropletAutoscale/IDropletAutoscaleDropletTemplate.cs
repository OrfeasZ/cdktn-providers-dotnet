using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DropletAutoscale
{
    [JsiiInterface(nativeType: typeof(IDropletAutoscaleDropletTemplate), fullyQualifiedName: "digitalocean.dropletAutoscale.DropletAutoscaleDropletTemplate")]
    public interface IDropletAutoscaleDropletTemplate
    {
        /// <summary>Droplet image.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#image DropletAutoscale#image}
        /// </remarks>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        string Image
        {
            get;
        }

        /// <summary>Droplet region.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#region DropletAutoscale#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        /// <summary>Droplet size.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#size DropletAutoscale#size}
        /// </remarks>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}")]
        string Size
        {
            get;
        }

        /// <summary>Droplet SSH keys.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#ssh_keys DropletAutoscale#ssh_keys}
        /// </remarks>
        [JsiiProperty(name: "sshKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SshKeys
        {
            get;
        }

        /// <summary>Enable droplet IPv6.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#ipv6 DropletAutoscale#ipv6}
        /// </remarks>
        [JsiiProperty(name: "ipv6", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ipv6
        {
            get
            {
                return null;
            }
        }

        /// <summary>Droplet project ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#project_id DropletAutoscale#project_id}
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

        /// <summary>Enables public networking for the Droplet.</summary>
        /// <remarks>
        /// By default, this is always enabled on new Droplets, but by explicitly setting it to false, you can create a Droplet with public networking entirely disabled.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#public_networking DropletAutoscale#public_networking}
        /// </remarks>
        [JsiiProperty(name: "publicNetworking", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublicNetworking
        {
            get
            {
                return null;
            }
        }

        /// <summary>Droplet tags.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#tags DropletAutoscale#tags}
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

        /// <summary>Droplet user data.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#user_data DropletAutoscale#user_data}
        /// </remarks>
        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Droplet VPC UUID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#vpc_uuid DropletAutoscale#vpc_uuid}
        /// </remarks>
        [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpcUuid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable droplet agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#with_droplet_agent DropletAutoscale#with_droplet_agent}
        /// </remarks>
        [JsiiProperty(name: "withDropletAgent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WithDropletAgent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDropletAutoscaleDropletTemplate), fullyQualifiedName: "digitalocean.dropletAutoscale.DropletAutoscaleDropletTemplate")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DropletAutoscale.IDropletAutoscaleDropletTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Droplet image.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#image DropletAutoscale#image}
            /// </remarks>
            [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
            public string Image
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Droplet region.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#region DropletAutoscale#region}
            /// </remarks>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Droplet size.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#size DropletAutoscale#size}
            /// </remarks>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}")]
            public string Size
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Droplet SSH keys.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#ssh_keys DropletAutoscale#ssh_keys}
            /// </remarks>
            [JsiiProperty(name: "sshKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SshKeys
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Enable droplet IPv6.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#ipv6 DropletAutoscale#ipv6}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Ipv6
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Droplet project ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#project_id DropletAutoscale#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enables public networking for the Droplet.</summary>
            /// <remarks>
            /// By default, this is always enabled on new Droplets, but by explicitly setting it to false, you can create a Droplet with public networking entirely disabled.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#public_networking DropletAutoscale#public_networking}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicNetworking", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PublicNetworking
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Droplet tags.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#tags DropletAutoscale#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Droplet user data.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#user_data DropletAutoscale#user_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserData
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Droplet VPC UUID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#vpc_uuid DropletAutoscale#vpc_uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcUuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enable droplet agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#with_droplet_agent DropletAutoscale#with_droplet_agent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "withDropletAgent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? WithDropletAgent
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
