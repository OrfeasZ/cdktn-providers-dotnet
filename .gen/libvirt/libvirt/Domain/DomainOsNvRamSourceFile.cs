using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainOsNvRamSourceFile")]
    public class DomainOsNvRamSourceFile : libvirt.Domain.IDomainOsNvRamSourceFile
    {
        /// <summary>Sets the name of an fdgroup whose pre-opened file descriptor is used for this backing store instead of opening the file path directly;</summary>
        /// <remarks>
        /// value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#fd_group Domain#fd_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fdGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FdGroup
        {
            get;
            set;
        }

        /// <summary>Sets the absolute path on the host to the backing file used as the source for this mirrored disk (for example, /var/lib/libvirt/images/base.qcow2).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? File
        {
            get;
            set;
        }

        private object? _secLabel;

        /// <summary>Configures an explicit security label for the file backing store, overriding default security driver labeling for this file.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sec_label Domain#sec_label}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainOsNvRamSourceFileSecLabel" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainOsNvRamSourceFileSecLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SecLabel
        {
            get => _secLabel;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainOsNvRamSourceFileSecLabel[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainOsNvRamSourceFileSecLabel).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secLabel = value;
            }
        }
    }
}
