using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DropletAutoscale
{
    [JsiiInterface(nativeType: typeof(IDropletAutoscaleConfig), fullyQualifiedName: "digitalocean.dropletAutoscale.DropletAutoscaleConfig")]
    public interface IDropletAutoscaleConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet_autoscale#config DropletAutoscale#config}
        /// </remarks>
        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"digitalocean.dropletAutoscale.DropletAutoscaleConfigA\"}")]
        digitalocean.DropletAutoscale.IDropletAutoscaleConfigA Config
        {
            get;
        }

        /// <summary>droplet_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet_autoscale#droplet_template DropletAutoscale#droplet_template}
        /// </remarks>
        [JsiiProperty(name: "dropletTemplate", typeJson: "{\"fqn\":\"digitalocean.dropletAutoscale.DropletAutoscaleDropletTemplate\"}")]
        digitalocean.DropletAutoscale.IDropletAutoscaleDropletTemplate DropletTemplate
        {
            get;
        }

        /// <summary>Name of the Droplet autoscale pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet_autoscale#name DropletAutoscale#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDropletAutoscaleConfig), fullyQualifiedName: "digitalocean.dropletAutoscale.DropletAutoscaleConfig")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DropletAutoscale.IDropletAutoscaleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet_autoscale#config DropletAutoscale#config}
            /// </remarks>
            [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"digitalocean.dropletAutoscale.DropletAutoscaleConfigA\"}")]
            public digitalocean.DropletAutoscale.IDropletAutoscaleConfigA Config
            {
                get => GetInstanceProperty<digitalocean.DropletAutoscale.IDropletAutoscaleConfigA>()!;
            }

            /// <summary>droplet_template block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet_autoscale#droplet_template DropletAutoscale#droplet_template}
            /// </remarks>
            [JsiiProperty(name: "dropletTemplate", typeJson: "{\"fqn\":\"digitalocean.dropletAutoscale.DropletAutoscaleDropletTemplate\"}")]
            public digitalocean.DropletAutoscale.IDropletAutoscaleDropletTemplate DropletTemplate
            {
                get => GetInstanceProperty<digitalocean.DropletAutoscale.IDropletAutoscaleDropletTemplate>()!;
            }

            /// <summary>Name of the Droplet autoscale pool.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/droplet_autoscale#name DropletAutoscale#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
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
