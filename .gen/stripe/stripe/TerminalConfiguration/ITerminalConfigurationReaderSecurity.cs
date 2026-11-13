using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalConfiguration
{
    [JsiiInterface(nativeType: typeof(ITerminalConfigurationReaderSecurity), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationReaderSecurity")]
    public interface ITerminalConfigurationReaderSecurity
    {
        /// <summary>Passcode used to access a reader's admin menu.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/terminal_configuration#admin_menu_passcode TerminalConfiguration#admin_menu_passcode}
        /// </remarks>
        [JsiiProperty(name: "adminMenuPasscode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdminMenuPasscode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITerminalConfigurationReaderSecurity), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationReaderSecurity")]
        internal sealed class _Proxy : DeputyBase, stripe.TerminalConfiguration.ITerminalConfigurationReaderSecurity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Passcode used to access a reader's admin menu.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/terminal_configuration#admin_menu_passcode TerminalConfiguration#admin_menu_passcode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "adminMenuPasscode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdminMenuPasscode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
