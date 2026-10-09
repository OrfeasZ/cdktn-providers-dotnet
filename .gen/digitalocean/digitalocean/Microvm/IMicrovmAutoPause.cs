using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Microvm
{
    [JsiiInterface(nativeType: typeof(IMicrovmAutoPause), fullyQualifiedName: "digitalocean.microvm.MicrovmAutoPause")]
    public interface IMicrovmAutoPause
    {
        /// <summary>Whether auto-pause is enabled. Forces recreation on change (no in-place API path).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/microvm#enabled Microvm#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Idle timeout as a Go duration string (e.g. '5m', '30s'). Forces recreation on change (no in-place API path).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/microvm#idle_timeout Microvm#idle_timeout}
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

        [JsiiTypeProxy(nativeType: typeof(IMicrovmAutoPause), fullyQualifiedName: "digitalocean.microvm.MicrovmAutoPause")]
        internal sealed class _Proxy : DeputyBase, digitalocean.Microvm.IMicrovmAutoPause
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether auto-pause is enabled. Forces recreation on change (no in-place API path).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/microvm#enabled Microvm#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Idle timeout as a Go duration string (e.g. '5m', '30s'). Forces recreation on change (no in-place API path).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/microvm#idle_timeout Microvm#idle_timeout}
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
