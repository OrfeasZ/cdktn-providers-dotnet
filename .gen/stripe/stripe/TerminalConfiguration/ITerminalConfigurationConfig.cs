using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalConfiguration
{
    [JsiiInterface(nativeType: typeof(ITerminalConfigurationConfig), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationConfig")]
    public interface ITerminalConfigurationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#bbpos_wisepad3 TerminalConfiguration#bbpos_wisepad3}.</summary>
        [JsiiProperty(name: "bbposWisepad3", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationBbposWisepad3\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TerminalConfiguration.ITerminalConfigurationBbposWisepad3? BbposWisepad3
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#bbpos_wisepos_e TerminalConfiguration#bbpos_wisepos_e}.</summary>
        [JsiiProperty(name: "bbposWiseposE", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationBbposWiseposE\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TerminalConfiguration.ITerminalConfigurationBbposWiseposE? BbposWiseposE
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#cellular TerminalConfiguration#cellular}.</summary>
        [JsiiProperty(name: "cellular", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationCellular\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TerminalConfiguration.ITerminalConfigurationCellular? Cellular
        {
            get
            {
                return null;
            }
        }

        /// <summary>String indicating the name of the Configuration object, set by the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#name TerminalConfiguration#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#offline TerminalConfiguration#offline}.</summary>
        [JsiiProperty(name: "offline", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationOffline\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TerminalConfiguration.ITerminalConfigurationOffline? Offline
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#reboot_window TerminalConfiguration#reboot_window}.</summary>
        [JsiiProperty(name: "rebootWindow", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationRebootWindow\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TerminalConfiguration.ITerminalConfigurationRebootWindow? RebootWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#stripe_s700 TerminalConfiguration#stripe_s700}.</summary>
        [JsiiProperty(name: "stripeS700", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationStripeS700\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TerminalConfiguration.ITerminalConfigurationStripeS700? StripeS700
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#stripe_s710 TerminalConfiguration#stripe_s710}.</summary>
        [JsiiProperty(name: "stripeS710", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationStripeS710\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TerminalConfiguration.ITerminalConfigurationStripeS710? StripeS710
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#tipping TerminalConfiguration#tipping}.</summary>
        [JsiiProperty(name: "tipping", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTipping\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TerminalConfiguration.ITerminalConfigurationTipping? Tipping
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#verifone_m425 TerminalConfiguration#verifone_m425}.</summary>
        [JsiiProperty(name: "verifoneM425", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneM425\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TerminalConfiguration.ITerminalConfigurationVerifoneM425? VerifoneM425
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#verifone_p400 TerminalConfiguration#verifone_p400}.</summary>
        [JsiiProperty(name: "verifoneP400", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneP400\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TerminalConfiguration.ITerminalConfigurationVerifoneP400? VerifoneP400
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#verifone_p630 TerminalConfiguration#verifone_p630}.</summary>
        [JsiiProperty(name: "verifoneP630", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneP630\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TerminalConfiguration.ITerminalConfigurationVerifoneP630? VerifoneP630
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#verifone_ux700 TerminalConfiguration#verifone_ux700}.</summary>
        [JsiiProperty(name: "verifoneUx700", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneUx700\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TerminalConfiguration.ITerminalConfigurationVerifoneUx700? VerifoneUx700
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#verifone_v660p TerminalConfiguration#verifone_v660p}.</summary>
        [JsiiProperty(name: "verifoneV660P", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneV660P\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TerminalConfiguration.ITerminalConfigurationVerifoneV660P? VerifoneV660P
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#wifi TerminalConfiguration#wifi}.</summary>
        [JsiiProperty(name: "wifi", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.TerminalConfiguration.ITerminalConfigurationWifi? Wifi
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITerminalConfigurationConfig), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.TerminalConfiguration.ITerminalConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#bbpos_wisepad3 TerminalConfiguration#bbpos_wisepad3}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bbposWisepad3", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationBbposWisepad3\"}", isOptional: true)]
            public stripe.TerminalConfiguration.ITerminalConfigurationBbposWisepad3? BbposWisepad3
            {
                get => GetInstanceProperty<stripe.TerminalConfiguration.ITerminalConfigurationBbposWisepad3?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#bbpos_wisepos_e TerminalConfiguration#bbpos_wisepos_e}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bbposWiseposE", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationBbposWiseposE\"}", isOptional: true)]
            public stripe.TerminalConfiguration.ITerminalConfigurationBbposWiseposE? BbposWiseposE
            {
                get => GetInstanceProperty<stripe.TerminalConfiguration.ITerminalConfigurationBbposWiseposE?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#cellular TerminalConfiguration#cellular}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cellular", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationCellular\"}", isOptional: true)]
            public stripe.TerminalConfiguration.ITerminalConfigurationCellular? Cellular
            {
                get => GetInstanceProperty<stripe.TerminalConfiguration.ITerminalConfigurationCellular?>();
            }

            /// <summary>String indicating the name of the Configuration object, set by the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#name TerminalConfiguration#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#offline TerminalConfiguration#offline}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "offline", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationOffline\"}", isOptional: true)]
            public stripe.TerminalConfiguration.ITerminalConfigurationOffline? Offline
            {
                get => GetInstanceProperty<stripe.TerminalConfiguration.ITerminalConfigurationOffline?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#reboot_window TerminalConfiguration#reboot_window}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rebootWindow", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationRebootWindow\"}", isOptional: true)]
            public stripe.TerminalConfiguration.ITerminalConfigurationRebootWindow? RebootWindow
            {
                get => GetInstanceProperty<stripe.TerminalConfiguration.ITerminalConfigurationRebootWindow?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#stripe_s700 TerminalConfiguration#stripe_s700}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stripeS700", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationStripeS700\"}", isOptional: true)]
            public stripe.TerminalConfiguration.ITerminalConfigurationStripeS700? StripeS700
            {
                get => GetInstanceProperty<stripe.TerminalConfiguration.ITerminalConfigurationStripeS700?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#stripe_s710 TerminalConfiguration#stripe_s710}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stripeS710", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationStripeS710\"}", isOptional: true)]
            public stripe.TerminalConfiguration.ITerminalConfigurationStripeS710? StripeS710
            {
                get => GetInstanceProperty<stripe.TerminalConfiguration.ITerminalConfigurationStripeS710?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#tipping TerminalConfiguration#tipping}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tipping", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTipping\"}", isOptional: true)]
            public stripe.TerminalConfiguration.ITerminalConfigurationTipping? Tipping
            {
                get => GetInstanceProperty<stripe.TerminalConfiguration.ITerminalConfigurationTipping?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#verifone_m425 TerminalConfiguration#verifone_m425}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verifoneM425", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneM425\"}", isOptional: true)]
            public stripe.TerminalConfiguration.ITerminalConfigurationVerifoneM425? VerifoneM425
            {
                get => GetInstanceProperty<stripe.TerminalConfiguration.ITerminalConfigurationVerifoneM425?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#verifone_p400 TerminalConfiguration#verifone_p400}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verifoneP400", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneP400\"}", isOptional: true)]
            public stripe.TerminalConfiguration.ITerminalConfigurationVerifoneP400? VerifoneP400
            {
                get => GetInstanceProperty<stripe.TerminalConfiguration.ITerminalConfigurationVerifoneP400?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#verifone_p630 TerminalConfiguration#verifone_p630}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verifoneP630", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneP630\"}", isOptional: true)]
            public stripe.TerminalConfiguration.ITerminalConfigurationVerifoneP630? VerifoneP630
            {
                get => GetInstanceProperty<stripe.TerminalConfiguration.ITerminalConfigurationVerifoneP630?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#verifone_ux700 TerminalConfiguration#verifone_ux700}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verifoneUx700", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneUx700\"}", isOptional: true)]
            public stripe.TerminalConfiguration.ITerminalConfigurationVerifoneUx700? VerifoneUx700
            {
                get => GetInstanceProperty<stripe.TerminalConfiguration.ITerminalConfigurationVerifoneUx700?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#verifone_v660p TerminalConfiguration#verifone_v660p}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verifoneV660P", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneV660P\"}", isOptional: true)]
            public stripe.TerminalConfiguration.ITerminalConfigurationVerifoneV660P? VerifoneV660P
            {
                get => GetInstanceProperty<stripe.TerminalConfiguration.ITerminalConfigurationVerifoneV660P?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#wifi TerminalConfiguration#wifi}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "wifi", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifi\"}", isOptional: true)]
            public stripe.TerminalConfiguration.ITerminalConfigurationWifi? Wifi
            {
                get => GetInstanceProperty<stripe.TerminalConfiguration.ITerminalConfigurationWifi?>();
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
