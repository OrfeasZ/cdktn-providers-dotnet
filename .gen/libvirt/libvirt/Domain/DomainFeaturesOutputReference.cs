using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainFeaturesOutputReference), fullyQualifiedName: "libvirt.domain.DomainFeaturesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainFeaturesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainFeaturesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainFeaturesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainFeaturesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAia", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesAia\"}}]")]
        public virtual void PutAia(libvirt.Domain.IDomainFeaturesAia @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesAia)}, new object[]{@value});
        }

        [JsiiMethod(name: "putApic", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesApic\"}}]")]
        public virtual void PutApic(libvirt.Domain.IDomainFeaturesApic @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesApic)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAsyncTeardown", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesAsyncTeardown\"}}]")]
        public virtual void PutAsyncTeardown(libvirt.Domain.IDomainFeaturesAsyncTeardown @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesAsyncTeardown)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCapabilities", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilities\"}}]")]
        public virtual void PutCapabilities(libvirt.Domain.IDomainFeaturesCapabilities @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilities)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCcfAssist", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCcfAssist\"}}]")]
        public virtual void PutCcfAssist(libvirt.Domain.IDomainFeaturesCcfAssist @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCcfAssist)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCfpc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCfpc\"}}]")]
        public virtual void PutCfpc(libvirt.Domain.IDomainFeaturesCfpc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCfpc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGic", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesGic\"}}]")]
        public virtual void PutGic(libvirt.Domain.IDomainFeaturesGic @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesGic)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHap", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHap\"}}]")]
        public virtual void PutHap(libvirt.Domain.IDomainFeaturesHap @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHap)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHpt", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHpt\"}}]")]
        public virtual void PutHpt(libvirt.Domain.IDomainFeaturesHpt @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHpt)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHtm", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHtm\"}}]")]
        public virtual void PutHtm(libvirt.Domain.IDomainFeaturesHtm @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHtm)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHyperV", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesHyperV\"}}]")]
        public virtual void PutHyperV(libvirt.Domain.IDomainFeaturesHyperV @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesHyperV)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIbs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesIbs\"}}]")]
        public virtual void PutIbs(libvirt.Domain.IDomainFeaturesIbs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesIbs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIoapic", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesIoapic\"}}]")]
        public virtual void PutIoapic(libvirt.Domain.IDomainFeaturesIoapic @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesIoapic)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKvm", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesKvm\"}}]")]
        public virtual void PutKvm(libvirt.Domain.IDomainFeaturesKvm @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesKvm)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMsrs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesMsrs\"}}]")]
        public virtual void PutMsrs(libvirt.Domain.IDomainFeaturesMsrs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesMsrs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNestedHv", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesNestedHv\"}}]")]
        public virtual void PutNestedHv(libvirt.Domain.IDomainFeaturesNestedHv @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesNestedHv)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPmu", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesPmu\"}}]")]
        public virtual void PutPmu(libvirt.Domain.IDomainFeaturesPmu @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesPmu)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPs2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesPs2\"}}]")]
        public virtual void PutPs2(libvirt.Domain.IDomainFeaturesPs2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesPs2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPvSpinlock", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesPvSpinlock\"}}]")]
        public virtual void PutPvSpinlock(libvirt.Domain.IDomainFeaturesPvSpinlock @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesPvSpinlock)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRas", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesRas\"}}]")]
        public virtual void PutRas(libvirt.Domain.IDomainFeaturesRas @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesRas)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSbbc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesSbbc\"}}]")]
        public virtual void PutSbbc(libvirt.Domain.IDomainFeaturesSbbc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesSbbc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSmm", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesSmm\"}}]")]
        public virtual void PutSmm(libvirt.Domain.IDomainFeaturesSmm @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesSmm)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTcg", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesTcg\"}}]")]
        public virtual void PutTcg(libvirt.Domain.IDomainFeaturesTcg @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesTcg)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVmCoreInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesVmCoreInfo\"}}]")]
        public virtual void PutVmCoreInfo(libvirt.Domain.IDomainFeaturesVmCoreInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesVmCoreInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVmPort", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesVmPort\"}}]")]
        public virtual void PutVmPort(libvirt.Domain.IDomainFeaturesVmPort @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesVmPort)}, new object[]{@value});
        }

        [JsiiMethod(name: "putXen", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesXen\"}}]")]
        public virtual void PutXen(libvirt.Domain.IDomainFeaturesXen @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesXen)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcpi")]
        public virtual void ResetAcpi()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAia")]
        public virtual void ResetAia()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApic")]
        public virtual void ResetApic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAsyncTeardown")]
        public virtual void ResetAsyncTeardown()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapabilities")]
        public virtual void ResetCapabilities()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCcfAssist")]
        public virtual void ResetCcfAssist()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCfpc")]
        public virtual void ResetCfpc()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGic")]
        public virtual void ResetGic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHap")]
        public virtual void ResetHap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHpt")]
        public virtual void ResetHpt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHtm")]
        public virtual void ResetHtm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHyperV")]
        public virtual void ResetHyperV()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIbs")]
        public virtual void ResetIbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIoapic")]
        public virtual void ResetIoapic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKvm")]
        public virtual void ResetKvm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMsrs")]
        public virtual void ResetMsrs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNestedHv")]
        public virtual void ResetNestedHv()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPae")]
        public virtual void ResetPae()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPmu")]
        public virtual void ResetPmu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivNet")]
        public virtual void ResetPrivNet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPs2")]
        public virtual void ResetPs2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPvSpinlock")]
        public virtual void ResetPvSpinlock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRas")]
        public virtual void ResetRas()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSbbc")]
        public virtual void ResetSbbc()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmm")]
        public virtual void ResetSmm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTcg")]
        public virtual void ResetTcg()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetViridian")]
        public virtual void ResetViridian()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVmCoreInfo")]
        public virtual void ResetVmCoreInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVmPort")]
        public virtual void ResetVmPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXen")]
        public virtual void ResetXen()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "aia", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesAiaOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesAiaOutputReference Aia
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesAiaOutputReference>()!;
        }

        [JsiiProperty(name: "apic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesApicOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesApicOutputReference Apic
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesApicOutputReference>()!;
        }

        [JsiiProperty(name: "asyncTeardown", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesAsyncTeardownOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesAsyncTeardownOutputReference AsyncTeardown
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesAsyncTeardownOutputReference>()!;
        }

        [JsiiProperty(name: "capabilities", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesOutputReference Capabilities
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesOutputReference>()!;
        }

        [JsiiProperty(name: "ccfAssist", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCcfAssistOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCcfAssistOutputReference CcfAssist
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCcfAssistOutputReference>()!;
        }

        [JsiiProperty(name: "cfpc", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCfpcOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCfpcOutputReference Cfpc
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCfpcOutputReference>()!;
        }

        [JsiiProperty(name: "gic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesGicOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesGicOutputReference Gic
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesGicOutputReference>()!;
        }

        [JsiiProperty(name: "hap", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHapOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHapOutputReference Hap
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHapOutputReference>()!;
        }

        [JsiiProperty(name: "hpt", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHptOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHptOutputReference Hpt
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHptOutputReference>()!;
        }

        [JsiiProperty(name: "htm", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHtmOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHtmOutputReference Htm
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHtmOutputReference>()!;
        }

        [JsiiProperty(name: "hyperV", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesHyperVOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesHyperVOutputReference HyperV
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesHyperVOutputReference>()!;
        }

        [JsiiProperty(name: "ibs", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesIbsOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesIbsOutputReference Ibs
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesIbsOutputReference>()!;
        }

        [JsiiProperty(name: "ioapic", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesIoapicOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesIoapicOutputReference Ioapic
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesIoapicOutputReference>()!;
        }

        [JsiiProperty(name: "kvm", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesKvmOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesKvmOutputReference Kvm
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesKvmOutputReference>()!;
        }

        [JsiiProperty(name: "msrs", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesMsrsOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesMsrsOutputReference Msrs
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesMsrsOutputReference>()!;
        }

        [JsiiProperty(name: "nestedHv", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesNestedHvOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesNestedHvOutputReference NestedHv
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesNestedHvOutputReference>()!;
        }

        [JsiiProperty(name: "pmu", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesPmuOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesPmuOutputReference Pmu
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesPmuOutputReference>()!;
        }

        [JsiiProperty(name: "ps2", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesPs2OutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesPs2OutputReference Ps2
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesPs2OutputReference>()!;
        }

        [JsiiProperty(name: "pvSpinlock", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesPvSpinlockOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesPvSpinlockOutputReference PvSpinlock
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesPvSpinlockOutputReference>()!;
        }

        [JsiiProperty(name: "ras", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesRasOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesRasOutputReference Ras
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesRasOutputReference>()!;
        }

        [JsiiProperty(name: "sbbc", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesSbbcOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesSbbcOutputReference Sbbc
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesSbbcOutputReference>()!;
        }

        [JsiiProperty(name: "smm", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesSmmOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesSmmOutputReference Smm
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesSmmOutputReference>()!;
        }

        [JsiiProperty(name: "tcg", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesTcgOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesTcgOutputReference Tcg
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesTcgOutputReference>()!;
        }

        [JsiiProperty(name: "vmCoreInfo", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesVmCoreInfoOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesVmCoreInfoOutputReference VmCoreInfo
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesVmCoreInfoOutputReference>()!;
        }

        [JsiiProperty(name: "vmPort", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesVmPortOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesVmPortOutputReference VmPort
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesVmPortOutputReference>()!;
        }

        [JsiiProperty(name: "xen", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesXenOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesXenOutputReference Xen
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesXenOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acpiInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AcpiInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "aiaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesAia\"}]}}", isOptional: true)]
        public virtual object? AiaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "apicInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesApic\"}]}}", isOptional: true)]
        public virtual object? ApicInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "asyncTeardownInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesAsyncTeardown\"}]}}", isOptional: true)]
        public virtual object? AsyncTeardownInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capabilitiesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilities\"}]}}", isOptional: true)]
        public virtual object? CapabilitiesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ccfAssistInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCcfAssist\"}]}}", isOptional: true)]
        public virtual object? CcfAssistInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cfpcInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCfpc\"}]}}", isOptional: true)]
        public virtual object? CfpcInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gicInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesGic\"}]}}", isOptional: true)]
        public virtual object? GicInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hapInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHap\"}]}}", isOptional: true)]
        public virtual object? HapInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hptInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHpt\"}]}}", isOptional: true)]
        public virtual object? HptInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "htmInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHtm\"}]}}", isOptional: true)]
        public virtual object? HtmInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hyperVInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesHyperV\"}]}}", isOptional: true)]
        public virtual object? HyperVInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ibsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesIbs\"}]}}", isOptional: true)]
        public virtual object? IbsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ioapicInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesIoapic\"}]}}", isOptional: true)]
        public virtual object? IoapicInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kvmInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesKvm\"}]}}", isOptional: true)]
        public virtual object? KvmInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "msrsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesMsrs\"}]}}", isOptional: true)]
        public virtual object? MsrsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nestedHvInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesNestedHv\"}]}}", isOptional: true)]
        public virtual object? NestedHvInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "paeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PaeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pmuInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesPmu\"}]}}", isOptional: true)]
        public virtual object? PmuInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privNetInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PrivNetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ps2Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesPs2\"}]}}", isOptional: true)]
        public virtual object? Ps2Input
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pvSpinlockInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesPvSpinlock\"}]}}", isOptional: true)]
        public virtual object? PvSpinlockInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rasInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesRas\"}]}}", isOptional: true)]
        public virtual object? RasInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sbbcInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesSbbc\"}]}}", isOptional: true)]
        public virtual object? SbbcInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smmInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesSmm\"}]}}", isOptional: true)]
        public virtual object? SmmInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tcgInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesTcg\"}]}}", isOptional: true)]
        public virtual object? TcgInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "viridianInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ViridianInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmCoreInfoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesVmCoreInfo\"}]}}", isOptional: true)]
        public virtual object? VmCoreInfoInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmPortInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesVmPort\"}]}}", isOptional: true)]
        public virtual object? VmPortInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xenInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesXen\"}]}}", isOptional: true)]
        public virtual object? XenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "acpi", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Acpi
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "pae", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Pae
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "privNet", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object PrivNet
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "viridian", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Viridian
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeatures\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainFeatures cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainFeatures).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
