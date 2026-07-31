using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Microdroplet
{
    [JsiiInterface(nativeType: typeof(IMicrodropletConfig), fullyQualifiedName: "digitalocean.microdroplet.MicrodropletConfig")]
    public interface IMicrodropletConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>MicroDroplet image UUID or URN.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#image Microdroplet#image}
        /// </remarks>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        string Image
        {
            get;
        }

        /// <summary>Name of the MicroDroplet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#name Microdroplet#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>DigitalOcean region slug where the MicroDroplet is deployed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#region Microdroplet#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        /// <summary>MicroDroplet size slug.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#size Microdroplet#size}
        /// </remarks>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}")]
        string Size
        {
            get;
        }

        /// <summary>auto_pause block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#auto_pause Microdroplet#auto_pause}
        /// </remarks>
        [JsiiProperty(name: "autoPause", typeJson: "{\"fqn\":\"digitalocean.microdroplet.MicrodropletAutoPause\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.Microdroplet.IMicrodropletAutoPause? AutoPause
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the MicroDroplet should auto-resume on request.</summary>
        /// <remarks>
        /// Forces recreation on change: the MicroDroplets API has no in-place update path for auto_resume.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#auto_resume Microdroplet#auto_resume}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "autoResume", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoResume
        {
            get
            {
                return null;
            }
        }

        /// <summary>Environment variables passed to the MicroDroplet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#environment Microdroplet#environment}
        /// </remarks>
        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Environment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Port the MicroDroplet exposes over HTTP.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#http_port Microdroplet#http_port}
        /// </remarks>
        [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>HTTP protocol: 'http' or 'http2'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#http_protocol Microdroplet#http_protocol}
        /// </remarks>
        [JsiiProperty(name: "httpProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpProtocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#id Microdroplet#id}.</summary>
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

        /// <summary>Networking mode: 'public' or 'vpc'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#networking Microdroplet#networking}
        /// </remarks>
        [JsiiProperty(name: "networking", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Networking
        {
            get
            {
                return null;
            }
        }

        /// <summary>Desired lifecycle state: 'running' or 'paused'. Changes are applied by calling the microdroplet pause / resume action endpoints.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#state Microdroplet#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#tags Microdroplet#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#timeouts Microdroplet#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"digitalocean.microdroplet.MicrodropletTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.Microdroplet.IMicrodropletTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>UUID of the VPC to attach the MicroDroplet to. Only valid when networking is 'vpc'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#vpc_uuid Microdroplet#vpc_uuid}
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

        [JsiiTypeProxy(nativeType: typeof(IMicrodropletConfig), fullyQualifiedName: "digitalocean.microdroplet.MicrodropletConfig")]
        internal sealed class _Proxy : DeputyBase, digitalocean.Microdroplet.IMicrodropletConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>MicroDroplet image UUID or URN.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#image Microdroplet#image}
            /// </remarks>
            [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
            public string Image
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name of the MicroDroplet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#name Microdroplet#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>DigitalOcean region slug where the MicroDroplet is deployed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#region Microdroplet#region}
            /// </remarks>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>MicroDroplet size slug.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#size Microdroplet#size}
            /// </remarks>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}")]
            public string Size
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>auto_pause block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#auto_pause Microdroplet#auto_pause}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoPause", typeJson: "{\"fqn\":\"digitalocean.microdroplet.MicrodropletAutoPause\"}", isOptional: true)]
            public digitalocean.Microdroplet.IMicrodropletAutoPause? AutoPause
            {
                get => GetInstanceProperty<digitalocean.Microdroplet.IMicrodropletAutoPause?>();
            }

            /// <summary>Whether the MicroDroplet should auto-resume on request.</summary>
            /// <remarks>
            /// Forces recreation on change: the MicroDroplets API has no in-place update path for auto_resume.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#auto_resume Microdroplet#auto_resume}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoResume", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AutoResume
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Environment variables passed to the MicroDroplet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#environment Microdroplet#environment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Environment
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Port the MicroDroplet exposes over HTTP.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#http_port Microdroplet#http_port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>HTTP protocol: 'http' or 'http2'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#http_protocol Microdroplet#http_protocol}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpProtocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#id Microdroplet#id}.</summary>
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

            /// <summary>Networking mode: 'public' or 'vpc'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#networking Microdroplet#networking}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networking", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Networking
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Desired lifecycle state: 'running' or 'paused'. Changes are applied by calling the microdroplet pause / resume action endpoints.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#state Microdroplet#state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#tags Microdroplet#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#timeouts Microdroplet#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"digitalocean.microdroplet.MicrodropletTimeouts\"}", isOptional: true)]
            public digitalocean.Microdroplet.IMicrodropletTimeouts? Timeouts
            {
                get => GetInstanceProperty<digitalocean.Microdroplet.IMicrodropletTimeouts?>();
            }

            /// <summary>UUID of the VPC to attach the MicroDroplet to. Only valid when networking is 'vpc'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#vpc_uuid Microdroplet#vpc_uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcUuid
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
