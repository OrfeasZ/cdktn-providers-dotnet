using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainFeaturesSmm), fullyQualifiedName: "libvirt.domain.DomainFeaturesSmm")]
    public interface IDomainFeaturesSmm
    {
        /// <summary>Controls whether SMM is enabled via a state flag (typically "on" or "off"; the exact accepted values are hypervisor-dependent).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#state Domain#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the size of the TSEG (SMRAM) memory area used by SMM, with the numeric quantity paired with tseg_unit (for example 64 with unit "MiB").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tseg Domain#tseg}
        /// </remarks>
        [JsiiProperty(name: "tseg", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Tseg
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the unit used for the SMM TSEG size, paired with smm.tseg (for example "KiB", "MiB", or "GiB"); the concrete unit string is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tseg_unit Domain#tseg_unit}
        /// </remarks>
        [JsiiProperty(name: "tsegUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TsegUnit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainFeaturesSmm), fullyQualifiedName: "libvirt.domain.DomainFeaturesSmm")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainFeaturesSmm
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls whether SMM is enabled via a state flag (typically "on" or "off"; the exact accepted values are hypervisor-dependent).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#state Domain#state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the size of the TSEG (SMRAM) memory area used by SMM, with the numeric quantity paired with tseg_unit (for example 64 with unit "MiB").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tseg Domain#tseg}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tseg", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Tseg
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Specifies the unit used for the SMM TSEG size, paired with smm.tseg (for example "KiB", "MiB", or "GiB"); the concrete unit string is user-provided.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#tseg_unit Domain#tseg_unit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tsegUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TsegUnit
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
