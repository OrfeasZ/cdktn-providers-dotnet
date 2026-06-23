using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksDriverIoThreadsIoThreadQueues), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksDriverIoThreadsIoThreadQueues")]
    public interface IDomainDevicesDisksDriverIoThreadsIoThreadQueues
    {
        /// <summary>Reports the identifier of a disk queue associated with this IOThread;</summary>
        /// <remarks>
        /// it is computed and not directly set by the user.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#id Domain#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        double Id
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksDriverIoThreadsIoThreadQueues), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksDriverIoThreadsIoThreadQueues")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksDriverIoThreadsIoThreadQueues
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Reports the identifier of a disk queue associated with this IOThread;</summary>
            /// <remarks>
            /// it is computed and not directly set by the user.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#id Domain#id}
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
