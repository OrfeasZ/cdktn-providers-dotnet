using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksMirrorSourceBlockSecLabel), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorSourceBlockSecLabel")]
    public interface IDomainDevicesDisksMirrorSourceBlockSecLabel
    {
        /// <summary>Sets the explicit security label to apply to the UNIX socket for the EGD RNG backend;</summary>
        /// <remarks>
        /// the value is user-provided (for example, an SELinux context string).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#label Domain#label}
        /// </remarks>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Label
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether application of the security label is skipped for the UNIX socket, using a "yes"/"no" flag equivalent to the seclabel labelskip attribute.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#label_skip Domain#label_skip}
        /// </remarks>
        [JsiiProperty(name: "labelSkip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LabelSkip
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects the security labeling model used for the UNIX socket backing the EGD RNG backend (for example "selinux" or "dac");</summary>
        /// <remarks>
        /// the value is user-provided but should match a supported security driver.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Model
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the security driver is allowed to change (relabel) the UNIX socket for the EGD RNG backend, using a "yes"/"no" flag.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#relabel Domain#relabel}
        /// </remarks>
        [JsiiProperty(name: "relabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Relabel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksMirrorSourceBlockSecLabel), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorSourceBlockSecLabel")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksMirrorSourceBlockSecLabel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the explicit security label to apply to the UNIX socket for the EGD RNG backend;</summary>
            /// <remarks>
            /// the value is user-provided (for example, an SELinux context string).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#label Domain#label}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Label
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether application of the security label is skipped for the UNIX socket, using a "yes"/"no" flag equivalent to the seclabel labelskip attribute.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#label_skip Domain#label_skip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "labelSkip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LabelSkip
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Selects the security labeling model used for the UNIX socket backing the EGD RNG backend (for example "selinux" or "dac");</summary>
            /// <remarks>
            /// the value is user-provided but should match a supported security driver.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Model
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Controls whether the security driver is allowed to change (relabel) the UNIX socket for the EGD RNG backend, using a "yes"/"no" flag.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#relabel Domain#relabel}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "relabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Relabel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
