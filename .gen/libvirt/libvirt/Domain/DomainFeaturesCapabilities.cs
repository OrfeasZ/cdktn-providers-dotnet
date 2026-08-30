using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainFeaturesCapabilities")]
    public class DomainFeaturesCapabilities : libvirt.Domain.IDomainFeaturesCapabilities
    {
        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#audit_control Domain#audit_control}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auditControl", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesAuditControl\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesAuditControl? AuditControl
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#audit_write Domain#audit_write}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auditWrite", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesAuditWrite\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesAuditWrite? AuditWrite
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#block_suspend Domain#block_suspend}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockSuspend", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesBlockSuspend\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesBlockSuspend? BlockSuspend
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#chown Domain#chown}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "chown", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesChown\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesChown? Chown
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dac_override Domain#dac_override}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dacOverride", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesDacOverride\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesDacOverride? DacOverride
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dac_read_search Domain#dac_read_search}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dacReadSearch", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesDacReadSearch\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesDacReadSearch? DacReadSearch
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#fowner Domain#fowner}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fowner", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesFowner\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesFowner? Fowner
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#fset_id Domain#fset_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fsetId", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesFsetId\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesFsetId? FsetId
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ipc_lock Domain#ipc_lock}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipcLock", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesIpcLock\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesIpcLock? IpcLock
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ipc_owner Domain#ipc_owner}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipcOwner", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesIpcOwner\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesIpcOwner? IpcOwner
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#kill Domain#kill}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kill", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesKill\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesKill? Kill
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#lease Domain#lease}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lease", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesLease\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesLease? Lease
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#linux_immutable Domain#linux_immutable}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "linuxImmutable", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesLinuxImmutable\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesLinuxImmutable? LinuxImmutable
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mac_admin Domain#mac_admin}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "macAdmin", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesMacAdmin\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesMacAdmin? MacAdmin
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mac_override Domain#mac_override}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "macOverride", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesMacOverride\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesMacOverride? MacOverride
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mk_nod Domain#mk_nod}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mkNod", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesMkNod\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesMkNod? MkNod
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#net_admin Domain#net_admin}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "netAdmin", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetAdmin\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesNetAdmin? NetAdmin
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#net_bind_service Domain#net_bind_service}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "netBindService", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetBindService\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesNetBindService? NetBindService
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#net_broadcast Domain#net_broadcast}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "netBroadcast", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetBroadcast\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesNetBroadcast? NetBroadcast
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#net_raw Domain#net_raw}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "netRaw", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetRaw\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesNetRaw? NetRaw
        {
            get;
            set;
        }

        /// <summary>Sets the overall policy for how listed capabilities are applied to the guest;</summary>
        /// <remarks>
        /// the value is user-provided and may follow libvirt’s capability policy keywords (for example, to treat unlisted capabilities as denied or allowed).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#policy Domain#policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Policy
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#set_f_cap Domain#set_f_cap}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "setFCap", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetFCap\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesSetFCap? SetFCap
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#set_gid Domain#set_gid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "setGid", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetGid\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesSetGid? SetGid
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#set_p_cap Domain#set_p_cap}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "setPCap", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetPCap\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesSetPCap? SetPCap
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#set_uid Domain#set_uid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "setUid", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetUid\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesSetUid? SetUid
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_admin Domain#sys_admin}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sysAdmin", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysAdmin\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesSysAdmin? SysAdmin
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_boot Domain#sys_boot}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sysBoot", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysBoot\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesSysBoot? SysBoot
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_ch_root Domain#sys_ch_root}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sysChRoot", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysChRoot\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesSysChRoot? SysChRoot
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_log Domain#sys_log}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sysLog", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysLog\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesSysLog? SysLog
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_module Domain#sys_module}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sysModule", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysModule\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesSysModule? SysModule
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_nice Domain#sys_nice}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sysNice", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysNice\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesSysNice? SysNice
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_p_acct Domain#sys_p_acct}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sysPAcct", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysPAcct\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesSysPAcct? SysPAcct
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_p_trace Domain#sys_p_trace}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sysPTrace", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysPTrace\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesSysPTrace? SysPTrace
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_raw_io Domain#sys_raw_io}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sysRawIo", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysRawIo\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesSysRawIo? SysRawIo
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_resource Domain#sys_resource}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sysResource", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysResource\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesSysResource? SysResource
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_time Domain#sys_time}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sysTime", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysTime\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesSysTime? SysTime
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_tty_cnofig Domain#sys_tty_cnofig}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sysTtyCnofig", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysTtyCnofig\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesSysTtyCnofig? SysTtyCnofig
        {
            get;
            set;
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#wake_alarm Domain#wake_alarm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wakeAlarm", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesWakeAlarm\"}", isOptional: true)]
        public libvirt.Domain.IDomainFeaturesCapabilitiesWakeAlarm? WakeAlarm
        {
            get;
            set;
        }
    }
}
