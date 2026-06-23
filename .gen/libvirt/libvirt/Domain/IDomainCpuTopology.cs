using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainCpuTopology), fullyQualifiedName: "libvirt.domain.DomainCpuTopology")]
    public interface IDomainCpuTopology
    {
        /// <summary>Sets the number of CPU clusters per die in the guest CPU topology;</summary>
        /// <remarks>
        /// value is a positive integer and is optional.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#clusters Domain#clusters}
        /// </remarks>
        [JsiiProperty(name: "clusters", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Clusters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the number of CPU cores per socket (or per cluster, depending on machine type) in the guest;</summary>
        /// <remarks>
        /// value is a positive integer and should multiply with sockets, dies, clusters, and threads to match the vCPU count.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cores Domain#cores}
        /// </remarks>
        [JsiiProperty(name: "cores", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Cores
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the number of CPU dies per socket in the guest; value is a positive integer and is optional.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dies Domain#dies}
        /// </remarks>
        [JsiiProperty(name: "dies", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Dies
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the number of CPU sockets in the guest;</summary>
        /// <remarks>
        /// value is a positive integer and participates in the overall vCPU count calculation.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sockets Domain#sockets}
        /// </remarks>
        [JsiiProperty(name: "sockets", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Sockets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the number of hardware threads (hyper-threads) per core in the guest;</summary>
        /// <remarks>
        /// value is a positive integer (commonly 1 or 2).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#threads Domain#threads}
        /// </remarks>
        [JsiiProperty(name: "threads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Threads
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainCpuTopology), fullyQualifiedName: "libvirt.domain.DomainCpuTopology")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainCpuTopology
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the number of CPU clusters per die in the guest CPU topology;</summary>
            /// <remarks>
            /// value is a positive integer and is optional.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#clusters Domain#clusters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clusters", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Clusters
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the number of CPU cores per socket (or per cluster, depending on machine type) in the guest;</summary>
            /// <remarks>
            /// value is a positive integer and should multiply with sockets, dies, clusters, and threads to match the vCPU count.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cores Domain#cores}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cores", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Cores
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the number of CPU dies per socket in the guest; value is a positive integer and is optional.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dies Domain#dies}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dies", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Dies
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the number of CPU sockets in the guest;</summary>
            /// <remarks>
            /// value is a positive integer and participates in the overall vCPU count calculation.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sockets Domain#sockets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sockets", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Sockets
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the number of hardware threads (hyper-threads) per core in the guest;</summary>
            /// <remarks>
            /// value is a positive integer (commonly 1 or 2).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#threads Domain#threads}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "threads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Threads
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
