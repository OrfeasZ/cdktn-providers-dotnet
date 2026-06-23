using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainCpuTuneCacheTune), fullyQualifiedName: "libvirt.domain.DomainCpuTuneCacheTune")]
    public interface IDomainCpuTuneCacheTune
    {
        /// <summary>Defines a single cache allocation entry associated with this cache tuning group, describing size, level, and type of cache reserved for a given cell or vCPU set.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cache Domain#cache}
        /// </remarks>
        [JsiiProperty(name: "cache", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneCacheTuneCache\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Cache
        {
            get
            {
                return null;
            }
        }

        /// <summary>Reports an identifier for this cache tuning group as determined by libvirt; this value is computed and not user-settable.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#id Domain#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures one or more performance monitor associations for this cache tuning group (for example, to track usage of the reserved cache region);</summary>
        /// <remarks>
        /// values are user-provided and driver-specific.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#performance-monitoring-events">https://libvirt.org/formatdomain.html#performance-monitoring-events</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#monitor Domain#monitor}
        /// </remarks>
        [JsiiProperty(name: "monitor", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneCacheTuneMonitor\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Monitor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the set of vCPUs whose cache allocation is controlled by this cache tuning entry, as a cpuset-style string (for example, "0-3" or "1,3");</summary>
        /// <remarks>
        /// the value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vcpus Domain#vcpus}
        /// </remarks>
        [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Vcpus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainCpuTuneCacheTune), fullyQualifiedName: "libvirt.domain.DomainCpuTuneCacheTune")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainCpuTuneCacheTune
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines a single cache allocation entry associated with this cache tuning group, describing size, level, and type of cache reserved for a given cell or vCPU set.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cache Domain#cache}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cache", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneCacheTuneCache\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Cache
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Reports an identifier for this cache tuning group as determined by libvirt; this value is computed and not user-settable.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table">https://libvirt.org/formatdomain.html#acpi-heterogeneous-memory-attribute-table</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#id Domain#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures one or more performance monitor associations for this cache tuning group (for example, to track usage of the reserved cache region);</summary>
            /// <remarks>
            /// values are user-provided and driver-specific.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#performance-monitoring-events">https://libvirt.org/formatdomain.html#performance-monitoring-events</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#monitor Domain#monitor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monitor", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuTuneCacheTuneMonitor\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Monitor
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Specifies the set of vCPUs whose cache allocation is controlled by this cache tuning entry, as a cpuset-style string (for example, "0-3" or "1,3");</summary>
            /// <remarks>
            /// the value is user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vcpus Domain#vcpus}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Vcpus
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
