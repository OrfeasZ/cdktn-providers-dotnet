using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainCpuNumaInterconnectsBandwidths), fullyQualifiedName: "libvirt.domain.DomainCpuNumaInterconnectsBandwidths")]
    public interface IDomainCpuNumaInterconnectsBandwidths
    {
        /// <summary>Sets the ID of the initiator NUMA cell for this bandwidth entry;</summary>
        /// <remarks>
        /// value is required and must match an existing NUMA cell ID.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#initiator Domain#initiator}
        /// </remarks>
        [JsiiProperty(name: "initiator", typeJson: "{\"primitive\":\"number\"}")]
        double Initiator
        {
            get;
        }

        /// <summary>Sets the ID of the target NUMA cell whose link from the initiator is being described;</summary>
        /// <remarks>
        /// value is required and must match an existing NUMA cell ID.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#target Domain#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"number\"}")]
        double Target
        {
            get;
        }

        /// <summary>Sets the bandwidth type being described (for example read, write, or aggregate), as a user‑provided string understood by the hypervisor.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Sets the unit of the bandwidth value, such as "MB/s";</summary>
        /// <remarks>
        /// value is required and must be a libvirt‑supported bandwidth unit.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#unit Domain#unit}
        /// </remarks>
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
        string Unit
        {
            get;
        }

        /// <summary>Sets the numeric bandwidth for the interconnect between the initiator and target cells in the given unit;</summary>
        /// <remarks>
        /// value is required and user‑provided (e.g. 500 for 500 MB/s).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#value Domain#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        double Value
        {
            get;
        }

        /// <summary>Optionally associates the bandwidth measurement with a specific memory side cache level or instance; value is user‑provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cache Domain#cache}
        /// </remarks>
        [JsiiProperty(name: "cache", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Cache
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainCpuNumaInterconnectsBandwidths), fullyQualifiedName: "libvirt.domain.DomainCpuNumaInterconnectsBandwidths")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainCpuNumaInterconnectsBandwidths
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the ID of the initiator NUMA cell for this bandwidth entry;</summary>
            /// <remarks>
            /// value is required and must match an existing NUMA cell ID.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#initiator Domain#initiator}
            /// </remarks>
            [JsiiProperty(name: "initiator", typeJson: "{\"primitive\":\"number\"}")]
            public double Initiator
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Sets the ID of the target NUMA cell whose link from the initiator is being described;</summary>
            /// <remarks>
            /// value is required and must match an existing NUMA cell ID.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#target Domain#target}
            /// </remarks>
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"number\"}")]
            public double Target
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Sets the bandwidth type being described (for example read, write, or aggregate), as a user‑provided string understood by the hypervisor.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the unit of the bandwidth value, such as "MB/s";</summary>
            /// <remarks>
            /// value is required and must be a libvirt‑supported bandwidth unit.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#unit Domain#unit}
            /// </remarks>
            [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
            public string Unit
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the numeric bandwidth for the interconnect between the initiator and target cells in the given unit;</summary>
            /// <remarks>
            /// value is required and user‑provided (e.g. 500 for 500 MB/s).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#value Domain#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
            public double Value
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Optionally associates the bandwidth measurement with a specific memory side cache level or instance; value is user‑provided.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cache Domain#cache}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cache", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Cache
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
