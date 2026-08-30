using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainOsNvRamSourceVhostUserQemuVdAgentClipBoard), fullyQualifiedName: "libvirt.domain.DomainOsNvRamSourceVhostUserQemuVdAgentClipBoard")]
    public interface IDomainOsNvRamSourceVhostUserQemuVdAgentClipBoard
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#copy_paste Domain#copy_paste}.</summary>
        [JsiiProperty(name: "copyPaste", typeJson: "{\"primitive\":\"string\"}")]
        string CopyPaste
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainOsNvRamSourceVhostUserQemuVdAgentClipBoard), fullyQualifiedName: "libvirt.domain.DomainOsNvRamSourceVhostUserQemuVdAgentClipBoard")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainOsNvRamSourceVhostUserQemuVdAgentClipBoard
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#copy_paste Domain#copy_paste}.</summary>
            [JsiiProperty(name: "copyPaste", typeJson: "{\"primitive\":\"string\"}")]
            public string CopyPaste
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
