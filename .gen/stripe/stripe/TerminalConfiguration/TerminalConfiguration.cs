using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration stripe_terminal_configuration}.</summary>
    [JsiiClass(nativeType: typeof(stripe.TerminalConfiguration.TerminalConfiguration), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationConfig\"}}]")]
    public class TerminalConfiguration : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration stripe_terminal_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public TerminalConfiguration(Constructs.Construct scope, string id, stripe.TerminalConfiguration.ITerminalConfigurationConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.TerminalConfiguration.ITerminalConfigurationConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TerminalConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TerminalConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a TerminalConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the TerminalConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing TerminalConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the TerminalConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the TerminalConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing TerminalConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the TerminalConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.TerminalConfiguration.TerminalConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBbposWisepad3", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationBbposWisepad3\"}}]")]
        public virtual void PutBbposWisepad3(stripe.TerminalConfiguration.ITerminalConfigurationBbposWisepad3 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationBbposWisepad3)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBbposWiseposE", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationBbposWiseposE\"}}]")]
        public virtual void PutBbposWiseposE(stripe.TerminalConfiguration.ITerminalConfigurationBbposWiseposE @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationBbposWiseposE)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCellular", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationCellular\"}}]")]
        public virtual void PutCellular(stripe.TerminalConfiguration.ITerminalConfigurationCellular @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationCellular)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOffline", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationOffline\"}}]")]
        public virtual void PutOffline(stripe.TerminalConfiguration.ITerminalConfigurationOffline @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationOffline)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRebootWindow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationRebootWindow\"}}]")]
        public virtual void PutRebootWindow(stripe.TerminalConfiguration.ITerminalConfigurationRebootWindow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationRebootWindow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStripeS700", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationStripeS700\"}}]")]
        public virtual void PutStripeS700(stripe.TerminalConfiguration.ITerminalConfigurationStripeS700 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationStripeS700)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStripeS710", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationStripeS710\"}}]")]
        public virtual void PutStripeS710(stripe.TerminalConfiguration.ITerminalConfigurationStripeS710 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationStripeS710)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTipping", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTipping\"}}]")]
        public virtual void PutTipping(stripe.TerminalConfiguration.ITerminalConfigurationTipping @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTipping)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVerifoneM425", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneM425\"}}]")]
        public virtual void PutVerifoneM425(stripe.TerminalConfiguration.ITerminalConfigurationVerifoneM425 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationVerifoneM425)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVerifoneP400", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneP400\"}}]")]
        public virtual void PutVerifoneP400(stripe.TerminalConfiguration.ITerminalConfigurationVerifoneP400 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationVerifoneP400)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVerifoneP630", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneP630\"}}]")]
        public virtual void PutVerifoneP630(stripe.TerminalConfiguration.ITerminalConfigurationVerifoneP630 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationVerifoneP630)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVerifoneUx700", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneUx700\"}}]")]
        public virtual void PutVerifoneUx700(stripe.TerminalConfiguration.ITerminalConfigurationVerifoneUx700 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationVerifoneUx700)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVerifoneV660P", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneV660P\"}}]")]
        public virtual void PutVerifoneV660P(stripe.TerminalConfiguration.ITerminalConfigurationVerifoneV660P @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationVerifoneV660P)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWifi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifi\"}}]")]
        public virtual void PutWifi(stripe.TerminalConfiguration.ITerminalConfigurationWifi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationWifi)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBbposWisepad3")]
        public virtual void ResetBbposWisepad3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBbposWiseposE")]
        public virtual void ResetBbposWiseposE()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCellular")]
        public virtual void ResetCellular()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOffline")]
        public virtual void ResetOffline()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRebootWindow")]
        public virtual void ResetRebootWindow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStripeS700")]
        public virtual void ResetStripeS700()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStripeS710")]
        public virtual void ResetStripeS710()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTipping")]
        public virtual void ResetTipping()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerifoneM425")]
        public virtual void ResetVerifoneM425()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerifoneP400")]
        public virtual void ResetVerifoneP400()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerifoneP630")]
        public virtual void ResetVerifoneP630()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerifoneUx700")]
        public virtual void ResetVerifoneUx700()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerifoneV660P")]
        public virtual void ResetVerifoneV660P()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWifi")]
        public virtual void ResetWifi()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(stripe.TerminalConfiguration.TerminalConfiguration))!;

        [JsiiProperty(name: "bbposWisepad3", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationBbposWisepad3OutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationBbposWisepad3OutputReference BbposWisepad3
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationBbposWisepad3OutputReference>()!;
        }

        [JsiiProperty(name: "bbposWiseposE", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationBbposWiseposEOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationBbposWiseposEOutputReference BbposWiseposE
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationBbposWiseposEOutputReference>()!;
        }

        [JsiiProperty(name: "cellular", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationCellularOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationCellularOutputReference Cellular
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationCellularOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAccountDefault", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAccountDefault
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "livemode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Livemode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "offline", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationOfflineOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationOfflineOutputReference Offline
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationOfflineOutputReference>()!;
        }

        [JsiiProperty(name: "rebootWindow", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationRebootWindowOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationRebootWindowOutputReference RebootWindow
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationRebootWindowOutputReference>()!;
        }

        [JsiiProperty(name: "stripeS700", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationStripeS700OutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationStripeS700OutputReference StripeS700
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationStripeS700OutputReference>()!;
        }

        [JsiiProperty(name: "stripeS710", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationStripeS710OutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationStripeS710OutputReference StripeS710
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationStripeS710OutputReference>()!;
        }

        [JsiiProperty(name: "tipping", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingOutputReference Tipping
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingOutputReference>()!;
        }

        [JsiiProperty(name: "verifoneM425", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneM425OutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationVerifoneM425OutputReference VerifoneM425
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationVerifoneM425OutputReference>()!;
        }

        [JsiiProperty(name: "verifoneP400", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneP400OutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationVerifoneP400OutputReference VerifoneP400
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationVerifoneP400OutputReference>()!;
        }

        [JsiiProperty(name: "verifoneP630", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneP630OutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationVerifoneP630OutputReference VerifoneP630
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationVerifoneP630OutputReference>()!;
        }

        [JsiiProperty(name: "verifoneUx700", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneUx700OutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationVerifoneUx700OutputReference VerifoneUx700
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationVerifoneUx700OutputReference>()!;
        }

        [JsiiProperty(name: "verifoneV660P", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneV660POutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationVerifoneV660POutputReference VerifoneV660P
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationVerifoneV660POutputReference>()!;
        }

        [JsiiProperty(name: "wifi", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifiOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationWifiOutputReference Wifi
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationWifiOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationBbposWisepad3" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bbposWisepad3Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationBbposWisepad3\"}]}}", isOptional: true)]
        public virtual object? BbposWisepad3Input
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationBbposWiseposE" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bbposWiseposEInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationBbposWiseposE\"}]}}", isOptional: true)]
        public virtual object? BbposWiseposEInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationCellular" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cellularInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationCellular\"}]}}", isOptional: true)]
        public virtual object? CellularInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationOffline" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "offlineInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationOffline\"}]}}", isOptional: true)]
        public virtual object? OfflineInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationRebootWindow" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rebootWindowInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationRebootWindow\"}]}}", isOptional: true)]
        public virtual object? RebootWindowInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationStripeS700" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stripeS700Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationStripeS700\"}]}}", isOptional: true)]
        public virtual object? StripeS700Input
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationStripeS710" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stripeS710Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationStripeS710\"}]}}", isOptional: true)]
        public virtual object? StripeS710Input
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTipping" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tippingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTipping\"}]}}", isOptional: true)]
        public virtual object? TippingInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationVerifoneM425" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verifoneM425Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneM425\"}]}}", isOptional: true)]
        public virtual object? VerifoneM425Input
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationVerifoneP400" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verifoneP400Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneP400\"}]}}", isOptional: true)]
        public virtual object? VerifoneP400Input
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationVerifoneP630" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verifoneP630Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneP630\"}]}}", isOptional: true)]
        public virtual object? VerifoneP630Input
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationVerifoneUx700" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verifoneUx700Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneUx700\"}]}}", isOptional: true)]
        public virtual object? VerifoneUx700Input
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationVerifoneV660P" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verifoneV660PInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationVerifoneV660P\"}]}}", isOptional: true)]
        public virtual object? VerifoneV660PInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationWifi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wifiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationWifi\"}]}}", isOptional: true)]
        public virtual object? WifiInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
