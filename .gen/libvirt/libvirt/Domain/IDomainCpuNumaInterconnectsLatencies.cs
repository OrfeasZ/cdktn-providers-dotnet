using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainCpuNumaInterconnectsLatencies), fullyQualifiedName: "libvirt.domain.DomainCpuNumaInterconnectsLatencies")]
    public interface IDomainCpuNumaInterconnectsLatencies
    {
        /// <summary>Sets the ID of the initiator NUMA cell for this latency entry;</summary>
        /// <remarks>
        /// value is required and must correspond to an existing NUMA cell ID.
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

        /// <summary>Sets the target NUMA cell ID for this latency entry, identifying which remote node this latency measurement applies to;</summary>
        /// <remarks>
        /// value is user-provided and must match an existing NUMA cell index.
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

        /// <summary>Sets the type of latency being described between NUMA cells (for example, read, write, or generic access latency);</summary>
        /// <remarks>
        /// value is user-provided, with allowed tokens defined by the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Sets the numeric latency value for this NUMA interconnect entry, in the unit implied by the chosen type (for example, nanoseconds);</summary>
        /// <remarks>
        /// value is user-provided.
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

        /// <summary>Optionally associates the latency measurement with a specific memory side cache; value is user‑provided.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(IDomainCpuNumaInterconnectsLatencies), fullyQualifiedName: "libvirt.domain.DomainCpuNumaInterconnectsLatencies")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainCpuNumaInterconnectsLatencies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the ID of the initiator NUMA cell for this latency entry;</summary>
            /// <remarks>
            /// value is required and must correspond to an existing NUMA cell ID.
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

            /// <summary>Sets the target NUMA cell ID for this latency entry, identifying which remote node this latency measurement applies to;</summary>
            /// <remarks>
            /// value is user-provided and must match an existing NUMA cell index.
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

            /// <summary>Sets the type of latency being described between NUMA cells (for example, read, write, or generic access latency);</summary>
            /// <remarks>
            /// value is user-provided, with allowed tokens defined by the hypervisor.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the numeric latency value for this NUMA interconnect entry, in the unit implied by the chosen type (for example, nanoseconds);</summary>
            /// <remarks>
            /// value is user-provided.
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

            /// <summary>Optionally associates the latency measurement with a specific memory side cache; value is user‑provided.</summary>
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
