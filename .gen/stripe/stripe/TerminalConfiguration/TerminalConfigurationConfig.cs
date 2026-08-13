using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalConfiguration
{
    [JsiiByValue(fqn: "stripe.terminalConfiguration.TerminalConfigurationConfig")]
    public class TerminalConfigurationConfig : stripe.TerminalConfiguration.ITerminalConfigurationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#bbpos_wisepad3 TerminalConfiguration#bbpos_wisepad3}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bbposWisepad3", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationBbposWisepad3\"}", isOptional: true)]
        public stripe.TerminalConfiguration.ITerminalConfigurationBbposWisepad3? BbposWisepad3
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#bbpos_wisepos_e TerminalConfiguration#bbpos_wisepos_e}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bbposWiseposE", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationBbposWiseposE\"}", isOptional: true)]
        public stripe.TerminalConfiguration.ITerminalConfigurationBbposWiseposE? BbposWiseposE
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#cellular TerminalConfiguration#cellular}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cellular", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationCellular\"}", isOptional: true)]
        public stripe.TerminalConfiguration.ITerminalConfigurationCellular? Cellular
        {
            get;
            set;
        }

        /// <summary>String indicating the name of the Configuration object, set by the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#name TerminalConfiguration#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#offline TerminalConfiguration#offline}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "offline", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationOffline\"}", isOptional: true)]
        public stripe.TerminalConfiguration.ITerminalConfigurationOffline? Offline
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#reboot_window TerminalConfiguration#reboot_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rebootWindow", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationRebootWindow\"}", isOptional: true)]
        public stripe.TerminalConfiguration.ITerminalConfigurationRebootWindow? RebootWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#stripe_s700 TerminalConfiguration#stripe_s700}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stripeS700", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationStripeS700\"}", isOptional: true)]
        public stripe.TerminalConfiguration.ITerminalConfigurationStripeS700? StripeS700
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#stripe_s710 TerminalConfiguration#stripe_s710}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stripeS710", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationStripeS710\"}", isOptional: true)]
        public stripe.TerminalConfiguration.ITerminalConfigurationStripeS710? StripeS710
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#tipping TerminalConfiguration#tipping}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tipping", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTipping\"}", isOptional: true)]
        public stripe.TerminalConfiguration.ITerminalConfigurationTipping? Tipping
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#verifone_m425 TerminalConfiguration#verifone_m425}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verifoneM425", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneM425\"}", isOptional: true)]
        public stripe.TerminalConfiguration.ITerminalConfigurationVerifoneM425? VerifoneM425
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#verifone_p400 TerminalConfiguration#verifone_p400}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verifoneP400", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneP400\"}", isOptional: true)]
        public stripe.TerminalConfiguration.ITerminalConfigurationVerifoneP400? VerifoneP400
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#verifone_p630 TerminalConfiguration#verifone_p630}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verifoneP630", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneP630\"}", isOptional: true)]
        public stripe.TerminalConfiguration.ITerminalConfigurationVerifoneP630? VerifoneP630
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#verifone_ux700 TerminalConfiguration#verifone_ux700}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verifoneUx700", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneUx700\"}", isOptional: true)]
        public stripe.TerminalConfiguration.ITerminalConfigurationVerifoneUx700? VerifoneUx700
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#verifone_v660p TerminalConfiguration#verifone_v660p}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verifoneV660P", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneV660P\"}", isOptional: true)]
        public stripe.TerminalConfiguration.ITerminalConfigurationVerifoneV660P? VerifoneV660P
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#wifi TerminalConfiguration#wifi}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "wifi", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifi\"}", isOptional: true)]
        public stripe.TerminalConfiguration.ITerminalConfigurationWifi? Wifi
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
