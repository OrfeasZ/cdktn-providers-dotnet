using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecEnv), fullyQualifiedName: "digitalocean.app.AppSpecEnv")]
    public interface IAppSpecEnv
    {
        /// <summary>The name of the environment variable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#key App#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Key
        {
            get
            {
                return null;
            }
        }

        /// <summary>The visibility scope of the environment variable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#scope App#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Scope
        {
            get
            {
                return null;
            }
        }

        /// <summary>The type of the environment variable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#type App#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>The value of the environment variable.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#value App#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecEnv), fullyQualifiedName: "digitalocean.app.AppSpecEnv")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecEnv
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the environment variable.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#key App#key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Key
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The visibility scope of the environment variable.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#scope App#scope}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Scope
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The type of the environment variable.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#type App#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The value of the environment variable.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#value App#value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
