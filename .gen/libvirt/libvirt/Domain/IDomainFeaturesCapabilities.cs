using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeaturesCapabilities), fullyQualifiedName: "libvirt.domain.DomainFeaturesCapabilities")]
    public interface IDomainFeaturesCapabilities
    {
        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#audit_control Domain#audit_control}
        /// </remarks>
        [JsiiProperty(name: "auditControl", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesAuditControl\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesAuditControl? AuditControl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#audit_write Domain#audit_write}
        /// </remarks>
        [JsiiProperty(name: "auditWrite", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesAuditWrite\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesAuditWrite? AuditWrite
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#block_suspend Domain#block_suspend}
        /// </remarks>
        [JsiiProperty(name: "blockSuspend", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesBlockSuspend\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesBlockSuspend? BlockSuspend
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#chown Domain#chown}
        /// </remarks>
        [JsiiProperty(name: "chown", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesChown\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesChown? Chown
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dac_override Domain#dac_override}
        /// </remarks>
        [JsiiProperty(name: "dacOverride", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesDacOverride\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesDacOverride? DacOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dac_read_search Domain#dac_read_search}
        /// </remarks>
        [JsiiProperty(name: "dacReadSearch", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesDacReadSearch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesDacReadSearch? DacReadSearch
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#fowner Domain#fowner}
        /// </remarks>
        [JsiiProperty(name: "fowner", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesFowner\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesFowner? Fowner
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#fset_id Domain#fset_id}
        /// </remarks>
        [JsiiProperty(name: "fsetId", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesFsetId\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesFsetId? FsetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ipc_lock Domain#ipc_lock}
        /// </remarks>
        [JsiiProperty(name: "ipcLock", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesIpcLock\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesIpcLock? IpcLock
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ipc_owner Domain#ipc_owner}
        /// </remarks>
        [JsiiProperty(name: "ipcOwner", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesIpcOwner\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesIpcOwner? IpcOwner
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#kill Domain#kill}
        /// </remarks>
        [JsiiProperty(name: "kill", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesKill\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesKill? Kill
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#lease Domain#lease}
        /// </remarks>
        [JsiiProperty(name: "lease", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesLease\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesLease? Lease
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#linux_immutable Domain#linux_immutable}
        /// </remarks>
        [JsiiProperty(name: "linuxImmutable", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesLinuxImmutable\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesLinuxImmutable? LinuxImmutable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mac_admin Domain#mac_admin}
        /// </remarks>
        [JsiiProperty(name: "macAdmin", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesMacAdmin\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesMacAdmin? MacAdmin
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mac_override Domain#mac_override}
        /// </remarks>
        [JsiiProperty(name: "macOverride", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesMacOverride\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesMacOverride? MacOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mk_nod Domain#mk_nod}
        /// </remarks>
        [JsiiProperty(name: "mkNod", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesMkNod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesMkNod? MkNod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#net_admin Domain#net_admin}
        /// </remarks>
        [JsiiProperty(name: "netAdmin", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetAdmin\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesNetAdmin? NetAdmin
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#net_bind_service Domain#net_bind_service}
        /// </remarks>
        [JsiiProperty(name: "netBindService", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetBindService\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesNetBindService? NetBindService
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#net_broadcast Domain#net_broadcast}
        /// </remarks>
        [JsiiProperty(name: "netBroadcast", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetBroadcast\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesNetBroadcast? NetBroadcast
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#net_raw Domain#net_raw}
        /// </remarks>
        [JsiiProperty(name: "netRaw", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetRaw\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesNetRaw? NetRaw
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the overall policy for how listed capabilities are applied to the guest;</summary>
        /// <remarks>
        /// the value is user-provided and may follow libvirt’s capability policy keywords (for example, to treat unlisted capabilities as denied or allowed).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#policy Domain#policy}
        /// </remarks>
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Policy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#set_f_cap Domain#set_f_cap}
        /// </remarks>
        [JsiiProperty(name: "setFCap", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetFCap\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesSetFCap? SetFCap
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#set_gid Domain#set_gid}
        /// </remarks>
        [JsiiProperty(name: "setGid", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetGid\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesSetGid? SetGid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#set_p_cap Domain#set_p_cap}
        /// </remarks>
        [JsiiProperty(name: "setPCap", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetPCap\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesSetPCap? SetPCap
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#set_uid Domain#set_uid}
        /// </remarks>
        [JsiiProperty(name: "setUid", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetUid\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesSetUid? SetUid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_admin Domain#sys_admin}
        /// </remarks>
        [JsiiProperty(name: "sysAdmin", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysAdmin\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesSysAdmin? SysAdmin
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_boot Domain#sys_boot}
        /// </remarks>
        [JsiiProperty(name: "sysBoot", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysBoot\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesSysBoot? SysBoot
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_ch_root Domain#sys_ch_root}
        /// </remarks>
        [JsiiProperty(name: "sysChRoot", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysChRoot\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesSysChRoot? SysChRoot
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_log Domain#sys_log}
        /// </remarks>
        [JsiiProperty(name: "sysLog", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysLog\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesSysLog? SysLog
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_module Domain#sys_module}
        /// </remarks>
        [JsiiProperty(name: "sysModule", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysModule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesSysModule? SysModule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_nice Domain#sys_nice}
        /// </remarks>
        [JsiiProperty(name: "sysNice", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysNice\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesSysNice? SysNice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_p_acct Domain#sys_p_acct}
        /// </remarks>
        [JsiiProperty(name: "sysPAcct", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysPAcct\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesSysPAcct? SysPAcct
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_p_trace Domain#sys_p_trace}
        /// </remarks>
        [JsiiProperty(name: "sysPTrace", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysPTrace\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesSysPTrace? SysPTrace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_raw_io Domain#sys_raw_io}
        /// </remarks>
        [JsiiProperty(name: "sysRawIo", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysRawIo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesSysRawIo? SysRawIo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_resource Domain#sys_resource}
        /// </remarks>
        [JsiiProperty(name: "sysResource", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysResource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesSysResource? SysResource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_time Domain#sys_time}
        /// </remarks>
        [JsiiProperty(name: "sysTime", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysTime\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesSysTime? SysTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_tty_cnofig Domain#sys_tty_cnofig}
        /// </remarks>
        [JsiiProperty(name: "sysTtyCnofig", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysTtyCnofig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesSysTtyCnofig? SysTtyCnofig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#wake_alarm Domain#wake_alarm}
        /// </remarks>
        [JsiiProperty(name: "wakeAlarm", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesWakeAlarm\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainFeaturesCapabilitiesWakeAlarm? WakeAlarm
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainFeaturesCapabilities), fullyQualifiedName: "libvirt.domain.DomainFeaturesCapabilities")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeaturesCapabilities
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#audit_control Domain#audit_control}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auditControl", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesAuditControl\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesAuditControl? AuditControl
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesAuditControl?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#audit_write Domain#audit_write}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auditWrite", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesAuditWrite\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesAuditWrite? AuditWrite
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesAuditWrite?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#block_suspend Domain#block_suspend}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blockSuspend", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesBlockSuspend\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesBlockSuspend? BlockSuspend
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesBlockSuspend?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#chown Domain#chown}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "chown", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesChown\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesChown? Chown
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesChown?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dac_override Domain#dac_override}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dacOverride", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesDacOverride\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesDacOverride? DacOverride
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesDacOverride?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dac_read_search Domain#dac_read_search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dacReadSearch", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesDacReadSearch\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesDacReadSearch? DacReadSearch
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesDacReadSearch?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#fowner Domain#fowner}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fowner", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesFowner\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesFowner? Fowner
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesFowner?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#fset_id Domain#fset_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fsetId", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesFsetId\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesFsetId? FsetId
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesFsetId?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ipc_lock Domain#ipc_lock}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipcLock", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesIpcLock\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesIpcLock? IpcLock
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesIpcLock?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ipc_owner Domain#ipc_owner}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipcOwner", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesIpcOwner\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesIpcOwner? IpcOwner
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesIpcOwner?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#kill Domain#kill}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kill", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesKill\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesKill? Kill
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesKill?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#lease Domain#lease}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lease", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesLease\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesLease? Lease
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesLease?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#linux_immutable Domain#linux_immutable}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "linuxImmutable", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesLinuxImmutable\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesLinuxImmutable? LinuxImmutable
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesLinuxImmutable?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mac_admin Domain#mac_admin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "macAdmin", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesMacAdmin\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesMacAdmin? MacAdmin
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesMacAdmin?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mac_override Domain#mac_override}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "macOverride", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesMacOverride\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesMacOverride? MacOverride
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesMacOverride?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mk_nod Domain#mk_nod}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mkNod", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesMkNod\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesMkNod? MkNod
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesMkNod?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#net_admin Domain#net_admin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "netAdmin", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetAdmin\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesNetAdmin? NetAdmin
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesNetAdmin?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#net_bind_service Domain#net_bind_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "netBindService", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetBindService\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesNetBindService? NetBindService
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesNetBindService?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#net_broadcast Domain#net_broadcast}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "netBroadcast", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetBroadcast\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesNetBroadcast? NetBroadcast
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesNetBroadcast?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#net_raw Domain#net_raw}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "netRaw", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesNetRaw\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesNetRaw? NetRaw
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesNetRaw?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#set_f_cap Domain#set_f_cap}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "setFCap", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetFCap\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesSetFCap? SetFCap
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesSetFCap?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#set_gid Domain#set_gid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "setGid", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetGid\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesSetGid? SetGid
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesSetGid?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#set_p_cap Domain#set_p_cap}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "setPCap", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetPCap\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesSetPCap? SetPCap
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesSetPCap?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#set_uid Domain#set_uid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "setUid", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSetUid\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesSetUid? SetUid
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesSetUid?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_admin Domain#sys_admin}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sysAdmin", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysAdmin\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesSysAdmin? SysAdmin
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesSysAdmin?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_boot Domain#sys_boot}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sysBoot", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysBoot\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesSysBoot? SysBoot
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesSysBoot?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_ch_root Domain#sys_ch_root}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sysChRoot", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysChRoot\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesSysChRoot? SysChRoot
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesSysChRoot?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_log Domain#sys_log}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sysLog", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysLog\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesSysLog? SysLog
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesSysLog?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_module Domain#sys_module}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sysModule", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysModule\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesSysModule? SysModule
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesSysModule?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_nice Domain#sys_nice}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sysNice", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysNice\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesSysNice? SysNice
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesSysNice?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_p_acct Domain#sys_p_acct}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sysPAcct", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysPAcct\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesSysPAcct? SysPAcct
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesSysPAcct?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_p_trace Domain#sys_p_trace}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sysPTrace", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysPTrace\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesSysPTrace? SysPTrace
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesSysPTrace?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_raw_io Domain#sys_raw_io}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sysRawIo", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysRawIo\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesSysRawIo? SysRawIo
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesSysRawIo?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_resource Domain#sys_resource}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sysResource", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysResource\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesSysResource? SysResource
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesSysResource?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_time Domain#sys_time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sysTime", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysTime\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesSysTime? SysTime
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesSysTime?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sys_tty_cnofig Domain#sys_tty_cnofig}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sysTtyCnofig", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesSysTtyCnofig\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesSysTtyCnofig? SysTtyCnofig
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesSysTtyCnofig?>();
            }

            /// <summary>Configures inclusion of the `wake_alarm` capability entry, indicating whether the guest can schedule wake-up alarms that may power on or resume the virtual machine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#wake_alarm Domain#wake_alarm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wakeAlarm", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesCapabilitiesWakeAlarm\"}", isOptional: true)]
            public libvirt.Domain.IDomainFeaturesCapabilitiesWakeAlarm? WakeAlarm
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainFeaturesCapabilitiesWakeAlarm?>();
            }
        }
    }
}
