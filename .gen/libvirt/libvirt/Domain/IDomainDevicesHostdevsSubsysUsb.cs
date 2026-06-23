using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsSubsysUsb), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysUsb")]
    public interface IDomainDevicesHostdevsSubsysUsb
    {
        /// <summary>Sets how the USB host device is identified for passthrough, either by topology (bus/port) or by vendor/product IDs and related options.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysUsbSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesHostdevsSubsysUsbSource? Source
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsSubsysUsb), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysUsb")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsSubsysUsb
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets how the USB host device is identified for passthrough, either by topology (bus/port) or by vendor/product IDs and related options.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysUsbSource\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesHostdevsSubsysUsbSource? Source
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesHostdevsSubsysUsbSource?>();
            }
        }
    }
}
