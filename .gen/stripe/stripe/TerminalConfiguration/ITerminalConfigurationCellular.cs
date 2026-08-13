using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalConfiguration
{
    [JsiiInterface(nativeType: typeof(ITerminalConfigurationCellular), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationCellular")]
    public interface ITerminalConfigurationCellular
    {
        /// <summary>Whether a cellular-capable reader can connect to the internet over cellular.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#enabled TerminalConfiguration#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITerminalConfigurationCellular), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationCellular")]
        internal sealed class _Proxy : DeputyBase, stripe.TerminalConfiguration.ITerminalConfigurationCellular
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether a cellular-capable reader can connect to the internet over cellular.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#enabled TerminalConfiguration#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
