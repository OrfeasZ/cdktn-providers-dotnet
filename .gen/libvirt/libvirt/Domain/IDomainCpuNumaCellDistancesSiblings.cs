using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainCpuNumaCellDistancesSiblings), fullyQualifiedName: "libvirt.domain.DomainCpuNumaCellDistancesSiblings")]
    public interface IDomainCpuNumaCellDistancesSiblings
    {
        /// <summary>Reports the sibling NUMA cell ID that this distance entry refers to;</summary>
        /// <remarks>
        /// this value is computed from the configuration and not set by the user.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
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

        /// <summary>Sets the relative NUMA distance (an integer cost metric) from this cell to the referenced sibling cell;</summary>
        /// <remarks>
        /// value is user‑provided, e.g. 10 for local, 20 for remote.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#value Domain#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        double Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainCpuNumaCellDistancesSiblings), fullyQualifiedName: "libvirt.domain.DomainCpuNumaCellDistancesSiblings")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainCpuNumaCellDistancesSiblings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Reports the sibling NUMA cell ID that this distance entry refers to;</summary>
            /// <remarks>
            /// this value is computed from the configuration and not set by the user.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
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

            /// <summary>Sets the relative NUMA distance (an integer cost metric) from this cell to the referenced sibling cell;</summary>
            /// <remarks>
            /// value is user‑provided, e.g. 10 for local, 20 for remote.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#value Domain#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
            public double Value
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
