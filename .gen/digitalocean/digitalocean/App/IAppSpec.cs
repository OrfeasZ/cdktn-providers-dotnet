using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpec), fullyQualifiedName: "digitalocean.app.AppSpec")]
    public interface IAppSpec
    {
        /// <summary>The name of the app. Must be unique across all apps in the same account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#name App#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>alert block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#alert App#alert}
        /// </remarks>
        [JsiiProperty(name: "alert", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecAlert\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Alert
        {
            get
            {
                return null;
            }
        }

        /// <summary>database block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#database App#database}
        /// </remarks>
        [JsiiProperty(name: "database", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecDatabase\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Database
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to disable the edge cache for the app. Default is false, which enables the edge cache.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#disable_edge_cache App#disable_edge_cache}
        /// </remarks>
        [JsiiProperty(name: "disableEdgeCache", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableEdgeCache
        {
            get
            {
                return null;
            }
        }

        /// <summary>Email obfuscation configuration for the app. Default is false, which keeps the email obfuscated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#disable_email_obfuscation App#disable_email_obfuscation}
        /// </remarks>
        [JsiiProperty(name: "disableEmailObfuscation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableEmailObfuscation
        {
            get
            {
                return null;
            }
        }

        /// <summary>domain block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#domain App#domain}
        /// </remarks>
        [JsiiProperty(name: "domain", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecDomain\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Domain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#domains App#domains}.</summary>
        [JsiiProperty(name: "domains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Domains
        {
            get
            {
                return null;
            }
        }

        /// <summary>egress block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#egress App#egress}
        /// </remarks>
        [JsiiProperty(name: "egress", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecEgress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Egress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to enable enhanced threat control for the app.</summary>
        /// <remarks>
        /// Default is false. Set to true to enable enhanced threat control, putting additional security measures for Layer 7 DDoS attacks.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#enhanced_threat_control_enabled App#enhanced_threat_control_enabled}
        /// </remarks>
        [JsiiProperty(name: "enhancedThreatControlEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnhancedThreatControlEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>env block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#env App#env}
        /// </remarks>
        [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Env
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of features which is applied to the app.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#features App#features}
        /// </remarks>
        [JsiiProperty(name: "features", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Features
        {
            get
            {
                return null;
            }
        }

        /// <summary>function block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#function App#function}
        /// </remarks>
        [JsiiProperty(name: "function", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Function
        {
            get
            {
                return null;
            }
        }

        /// <summary>ingress block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#ingress App#ingress}
        /// </remarks>
        [JsiiProperty(name: "ingress", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecIngress? Ingress
        {
            get
            {
                return null;
            }
        }

        /// <summary>job block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#job App#job}
        /// </remarks>
        [JsiiProperty(name: "job", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecJob\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Job
        {
            get
            {
                return null;
            }
        }

        /// <summary>maintenance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#maintenance App#maintenance}
        /// </remarks>
        [JsiiProperty(name: "maintenance", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecMaintenance\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        digitalocean.App.IAppSpecMaintenance? Maintenance
        {
            get
            {
                return null;
            }
        }

        /// <summary>The slug for the DigitalOcean data center region hosting the app.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#region App#region}
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

        /// <summary>service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#service App#service}
        /// </remarks>
        [JsiiProperty(name: "service", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecService\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Service
        {
            get
            {
                return null;
            }
        }

        /// <summary>static_site block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#static_site App#static_site}
        /// </remarks>
        [JsiiProperty(name: "staticSite", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecStaticSite\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StaticSite
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#vpc App#vpc}
        /// </remarks>
        [JsiiProperty(name: "vpc", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecVpc\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Vpc
        {
            get
            {
                return null;
            }
        }

        /// <summary>worker block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#worker App#worker}
        /// </remarks>
        [JsiiProperty(name: "worker", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecWorker\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Worker
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpec), fullyQualifiedName: "digitalocean.app.AppSpec")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the app. Must be unique across all apps in the same account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#name App#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>alert block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#alert App#alert}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alert", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecAlert\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Alert
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>database block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#database App#database}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "database", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecDatabase\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Database
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to disable the edge cache for the app. Default is false, which enables the edge cache.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#disable_edge_cache App#disable_edge_cache}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableEdgeCache", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableEdgeCache
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Email obfuscation configuration for the app. Default is false, which keeps the email obfuscated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#disable_email_obfuscation App#disable_email_obfuscation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disableEmailObfuscation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableEmailObfuscation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>domain block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#domain App#domain}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "domain", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecDomain\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Domain
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#domains App#domains}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Domains
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>egress block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#egress App#egress}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "egress", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecEgress\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Egress
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to enable enhanced threat control for the app.</summary>
            /// <remarks>
            /// Default is false. Set to true to enable enhanced threat control, putting additional security measures for Layer 7 DDoS attacks.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#enhanced_threat_control_enabled App#enhanced_threat_control_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enhancedThreatControlEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnhancedThreatControlEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>env block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#env App#env}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Env
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>List of features which is applied to the app.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#features App#features}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "features", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Features
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>function block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#function App#function}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "function", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecFunction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Function
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ingress block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#ingress App#ingress}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ingress", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngress\"}", isOptional: true)]
            public digitalocean.App.IAppSpecIngress? Ingress
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecIngress?>();
            }

            /// <summary>job block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#job App#job}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "job", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecJob\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Job
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>maintenance block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#maintenance App#maintenance}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenance", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecMaintenance\"}", isOptional: true)]
            public digitalocean.App.IAppSpecMaintenance? Maintenance
            {
                get => GetInstanceProperty<digitalocean.App.IAppSpecMaintenance?>();
            }

            /// <summary>The slug for the DigitalOcean data center region hosting the app.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#region App#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#service App#service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "service", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecService\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Service
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>static_site block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#static_site App#static_site}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "staticSite", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecStaticSite\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StaticSite
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>vpc block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#vpc App#vpc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpc", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecVpc\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Vpc
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>worker block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#worker App#worker}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "worker", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecWorker\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Worker
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
