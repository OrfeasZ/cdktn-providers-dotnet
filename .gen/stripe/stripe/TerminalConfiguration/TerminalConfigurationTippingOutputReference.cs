using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalConfiguration
{
    [JsiiClass(nativeType: typeof(stripe.TerminalConfiguration.TerminalConfigurationTippingOutputReference), fullyQualifiedName: "stripe.terminalConfiguration.TerminalConfigurationTippingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TerminalConfigurationTippingOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TerminalConfigurationTippingOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TerminalConfigurationTippingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TerminalConfigurationTippingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAed", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingAed\"}}]")]
        public virtual void PutAed(stripe.TerminalConfiguration.ITerminalConfigurationTippingAed @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingAed)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAud", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingAud\"}}]")]
        public virtual void PutAud(stripe.TerminalConfiguration.ITerminalConfigurationTippingAud @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingAud)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCad", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingCad\"}}]")]
        public virtual void PutCad(stripe.TerminalConfiguration.ITerminalConfigurationTippingCad @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingCad)}, new object[]{@value});
        }

        [JsiiMethod(name: "putChf", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingChf\"}}]")]
        public virtual void PutChf(stripe.TerminalConfiguration.ITerminalConfigurationTippingChf @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingChf)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCzk", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingCzk\"}}]")]
        public virtual void PutCzk(stripe.TerminalConfiguration.ITerminalConfigurationTippingCzk @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingCzk)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDkk", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingDkk\"}}]")]
        public virtual void PutDkk(stripe.TerminalConfiguration.ITerminalConfigurationTippingDkk @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingDkk)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEur", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingEur\"}}]")]
        public virtual void PutEur(stripe.TerminalConfiguration.ITerminalConfigurationTippingEur @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingEur)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGbp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingGbp\"}}]")]
        public virtual void PutGbp(stripe.TerminalConfiguration.ITerminalConfigurationTippingGbp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingGbp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGip", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingGip\"}}]")]
        public virtual void PutGip(stripe.TerminalConfiguration.ITerminalConfigurationTippingGip @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingGip)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHkd", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingHkd\"}}]")]
        public virtual void PutHkd(stripe.TerminalConfiguration.ITerminalConfigurationTippingHkd @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingHkd)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHuf", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingHuf\"}}]")]
        public virtual void PutHuf(stripe.TerminalConfiguration.ITerminalConfigurationTippingHuf @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingHuf)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJpy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingJpy\"}}]")]
        public virtual void PutJpy(stripe.TerminalConfiguration.ITerminalConfigurationTippingJpy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingJpy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMxn", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingMxn\"}}]")]
        public virtual void PutMxn(stripe.TerminalConfiguration.ITerminalConfigurationTippingMxn @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingMxn)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMyr", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingMyr\"}}]")]
        public virtual void PutMyr(stripe.TerminalConfiguration.ITerminalConfigurationTippingMyr @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingMyr)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNok", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingNok\"}}]")]
        public virtual void PutNok(stripe.TerminalConfiguration.ITerminalConfigurationTippingNok @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingNok)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNzd", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingNzd\"}}]")]
        public virtual void PutNzd(stripe.TerminalConfiguration.ITerminalConfigurationTippingNzd @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingNzd)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPln", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingPln\"}}]")]
        public virtual void PutPln(stripe.TerminalConfiguration.ITerminalConfigurationTippingPln @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingPln)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRon", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingRon\"}}]")]
        public virtual void PutRon(stripe.TerminalConfiguration.ITerminalConfigurationTippingRon @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingRon)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSek", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingSek\"}}]")]
        public virtual void PutSek(stripe.TerminalConfiguration.ITerminalConfigurationTippingSek @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingSek)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSgd", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingSgd\"}}]")]
        public virtual void PutSgd(stripe.TerminalConfiguration.ITerminalConfigurationTippingSgd @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingSgd)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUsd", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingUsd\"}}]")]
        public virtual void PutUsd(stripe.TerminalConfiguration.ITerminalConfigurationTippingUsd @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.TerminalConfiguration.ITerminalConfigurationTippingUsd)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAed")]
        public virtual void ResetAed()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAud")]
        public virtual void ResetAud()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCad")]
        public virtual void ResetCad()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChf")]
        public virtual void ResetChf()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCzk")]
        public virtual void ResetCzk()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDkk")]
        public virtual void ResetDkk()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEur")]
        public virtual void ResetEur()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGbp")]
        public virtual void ResetGbp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGip")]
        public virtual void ResetGip()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHkd")]
        public virtual void ResetHkd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHuf")]
        public virtual void ResetHuf()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJpy")]
        public virtual void ResetJpy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMxn")]
        public virtual void ResetMxn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMyr")]
        public virtual void ResetMyr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNok")]
        public virtual void ResetNok()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNzd")]
        public virtual void ResetNzd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPln")]
        public virtual void ResetPln()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRon")]
        public virtual void ResetRon()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSek")]
        public virtual void ResetSek()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSgd")]
        public virtual void ResetSgd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsd")]
        public virtual void ResetUsd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "aed", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingAedOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingAedOutputReference Aed
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingAedOutputReference>()!;
        }

        [JsiiProperty(name: "aud", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingAudOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingAudOutputReference Aud
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingAudOutputReference>()!;
        }

        [JsiiProperty(name: "cad", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingCadOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingCadOutputReference Cad
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingCadOutputReference>()!;
        }

        [JsiiProperty(name: "chf", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingChfOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingChfOutputReference Chf
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingChfOutputReference>()!;
        }

        [JsiiProperty(name: "czk", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingCzkOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingCzkOutputReference Czk
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingCzkOutputReference>()!;
        }

        [JsiiProperty(name: "dkk", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingDkkOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingDkkOutputReference Dkk
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingDkkOutputReference>()!;
        }

        [JsiiProperty(name: "eur", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingEurOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingEurOutputReference Eur
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingEurOutputReference>()!;
        }

        [JsiiProperty(name: "gbp", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingGbpOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingGbpOutputReference Gbp
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingGbpOutputReference>()!;
        }

        [JsiiProperty(name: "gip", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingGipOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingGipOutputReference Gip
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingGipOutputReference>()!;
        }

        [JsiiProperty(name: "hkd", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingHkdOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingHkdOutputReference Hkd
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingHkdOutputReference>()!;
        }

        [JsiiProperty(name: "huf", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingHufOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingHufOutputReference Huf
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingHufOutputReference>()!;
        }

        [JsiiProperty(name: "jpy", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingJpyOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingJpyOutputReference Jpy
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingJpyOutputReference>()!;
        }

        [JsiiProperty(name: "mxn", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingMxnOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingMxnOutputReference Mxn
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingMxnOutputReference>()!;
        }

        [JsiiProperty(name: "myr", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingMyrOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingMyrOutputReference Myr
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingMyrOutputReference>()!;
        }

        [JsiiProperty(name: "nok", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingNokOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingNokOutputReference Nok
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingNokOutputReference>()!;
        }

        [JsiiProperty(name: "nzd", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingNzdOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingNzdOutputReference Nzd
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingNzdOutputReference>()!;
        }

        [JsiiProperty(name: "pln", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingPlnOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingPlnOutputReference Pln
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingPlnOutputReference>()!;
        }

        [JsiiProperty(name: "ron", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingRonOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingRonOutputReference Ron
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingRonOutputReference>()!;
        }

        [JsiiProperty(name: "sek", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingSekOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingSekOutputReference Sek
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingSekOutputReference>()!;
        }

        [JsiiProperty(name: "sgd", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingSgdOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingSgdOutputReference Sgd
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingSgdOutputReference>()!;
        }

        [JsiiProperty(name: "usd", typeJson: "{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingUsdOutputReference\"}")]
        public virtual stripe.TerminalConfiguration.TerminalConfigurationTippingUsdOutputReference Usd
        {
            get => GetInstanceProperty<stripe.TerminalConfiguration.TerminalConfigurationTippingUsdOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingAed" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aedInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingAed\"}]}}", isOptional: true)]
        public virtual object? AedInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingAud" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "audInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingAud\"}]}}", isOptional: true)]
        public virtual object? AudInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingCad" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cadInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingCad\"}]}}", isOptional: true)]
        public virtual object? CadInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingChf" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "chfInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingChf\"}]}}", isOptional: true)]
        public virtual object? ChfInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingCzk" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "czkInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingCzk\"}]}}", isOptional: true)]
        public virtual object? CzkInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingDkk" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dkkInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingDkk\"}]}}", isOptional: true)]
        public virtual object? DkkInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingEur" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eurInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingEur\"}]}}", isOptional: true)]
        public virtual object? EurInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingGbp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gbpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingGbp\"}]}}", isOptional: true)]
        public virtual object? GbpInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingGip" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gipInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingGip\"}]}}", isOptional: true)]
        public virtual object? GipInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingHkd" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hkdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingHkd\"}]}}", isOptional: true)]
        public virtual object? HkdInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingHuf" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hufInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingHuf\"}]}}", isOptional: true)]
        public virtual object? HufInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingJpy" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jpyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingJpy\"}]}}", isOptional: true)]
        public virtual object? JpyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingMxn" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mxnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingMxn\"}]}}", isOptional: true)]
        public virtual object? MxnInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingMyr" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "myrInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingMyr\"}]}}", isOptional: true)]
        public virtual object? MyrInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingNok" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nokInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingNok\"}]}}", isOptional: true)]
        public virtual object? NokInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingNzd" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nzdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingNzd\"}]}}", isOptional: true)]
        public virtual object? NzdInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingPln" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "plnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingPln\"}]}}", isOptional: true)]
        public virtual object? PlnInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingRon" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ronInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingRon\"}]}}", isOptional: true)]
        public virtual object? RonInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingSek" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sekInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingSek\"}]}}", isOptional: true)]
        public virtual object? SekInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingSgd" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sgdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingSgd\"}]}}", isOptional: true)]
        public virtual object? SgdInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTippingUsd" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTippingUsd\"}]}}", isOptional: true)]
        public virtual object? UsdInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.TerminalConfiguration.ITerminalConfigurationTipping" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.terminalConfiguration.TerminalConfigurationTipping\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.TerminalConfiguration.ITerminalConfigurationTipping cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.TerminalConfiguration.ITerminalConfigurationTipping).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
