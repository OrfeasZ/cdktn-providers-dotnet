using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsSubsysScsiSourceIscsi), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsi")]
    public interface IDomainDevicesHostdevsSubsysScsiSourceIscsi
    {
        /// <summary>Sets the iSCSI target name (IQN or other target identifier) that provides the LUNs for this SCSI hostdev;</summary>
        /// <remarks>
        /// for example, "iqn.2010-10.org.example:storage.lun1".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Configures CHAP authentication parameters for the iSCSI source backing an assigned SCSI host device;</summary>
        /// <remarks>
        /// include this block only when the target requires authentication.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#auth Domain#auth}
        /// </remarks>
        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiAuth\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiAuth? Auth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the iSCSI target portal settings (address and transport details) for the SCSI hostdev’s backing device.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#host Domain#host}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiHost" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiHost\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Host
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures iSCSI initiator information for the SCSI hostdev, including the initiator IQN used to identify the host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#initiator Domain#initiator}
        /// </remarks>
        [JsiiProperty(name: "initiator", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiInitiator\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiator? Initiator
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsSubsysScsiSourceIscsi), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsi")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsi
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the iSCSI target name (IQN or other target identifier) that provides the LUNs for this SCSI hostdev;</summary>
            /// <remarks>
            /// for example, "iqn.2010-10.org.example:storage.lun1".
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Configures CHAP authentication parameters for the iSCSI source backing an assigned SCSI host device;</summary>
            /// <remarks>
            /// include this block only when the target requires authentication.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#auth Domain#auth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiAuth\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiAuth? Auth
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiAuth?>();
            }

            /// <summary>Configures the iSCSI target portal settings (address and transport details) for the SCSI hostdev’s backing device.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#host Domain#host}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiHost" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "host", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiHost\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Host
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures iSCSI initiator information for the SCSI hostdev, including the initiator IQN used to identify the host.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#initiator Domain#initiator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initiator", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysScsiSourceIscsiInitiator\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiator? Initiator
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesHostdevsSubsysScsiSourceIscsiInitiator?>();
            }
        }
    }
}
