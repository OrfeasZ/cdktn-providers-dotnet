using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesSourceVhostUserChardevQemuVdAgentMouse), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceVhostUserChardevQemuVdAgentMouse")]
    public interface IDomainDevicesInterfacesSourceVhostUserChardevQemuVdAgentMouse
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesSourceVhostUserChardevQemuVdAgentMouse), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesSourceVhostUserChardevQemuVdAgentMouse")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesSourceVhostUserChardevQemuVdAgentMouse
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}.</summary>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
