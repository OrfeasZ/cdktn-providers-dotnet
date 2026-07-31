using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Microdroplet
{
    [JsiiInterface(nativeType: typeof(IMicrodropletAutoPause), fullyQualifiedName: "digitalocean.microdroplet.MicrodropletAutoPause")]
    public interface IMicrodropletAutoPause
    {
        /// <summary>Whether auto-pause is enabled. Forces recreation on change (no in-place API path).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#enabled Microdroplet#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Idle timeout as a Go duration string (e.g. '5m', '30s'). Forces recreation on change (no in-place API path).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#idle_timeout Microdroplet#idle_timeout}
        /// </remarks>
        [JsiiProperty(name: "idleTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdleTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMicrodropletAutoPause), fullyQualifiedName: "digitalocean.microdroplet.MicrodropletAutoPause")]
        internal sealed class _Proxy : DeputyBase, digitalocean.Microdroplet.IMicrodropletAutoPause
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether auto-pause is enabled. Forces recreation on change (no in-place API path).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#enabled Microdroplet#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Idle timeout as a Go duration string (e.g. '5m', '30s'). Forces recreation on change (no in-place API path).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/microdroplet#idle_timeout Microdroplet#idle_timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idleTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdleTimeout
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
