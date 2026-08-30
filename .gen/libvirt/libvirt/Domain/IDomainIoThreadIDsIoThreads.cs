using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainIoThreadIDsIoThreads), fullyQualifiedName: "libvirt.domain.DomainIoThreadIDsIoThreads")]
    public interface IDomainIoThreadIDsIoThreads
    {
        /// <summary>Exposes or sets the numeric ID for this IOThread;</summary>
        /// <remarks>
        /// when omitted it is assigned/computed by libvirt and is treated as read-only in the plan.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
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

        /// <summary>Sets the polling configuration for this IOThread (for example enabling or tuning busy-poll behavior);</summary>
        /// <remarks>
        /// value is user-provided and must be a valid polling specification supported by libvirt/QEMU.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#poll Domain#poll}
        /// </remarks>
        [JsiiProperty(name: "poll", typeJson: "{\"fqn\":\"libvirt.domain.DomainIoThreadIDsIoThreadsPoll\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainIoThreadIDsIoThreadsPoll? Poll
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the maximum size of the IOThread’s internal poll thread pool via thread_pool_max;</summary>
        /// <remarks>
        /// the value is user‑provided (typically a positive integer).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pool_max Domain#pool_max}
        /// </remarks>
        [JsiiProperty(name: "poolMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PoolMax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the minimum size of the IOThread’s internal poll thread pool via thread_pool_min;</summary>
        /// <remarks>
        /// the value is user‑provided (typically a non‑negative integer).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pool_min Domain#pool_min}
        /// </remarks>
        [JsiiProperty(name: "poolMin", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PoolMin
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainIoThreadIDsIoThreads), fullyQualifiedName: "libvirt.domain.DomainIoThreadIDsIoThreads")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainIoThreadIDsIoThreads
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Exposes or sets the numeric ID for this IOThread;</summary>
            /// <remarks>
            /// when omitted it is assigned/computed by libvirt and is treated as read-only in the plan.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
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

            /// <summary>Sets the polling configuration for this IOThread (for example enabling or tuning busy-poll behavior);</summary>
            /// <remarks>
            /// value is user-provided and must be a valid polling specification supported by libvirt/QEMU.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#poll Domain#poll}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "poll", typeJson: "{\"fqn\":\"libvirt.domain.DomainIoThreadIDsIoThreadsPoll\"}", isOptional: true)]
            public libvirt.Domain.IDomainIoThreadIDsIoThreadsPoll? Poll
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainIoThreadIDsIoThreadsPoll?>();
            }

            /// <summary>Sets the maximum size of the IOThread’s internal poll thread pool via thread_pool_max;</summary>
            /// <remarks>
            /// the value is user‑provided (typically a positive integer).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pool_max Domain#pool_max}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "poolMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PoolMax
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the minimum size of the IOThread’s internal poll thread pool via thread_pool_min;</summary>
            /// <remarks>
            /// the value is user‑provided (typically a non‑negative integer).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pool_min Domain#pool_min}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "poolMin", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PoolMin
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
