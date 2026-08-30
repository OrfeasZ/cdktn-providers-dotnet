using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDefaultIoThread), fullyQualifiedName: "libvirt.domain.DomainDefaultIoThread")]
    public interface IDomainDefaultIoThread
    {
        /// <summary>Sets the maximum number of threads in the default IOThread pool;</summary>
        /// <remarks>
        /// value is user-provided and must be a non‑negative integer.
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

        /// <summary>Sets the minimum number of threads in the default IOThread pool;</summary>
        /// <remarks>
        /// value is user-provided and must be a non‑negative integer not greater than pool_max.
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

        [JsiiTypeProxy(nativeType: typeof(IDomainDefaultIoThread), fullyQualifiedName: "libvirt.domain.DomainDefaultIoThread")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDefaultIoThread
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the maximum number of threads in the default IOThread pool;</summary>
            /// <remarks>
            /// value is user-provided and must be a non‑negative integer.
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

            /// <summary>Sets the minimum number of threads in the default IOThread pool;</summary>
            /// <remarks>
            /// value is user-provided and must be a non‑negative integer not greater than pool_max.
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
