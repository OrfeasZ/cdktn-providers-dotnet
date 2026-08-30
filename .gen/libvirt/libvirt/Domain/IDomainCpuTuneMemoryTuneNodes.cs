using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainCpuTuneMemoryTuneNodes), fullyQualifiedName: "libvirt.domain.DomainCpuTuneMemoryTuneNodes")]
    public interface IDomainCpuTuneMemoryTuneNodes
    {
        /// <summary>Sets the memory bandwidth limit for this NUMA node in MB/s; this attribute is required for each node entry.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#bandwidth Domain#bandwidth}
        /// </remarks>
        [JsiiProperty(name: "bandwidth", typeJson: "{\"primitive\":\"number\"}")]
        double Bandwidth
        {
            get;
        }

        /// <summary>Reports the NUMA node ID this memory bandwidth limit applies to;</summary>
        /// <remarks>
        /// this is computed from the host topology and not set by the user.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id Domain#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        double Id
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainCpuTuneMemoryTuneNodes), fullyQualifiedName: "libvirt.domain.DomainCpuTuneMemoryTuneNodes")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainCpuTuneMemoryTuneNodes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the memory bandwidth limit for this NUMA node in MB/s; this attribute is required for each node entry.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#bandwidth Domain#bandwidth}
            /// </remarks>
            [JsiiProperty(name: "bandwidth", typeJson: "{\"primitive\":\"number\"}")]
            public double Bandwidth
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Reports the NUMA node ID this memory bandwidth limit applies to;</summary>
            /// <remarks>
            /// this is computed from the host topology and not set by the user.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-tuning">https://libvirt.org/formatdomain.html#cpu-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id Domain#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
            public double Id
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
