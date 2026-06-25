using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainFeaturesHyperVOutputReference), fullyQualifiedName: "libvirt.domain.DomainFeaturesHyperVOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainFeaturesHyperVOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainFeaturesHyperVOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainFeaturesHyperVOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainFeaturesHyperVOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAvic", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVAvic\"}}]")]
        public virtual void PutAvic(libvirt.Domain.IDomainFeaturesHyperVAvic @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVAvic)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmsrBitmap", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVEmsrBitmap\"}}]")]
        public virtual void PutEmsrBitmap(libvirt.Domain.IDomainFeaturesHyperVEmsrBitmap @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVEmsrBitmap)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEvmcs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVEvmcs\"}}]")]
        public virtual void PutEvmcs(libvirt.Domain.IDomainFeaturesHyperVEvmcs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVEvmcs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFrequencies", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVFrequencies\"}}]")]
        public virtual void PutFrequencies(libvirt.Domain.IDomainFeaturesHyperVFrequencies @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVFrequencies)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIpi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVIpi\"}}]")]
        public virtual void PutIpi(libvirt.Domain.IDomainFeaturesHyperVIpi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVIpi)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReEnlightenment", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVReEnlightenment\"}}]")]
        public virtual void PutReEnlightenment(libvirt.Domain.IDomainFeaturesHyperVReEnlightenment @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVReEnlightenment)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRelaxed", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVRelaxed\"}}]")]
        public virtual void PutRelaxed(libvirt.Domain.IDomainFeaturesHyperVRelaxed @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVRelaxed)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReset", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVReset\"}}]")]
        public virtual void PutReset(libvirt.Domain.IDomainFeaturesHyperVReset @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVReset)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRuntime", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVRuntime\"}}]")]
        public virtual void PutRuntime(libvirt.Domain.IDomainFeaturesHyperVRuntime @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVRuntime)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpinlocks", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVSpinlocks\"}}]")]
        public virtual void PutSpinlocks(libvirt.Domain.IDomainFeaturesHyperVSpinlocks @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVSpinlocks)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStimer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVStimer\"}}]")]
        public virtual void PutStimer(libvirt.Domain.IDomainFeaturesHyperVStimer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVStimer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSynic", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVSynic\"}}]")]
        public virtual void PutSynic(libvirt.Domain.IDomainFeaturesHyperVSynic @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVSynic)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTlbFlush", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVTlbFlush\"}}]")]
        public virtual void PutTlbFlush(libvirt.Domain.IDomainFeaturesHyperVTlbFlush @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVTlbFlush)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVapic", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVVapic\"}}]")]
        public virtual void PutVapic(libvirt.Domain.IDomainFeaturesHyperVVapic @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVVapic)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVendorId", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVVendorId\"}}]")]
        public virtual void PutVendorId(libvirt.Domain.IDomainFeaturesHyperVVendorId @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVVendorId)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpIndex", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVVpIndex\"}}]")]
        public virtual void PutVpIndex(libvirt.Domain.IDomainFeaturesHyperVVpIndex @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVVpIndex)}, new object[]{@value});
        }

        [JsiiMethod(name: "putXmmInput", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVXmmInput\"}}]")]
        public virtual void PutXmmInput(libvirt.Domain.IDomainFeaturesHyperVXmmInput @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperVXmmInput)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAvic")]
        public virtual void ResetAvic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmsrBitmap")]
        public virtual void ResetEmsrBitmap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEvmcs")]
        public virtual void ResetEvmcs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFrequencies")]
        public virtual void ResetFrequencies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpi")]
        public virtual void ResetIpi()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMode")]
        public virtual void ResetMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReEnlightenment")]
        public virtual void ResetReEnlightenment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRelaxed")]
        public virtual void ResetRelaxed()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReset")]
        public virtual void ResetReset()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuntime")]
        public virtual void ResetRuntime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpinlocks")]
        public virtual void ResetSpinlocks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStimer")]
        public virtual void ResetStimer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSynic")]
        public virtual void ResetSynic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTlbFlush")]
        public virtual void ResetTlbFlush()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVapic")]
        public virtual void ResetVapic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVendorId")]
        public virtual void ResetVendorId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpIndex")]
        public virtual void ResetVpIndex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXmmInput")]
        public virtual void ResetXmmInput()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "avic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVAvicOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVAvicOutputReference Avic
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVAvicOutputReference>()!;
        }

        [JsiiProperty(name: "emsrBitmap", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVEmsrBitmapOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVEmsrBitmapOutputReference EmsrBitmap
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVEmsrBitmapOutputReference>()!;
        }

        [JsiiProperty(name: "evmcs", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVEvmcsOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVEvmcsOutputReference Evmcs
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVEvmcsOutputReference>()!;
        }

        [JsiiProperty(name: "frequencies", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVFrequenciesOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVFrequenciesOutputReference Frequencies
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVFrequenciesOutputReference>()!;
        }

        [JsiiProperty(name: "ipi", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVIpiOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVIpiOutputReference Ipi
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVIpiOutputReference>()!;
        }

        [JsiiProperty(name: "reEnlightenment", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVReEnlightenmentOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVReEnlightenmentOutputReference ReEnlightenment
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVReEnlightenmentOutputReference>()!;
        }

        [JsiiProperty(name: "relaxed", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVRelaxedOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVRelaxedOutputReference Relaxed
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVRelaxedOutputReference>()!;
        }

        [JsiiProperty(name: "reset", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVResetOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVResetOutputReference Reset
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVResetOutputReference>()!;
        }

        [JsiiProperty(name: "runtime", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVRuntimeOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVRuntimeOutputReference Runtime
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVRuntimeOutputReference>()!;
        }

        [JsiiProperty(name: "spinlocks", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVSpinlocksOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVSpinlocksOutputReference Spinlocks
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVSpinlocksOutputReference>()!;
        }

        [JsiiProperty(name: "stimer", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVStimerOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVStimerOutputReference Stimer
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVStimerOutputReference>()!;
        }

        [JsiiProperty(name: "synic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVSynicOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVSynicOutputReference Synic
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVSynicOutputReference>()!;
        }

        [JsiiProperty(name: "tlbFlush", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVTlbFlushOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVTlbFlushOutputReference TlbFlush
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVTlbFlushOutputReference>()!;
        }

        [JsiiProperty(name: "vapic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVVapicOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVVapicOutputReference Vapic
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVVapicOutputReference>()!;
        }

        [JsiiProperty(name: "vendorId", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVVendorIdOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVVendorIdOutputReference VendorId
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVVendorIdOutputReference>()!;
        }

        [JsiiProperty(name: "vpIndex", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVVpIndexOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVVpIndexOutputReference VpIndex
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVVpIndexOutputReference>()!;
        }

        [JsiiProperty(name: "xmmInput", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVXmmInputOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVXmmInputOutputReference XmmInput
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVXmmInputOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeaturesHyperVAvic" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "avicInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVAvic\"}]}}", isOptional: true)]
        public virtual object? AvicInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeaturesHyperVEmsrBitmap" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emsrBitmapInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVEmsrBitmap\"}]}}", isOptional: true)]
        public virtual object? EmsrBitmapInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeaturesHyperVEvmcs" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "evmcsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVEvmcs\"}]}}", isOptional: true)]
        public virtual object? EvmcsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeaturesHyperVFrequencies" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "frequenciesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVFrequencies\"}]}}", isOptional: true)]
        public virtual object? FrequenciesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeaturesHyperVIpi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVIpi\"}]}}", isOptional: true)]
        public virtual object? IpiInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeaturesHyperVReEnlightenment" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reEnlightenmentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVReEnlightenment\"}]}}", isOptional: true)]
        public virtual object? ReEnlightenmentInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeaturesHyperVRelaxed" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "relaxedInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVRelaxed\"}]}}", isOptional: true)]
        public virtual object? RelaxedInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeaturesHyperVReset" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVReset\"}]}}", isOptional: true)]
        public virtual object? ResetInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeaturesHyperVRuntime" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runtimeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVRuntime\"}]}}", isOptional: true)]
        public virtual object? RuntimeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeaturesHyperVSpinlocks" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spinlocksInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVSpinlocks\"}]}}", isOptional: true)]
        public virtual object? SpinlocksInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeaturesHyperVStimer" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stimerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVStimer\"}]}}", isOptional: true)]
        public virtual object? StimerInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeaturesHyperVSynic" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "synicInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVSynic\"}]}}", isOptional: true)]
        public virtual object? SynicInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeaturesHyperVTlbFlush" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tlbFlushInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVTlbFlush\"}]}}", isOptional: true)]
        public virtual object? TlbFlushInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeaturesHyperVVapic" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vapicInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVVapic\"}]}}", isOptional: true)]
        public virtual object? VapicInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeaturesHyperVVendorId" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vendorIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVVendorId\"}]}}", isOptional: true)]
        public virtual object? VendorIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeaturesHyperVVpIndex" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpIndexInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVVpIndex\"}]}}", isOptional: true)]
        public virtual object? VpIndexInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeaturesHyperVXmmInput" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xmmInputInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVXmmInput\"}]}}", isOptional: true)]
        public virtual object? XmmInputInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeaturesHyperV" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperV\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainFeaturesHyperV cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainFeaturesHyperV).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
