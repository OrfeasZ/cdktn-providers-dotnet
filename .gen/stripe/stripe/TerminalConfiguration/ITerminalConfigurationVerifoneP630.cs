using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalConfiguration
{
    [JsiiInterface(nativeType: typeof(ITerminalConfigurationVerifoneP630), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationVerifoneP630")]
    public interface ITerminalConfigurationVerifoneP630
    {
        /// <summary>A File ID representing an image to display on the reader.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#splashscreen TerminalConfiguration#splashscreen}
        /// </remarks>
        [JsiiProperty(name: "splashscreen", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Splashscreen
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITerminalConfigurationVerifoneP630), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationVerifoneP630")]
        internal sealed class _Proxy : DeputyBase, stripe.TerminalConfiguration.ITerminalConfigurationVerifoneP630
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A File ID representing an image to display on the reader.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#splashscreen TerminalConfiguration#splashscreen}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "splashscreen", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Splashscreen
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
