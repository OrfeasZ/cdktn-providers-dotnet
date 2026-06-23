using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainFeaturesCapabilitiesOutputReference), fullyQualifiedName: "libvirt.domain.DomainFeaturesCapabilitiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainFeaturesCapabilitiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainFeaturesCapabilitiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DomainFeaturesCapabilitiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainFeaturesCapabilitiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuditControl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesAuditControl\"}}]")]
        public virtual void PutAuditControl(libvirt.Domain.IDomainFeaturesCapabilitiesAuditControl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesAuditControl)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuditWrite", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesAuditWrite\"}}]")]
        public virtual void PutAuditWrite(libvirt.Domain.IDomainFeaturesCapabilitiesAuditWrite @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesAuditWrite)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlockSuspend", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesBlockSuspend\"}}]")]
        public virtual void PutBlockSuspend(libvirt.Domain.IDomainFeaturesCapabilitiesBlockSuspend @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesBlockSuspend)}, new object[]{@value});
        }

        [JsiiMethod(name: "putChown", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesChown\"}}]")]
        public virtual void PutChown(libvirt.Domain.IDomainFeaturesCapabilitiesChown @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesChown)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDacOverride", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesDacOverride\"}}]")]
        public virtual void PutDacOverride(libvirt.Domain.IDomainFeaturesCapabilitiesDacOverride @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesDacOverride)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDacReadSearch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesDacReadSearch\"}}]")]
        public virtual void PutDacReadSearch(libvirt.Domain.IDomainFeaturesCapabilitiesDacReadSearch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesDacReadSearch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFowner", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesFowner\"}}]")]
        public virtual void PutFowner(libvirt.Domain.IDomainFeaturesCapabilitiesFowner @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesFowner)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFsetId", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesFsetId\"}}]")]
        public virtual void PutFsetId(libvirt.Domain.IDomainFeaturesCapabilitiesFsetId @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesFsetId)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIpcLock", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesIpcLock\"}}]")]
        public virtual void PutIpcLock(libvirt.Domain.IDomainFeaturesCapabilitiesIpcLock @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesIpcLock)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIpcOwner", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesIpcOwner\"}}]")]
        public virtual void PutIpcOwner(libvirt.Domain.IDomainFeaturesCapabilitiesIpcOwner @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesIpcOwner)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKill", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesKill\"}}]")]
        public virtual void PutKill(libvirt.Domain.IDomainFeaturesCapabilitiesKill @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesKill)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLease", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesLease\"}}]")]
        public virtual void PutLease(libvirt.Domain.IDomainFeaturesCapabilitiesLease @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesLease)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLinuxImmutable", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesLinuxImmutable\"}}]")]
        public virtual void PutLinuxImmutable(libvirt.Domain.IDomainFeaturesCapabilitiesLinuxImmutable @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesLinuxImmutable)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMacAdmin", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesMacAdmin\"}}]")]
        public virtual void PutMacAdmin(libvirt.Domain.IDomainFeaturesCapabilitiesMacAdmin @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesMacAdmin)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMacOverride", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesMacOverride\"}}]")]
        public virtual void PutMacOverride(libvirt.Domain.IDomainFeaturesCapabilitiesMacOverride @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesMacOverride)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMkNod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesMkNod\"}}]")]
        public virtual void PutMkNod(libvirt.Domain.IDomainFeaturesCapabilitiesMkNod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesMkNod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetAdmin", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetAdmin\"}}]")]
        public virtual void PutNetAdmin(libvirt.Domain.IDomainFeaturesCapabilitiesNetAdmin @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesNetAdmin)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetBindService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetBindService\"}}]")]
        public virtual void PutNetBindService(libvirt.Domain.IDomainFeaturesCapabilitiesNetBindService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesNetBindService)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetBroadcast", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetBroadcast\"}}]")]
        public virtual void PutNetBroadcast(libvirt.Domain.IDomainFeaturesCapabilitiesNetBroadcast @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesNetBroadcast)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetRaw", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetRaw\"}}]")]
        public virtual void PutNetRaw(libvirt.Domain.IDomainFeaturesCapabilitiesNetRaw @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesNetRaw)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSetFCap", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetFCap\"}}]")]
        public virtual void PutSetFCap(libvirt.Domain.IDomainFeaturesCapabilitiesSetFCap @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesSetFCap)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSetGid", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetGid\"}}]")]
        public virtual void PutSetGid(libvirt.Domain.IDomainFeaturesCapabilitiesSetGid @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesSetGid)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSetPCap", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetPCap\"}}]")]
        public virtual void PutSetPCap(libvirt.Domain.IDomainFeaturesCapabilitiesSetPCap @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesSetPCap)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSetUid", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetUid\"}}]")]
        public virtual void PutSetUid(libvirt.Domain.IDomainFeaturesCapabilitiesSetUid @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesSetUid)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSysAdmin", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysAdmin\"}}]")]
        public virtual void PutSysAdmin(libvirt.Domain.IDomainFeaturesCapabilitiesSysAdmin @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesSysAdmin)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSysBoot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysBoot\"}}]")]
        public virtual void PutSysBoot(libvirt.Domain.IDomainFeaturesCapabilitiesSysBoot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesSysBoot)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSysChRoot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysChRoot\"}}]")]
        public virtual void PutSysChRoot(libvirt.Domain.IDomainFeaturesCapabilitiesSysChRoot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesSysChRoot)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSysLog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysLog\"}}]")]
        public virtual void PutSysLog(libvirt.Domain.IDomainFeaturesCapabilitiesSysLog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesSysLog)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSysModule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysModule\"}}]")]
        public virtual void PutSysModule(libvirt.Domain.IDomainFeaturesCapabilitiesSysModule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesSysModule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSysNice", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysNice\"}}]")]
        public virtual void PutSysNice(libvirt.Domain.IDomainFeaturesCapabilitiesSysNice @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesSysNice)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSysPAcct", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysPAcct\"}}]")]
        public virtual void PutSysPAcct(libvirt.Domain.IDomainFeaturesCapabilitiesSysPAcct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesSysPAcct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSysPTrace", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysPTrace\"}}]")]
        public virtual void PutSysPTrace(libvirt.Domain.IDomainFeaturesCapabilitiesSysPTrace @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesSysPTrace)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSysRawIo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysRawIo\"}}]")]
        public virtual void PutSysRawIo(libvirt.Domain.IDomainFeaturesCapabilitiesSysRawIo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesSysRawIo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSysResource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysResource\"}}]")]
        public virtual void PutSysResource(libvirt.Domain.IDomainFeaturesCapabilitiesSysResource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesSysResource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSysTime", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysTime\"}}]")]
        public virtual void PutSysTime(libvirt.Domain.IDomainFeaturesCapabilitiesSysTime @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesSysTime)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSysTtyCnofig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysTtyCnofig\"}}]")]
        public virtual void PutSysTtyCnofig(libvirt.Domain.IDomainFeaturesCapabilitiesSysTtyCnofig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesSysTtyCnofig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWakeAlarm", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesWakeAlarm\"}}]")]
        public virtual void PutWakeAlarm(libvirt.Domain.IDomainFeaturesCapabilitiesWakeAlarm @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeaturesCapabilitiesWakeAlarm)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuditControl")]
        public virtual void ResetAuditControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuditWrite")]
        public virtual void ResetAuditWrite()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlockSuspend")]
        public virtual void ResetBlockSuspend()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChown")]
        public virtual void ResetChown()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDacOverride")]
        public virtual void ResetDacOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDacReadSearch")]
        public virtual void ResetDacReadSearch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFowner")]
        public virtual void ResetFowner()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFsetId")]
        public virtual void ResetFsetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpcLock")]
        public virtual void ResetIpcLock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpcOwner")]
        public virtual void ResetIpcOwner()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKill")]
        public virtual void ResetKill()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLease")]
        public virtual void ResetLease()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLinuxImmutable")]
        public virtual void ResetLinuxImmutable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMacAdmin")]
        public virtual void ResetMacAdmin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMacOverride")]
        public virtual void ResetMacOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMkNod")]
        public virtual void ResetMkNod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetAdmin")]
        public virtual void ResetNetAdmin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetBindService")]
        public virtual void ResetNetBindService()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetBroadcast")]
        public virtual void ResetNetBroadcast()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetRaw")]
        public virtual void ResetNetRaw()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicy")]
        public virtual void ResetPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSetFCap")]
        public virtual void ResetSetFCap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSetGid")]
        public virtual void ResetSetGid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSetPCap")]
        public virtual void ResetSetPCap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSetUid")]
        public virtual void ResetSetUid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSysAdmin")]
        public virtual void ResetSysAdmin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSysBoot")]
        public virtual void ResetSysBoot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSysChRoot")]
        public virtual void ResetSysChRoot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSysLog")]
        public virtual void ResetSysLog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSysModule")]
        public virtual void ResetSysModule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSysNice")]
        public virtual void ResetSysNice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSysPAcct")]
        public virtual void ResetSysPAcct()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSysPTrace")]
        public virtual void ResetSysPTrace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSysRawIo")]
        public virtual void ResetSysRawIo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSysResource")]
        public virtual void ResetSysResource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSysTime")]
        public virtual void ResetSysTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSysTtyCnofig")]
        public virtual void ResetSysTtyCnofig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWakeAlarm")]
        public virtual void ResetWakeAlarm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "auditControl", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesAuditControlOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesAuditControlOutputReference AuditControl
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesAuditControlOutputReference>()!;
        }

        [JsiiProperty(name: "auditWrite", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesAuditWriteOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesAuditWriteOutputReference AuditWrite
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesAuditWriteOutputReference>()!;
        }

        [JsiiProperty(name: "blockSuspend", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesBlockSuspendOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesBlockSuspendOutputReference BlockSuspend
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesBlockSuspendOutputReference>()!;
        }

        [JsiiProperty(name: "chown", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesChownOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesChownOutputReference Chown
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesChownOutputReference>()!;
        }

        [JsiiProperty(name: "dacOverride", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesDacOverrideOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesDacOverrideOutputReference DacOverride
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesDacOverrideOutputReference>()!;
        }

        [JsiiProperty(name: "dacReadSearch", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesDacReadSearchOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesDacReadSearchOutputReference DacReadSearch
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesDacReadSearchOutputReference>()!;
        }

        [JsiiProperty(name: "fowner", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesFownerOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesFownerOutputReference Fowner
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesFownerOutputReference>()!;
        }

        [JsiiProperty(name: "fsetId", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesFsetIdOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesFsetIdOutputReference FsetId
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesFsetIdOutputReference>()!;
        }

        [JsiiProperty(name: "ipcLock", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesIpcLockOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesIpcLockOutputReference IpcLock
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesIpcLockOutputReference>()!;
        }

        [JsiiProperty(name: "ipcOwner", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesIpcOwnerOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesIpcOwnerOutputReference IpcOwner
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesIpcOwnerOutputReference>()!;
        }

        [JsiiProperty(name: "kill", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesKillOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesKillOutputReference Kill
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesKillOutputReference>()!;
        }

        [JsiiProperty(name: "lease", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesLeaseOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesLeaseOutputReference Lease
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesLeaseOutputReference>()!;
        }

        [JsiiProperty(name: "linuxImmutable", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesLinuxImmutableOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesLinuxImmutableOutputReference LinuxImmutable
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesLinuxImmutableOutputReference>()!;
        }

        [JsiiProperty(name: "macAdmin", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesMacAdminOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesMacAdminOutputReference MacAdmin
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesMacAdminOutputReference>()!;
        }

        [JsiiProperty(name: "macOverride", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesMacOverrideOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesMacOverrideOutputReference MacOverride
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesMacOverrideOutputReference>()!;
        }

        [JsiiProperty(name: "mkNod", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesMkNodOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesMkNodOutputReference MkNod
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesMkNodOutputReference>()!;
        }

        [JsiiProperty(name: "netAdmin", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetAdminOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesNetAdminOutputReference NetAdmin
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesNetAdminOutputReference>()!;
        }

        [JsiiProperty(name: "netBindService", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetBindServiceOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesNetBindServiceOutputReference NetBindService
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesNetBindServiceOutputReference>()!;
        }

        [JsiiProperty(name: "netBroadcast", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetBroadcastOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesNetBroadcastOutputReference NetBroadcast
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesNetBroadcastOutputReference>()!;
        }

        [JsiiProperty(name: "netRaw", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetRawOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesNetRawOutputReference NetRaw
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesNetRawOutputReference>()!;
        }

        [JsiiProperty(name: "setFCap", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetFCapOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesSetFCapOutputReference SetFCap
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesSetFCapOutputReference>()!;
        }

        [JsiiProperty(name: "setGid", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetGidOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesSetGidOutputReference SetGid
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesSetGidOutputReference>()!;
        }

        [JsiiProperty(name: "setPCap", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetPCapOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesSetPCapOutputReference SetPCap
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesSetPCapOutputReference>()!;
        }

        [JsiiProperty(name: "setUid", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetUidOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesSetUidOutputReference SetUid
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesSetUidOutputReference>()!;
        }

        [JsiiProperty(name: "sysAdmin", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysAdminOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesSysAdminOutputReference SysAdmin
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesSysAdminOutputReference>()!;
        }

        [JsiiProperty(name: "sysBoot", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysBootOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesSysBootOutputReference SysBoot
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesSysBootOutputReference>()!;
        }

        [JsiiProperty(name: "sysChRoot", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysChRootOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesSysChRootOutputReference SysChRoot
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesSysChRootOutputReference>()!;
        }

        [JsiiProperty(name: "sysLog", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysLogOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesSysLogOutputReference SysLog
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesSysLogOutputReference>()!;
        }

        [JsiiProperty(name: "sysModule", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysModuleOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesSysModuleOutputReference SysModule
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesSysModuleOutputReference>()!;
        }

        [JsiiProperty(name: "sysNice", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysNiceOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesSysNiceOutputReference SysNice
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesSysNiceOutputReference>()!;
        }

        [JsiiProperty(name: "sysPAcct", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysPAcctOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesSysPAcctOutputReference SysPAcct
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesSysPAcctOutputReference>()!;
        }

        [JsiiProperty(name: "sysPTrace", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysPTraceOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesSysPTraceOutputReference SysPTrace
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesSysPTraceOutputReference>()!;
        }

        [JsiiProperty(name: "sysRawIo", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysRawIoOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesSysRawIoOutputReference SysRawIo
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesSysRawIoOutputReference>()!;
        }

        [JsiiProperty(name: "sysResource", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysResourceOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesSysResourceOutputReference SysResource
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesSysResourceOutputReference>()!;
        }

        [JsiiProperty(name: "sysTime", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysTimeOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesSysTimeOutputReference SysTime
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesSysTimeOutputReference>()!;
        }

        [JsiiProperty(name: "sysTtyCnofig", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysTtyCnofigOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesSysTtyCnofigOutputReference SysTtyCnofig
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesSysTtyCnofigOutputReference>()!;
        }

        [JsiiProperty(name: "wakeAlarm", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesWakeAlarmOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesCapabilitiesWakeAlarmOutputReference WakeAlarm
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesCapabilitiesWakeAlarmOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "auditControlInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesAuditControl\"}]}}", isOptional: true)]
        public virtual object? AuditControlInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "auditWriteInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesAuditWrite\"}]}}", isOptional: true)]
        public virtual object? AuditWriteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockSuspendInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesBlockSuspend\"}]}}", isOptional: true)]
        public virtual object? BlockSuspendInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "chownInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesChown\"}]}}", isOptional: true)]
        public virtual object? ChownInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dacOverrideInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesDacOverride\"}]}}", isOptional: true)]
        public virtual object? DacOverrideInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dacReadSearchInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesDacReadSearch\"}]}}", isOptional: true)]
        public virtual object? DacReadSearchInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fownerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesFowner\"}]}}", isOptional: true)]
        public virtual object? FownerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fsetIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesFsetId\"}]}}", isOptional: true)]
        public virtual object? FsetIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipcLockInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesIpcLock\"}]}}", isOptional: true)]
        public virtual object? IpcLockInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipcOwnerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesIpcOwner\"}]}}", isOptional: true)]
        public virtual object? IpcOwnerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "killInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesKill\"}]}}", isOptional: true)]
        public virtual object? KillInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "leaseInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesLease\"}]}}", isOptional: true)]
        public virtual object? LeaseInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linuxImmutableInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesLinuxImmutable\"}]}}", isOptional: true)]
        public virtual object? LinuxImmutableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "macAdminInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesMacAdmin\"}]}}", isOptional: true)]
        public virtual object? MacAdminInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "macOverrideInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesMacOverride\"}]}}", isOptional: true)]
        public virtual object? MacOverrideInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mkNodInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesMkNod\"}]}}", isOptional: true)]
        public virtual object? MkNodInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netAdminInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetAdmin\"}]}}", isOptional: true)]
        public virtual object? NetAdminInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netBindServiceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetBindService\"}]}}", isOptional: true)]
        public virtual object? NetBindServiceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netBroadcastInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetBroadcast\"}]}}", isOptional: true)]
        public virtual object? NetBroadcastInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netRawInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetRaw\"}]}}", isOptional: true)]
        public virtual object? NetRawInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "setFCapInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetFCap\"}]}}", isOptional: true)]
        public virtual object? SetFCapInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "setGidInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetGid\"}]}}", isOptional: true)]
        public virtual object? SetGidInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "setPCapInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetPCap\"}]}}", isOptional: true)]
        public virtual object? SetPCapInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "setUidInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetUid\"}]}}", isOptional: true)]
        public virtual object? SetUidInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sysAdminInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysAdmin\"}]}}", isOptional: true)]
        public virtual object? SysAdminInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sysBootInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysBoot\"}]}}", isOptional: true)]
        public virtual object? SysBootInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sysChRootInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysChRoot\"}]}}", isOptional: true)]
        public virtual object? SysChRootInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sysLogInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysLog\"}]}}", isOptional: true)]
        public virtual object? SysLogInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sysModuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysModule\"}]}}", isOptional: true)]
        public virtual object? SysModuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sysNiceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysNice\"}]}}", isOptional: true)]
        public virtual object? SysNiceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sysPAcctInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysPAcct\"}]}}", isOptional: true)]
        public virtual object? SysPAcctInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sysPTraceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysPTrace\"}]}}", isOptional: true)]
        public virtual object? SysPTraceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sysRawIoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysRawIo\"}]}}", isOptional: true)]
        public virtual object? SysRawIoInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sysResourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysResource\"}]}}", isOptional: true)]
        public virtual object? SysResourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sysTimeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysTime\"}]}}", isOptional: true)]
        public virtual object? SysTimeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sysTtyCnofigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysTtyCnofig\"}]}}", isOptional: true)]
        public virtual object? SysTtyCnofigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "wakeAlarmInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesWakeAlarm\"}]}}", isOptional: true)]
        public virtual object? WakeAlarmInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Policy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilities\"}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainFeaturesCapabilities cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainFeaturesCapabilities).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
