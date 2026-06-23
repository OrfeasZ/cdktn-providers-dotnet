using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainPmSuspendToDisk), fullyQualifiedName: "libvirt.domain.DomainPmSuspendToDisk")]
    public interface IDomainPmSuspendToDisk
    {
        /// <summary>Controls whether suspend-to-disk (S4) is exposed to the guest; valid values are yes or no.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#power-management">https://libvirt.org/formatdomain.html#power-management</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#enabled Domain#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}")]
        string Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainPmSuspendToDisk), fullyQualifiedName: "libvirt.domain.DomainPmSuspendToDisk")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainPmSuspendToDisk
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls whether suspend-to-disk (S4) is exposed to the guest; valid values are yes or no.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#power-management">https://libvirt.org/formatdomain.html#power-management</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#enabled Domain#enabled}
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}")]
            public string Enabled
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
