using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolSourceAdapterParentAddrAddress), fullyQualifiedName: "libvirt.pool.PoolSourceAdapterParentAddrAddress")]
    public interface IPoolSourceAdapterParentAddrAddress
    {
        /// <summary>Sets the PCI bus number of the parent adapter; value is user-provided, typically in decimal (e.g., "0", "3").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#bus Pool#bus}
        /// </remarks>
        [JsiiProperty(name: "bus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Bus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the PCI domain number of the parent adapter; value is user-provided, typically "0" on most systems.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#domain Pool#domain}
        /// </remarks>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Domain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the PCI function number of the parent adapter; value is user-provided, typically 0–7 (e.g., "0").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#function Pool#function}
        /// </remarks>
        [JsiiProperty(name: "function", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Function
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the PCI slot number of the parent adapter; value is user-provided, typically in decimal (e.g., "0", "1", "10").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#slot Pool#slot}
        /// </remarks>
        [JsiiProperty(name: "slot", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Slot
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolSourceAdapterParentAddrAddress), fullyQualifiedName: "libvirt.pool.PoolSourceAdapterParentAddrAddress")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolSourceAdapterParentAddrAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the PCI bus number of the parent adapter; value is user-provided, typically in decimal (e.g., "0", "3").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#bus Pool#bus}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Bus
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the PCI domain number of the parent adapter; value is user-provided, typically "0" on most systems.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#domain Pool#domain}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Domain
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the PCI function number of the parent adapter; value is user-provided, typically 0–7 (e.g., "0").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#function Pool#function}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "function", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Function
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the PCI slot number of the parent adapter; value is user-provided, typically in decimal (e.g., "0", "1", "10").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#slot Pool#slot}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slot", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Slot
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
