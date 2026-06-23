using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainIoThreadIDsIoThreadsPoll), fullyQualifiedName: "libvirt.domain.DomainIoThreadIDsIoThreadsPoll")]
    public interface IDomainIoThreadIDsIoThreadsPoll
    {
        /// <summary>Sets the per-IOThread poll configuration’s grow threshold, controlling how aggressively the IOThread poll mode ramps up;</summary>
        /// <remarks>
        /// the value is user-provided (typically a non‑negative integer).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#grow Domain#grow}
        /// </remarks>
        [JsiiProperty(name: "grow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Grow
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the maximum polling threshold for the IOThread, limiting how far the poll mode can scale;</summary>
        /// <remarks>
        /// the value is user-provided (typically a non‑negative integer).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#max Domain#max}
        /// </remarks>
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Max
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the per-IOThread poll configuration’s shrink threshold, controlling how quickly the IOThread backs off from poll mode;</summary>
        /// <remarks>
        /// the value is user-provided (typically a non‑negative integer).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#shrink Domain#shrink}
        /// </remarks>
        [JsiiProperty(name: "shrink", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Shrink
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainIoThreadIDsIoThreadsPoll), fullyQualifiedName: "libvirt.domain.DomainIoThreadIDsIoThreadsPoll")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainIoThreadIDsIoThreadsPoll
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the per-IOThread poll configuration’s grow threshold, controlling how aggressively the IOThread poll mode ramps up;</summary>
            /// <remarks>
            /// the value is user-provided (typically a non‑negative integer).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#grow Domain#grow}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Grow
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the maximum polling threshold for the IOThread, limiting how far the poll mode can scale;</summary>
            /// <remarks>
            /// the value is user-provided (typically a non‑negative integer).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#max Domain#max}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Max
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the per-IOThread poll configuration’s shrink threshold, controlling how quickly the IOThread backs off from poll mode;</summary>
            /// <remarks>
            /// the value is user-provided (typically a non‑negative integer).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#shrink Domain#shrink}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shrink", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Shrink
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
