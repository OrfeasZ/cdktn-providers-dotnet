using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesFilesystemsSource")]
    public class DomainDevicesFilesystemsSource : libvirt.Domain.IDomainDevicesFilesystemsSource
    {
        /// <summary>Selects a host directory to be exposed via a bind-mount–style filesystem source, used when `type="mount"` and `accessmode`/`source` semantics require an existing directory.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#bind Domain#bind}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bind", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceBind\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesFilesystemsSourceBind? Bind
        {
            get;
            set;
        }

        /// <summary>Selects a host block device node as the filesystem source, used for block-backed filesystems.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#block Domain#block}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceBlock\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesFilesystemsSourceBlock? Block
        {
            get;
            set;
        }

        /// <summary>Selects a regular host file (for example an image or archive) as the filesystem source.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceFile\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesFilesystemsSourceFile? File
        {
            get;
            set;
        }

        /// <summary>Selects an existing host mount point or socket as the filesystem source, typically used for 9p/virtio-fs style exports.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mount Domain#mount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mount", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceMount\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesFilesystemsSourceMount? Mount
        {
            get;
            set;
        }

        /// <summary>Selects a RAM-backed filesystem source that uses host memory only, configured by `usage` and optional `units`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ram Domain#ram}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ram", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceRam\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesFilesystemsSourceRam? Ram
        {
            get;
            set;
        }

        /// <summary>Selects a template-based source for the filesystem, where the actual contents are derived from a template definition;</summary>
        /// <remarks>
        /// the specific semantics and value are user-provided.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#template Domain#template}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceTemplate\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesFilesystemsSourceTemplate? Template
        {
            get;
            set;
        }

        /// <summary>Enables using a managed storage volume as the filesystem source instead of a host path, referencing a volume from a libvirt storage pool.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#volume Domain#volume}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volume", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsSourceVolume\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesFilesystemsSourceVolume? Volume
        {
            get;
            set;
        }
    }
}
