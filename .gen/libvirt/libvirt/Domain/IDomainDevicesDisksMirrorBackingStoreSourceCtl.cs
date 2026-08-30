using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksMirrorBackingStoreSourceCtl), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceCtl")]
    public interface IDomainDevicesDisksMirrorBackingStoreSourceCtl
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dev Domain#dev}.</summary>
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}")]
        string Dev
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksMirrorBackingStoreSourceCtl), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceCtl")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceCtl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dev Domain#dev}.</summary>
            [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}")]
            public string Dev
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
