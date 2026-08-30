using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesSoundsCodec), fullyQualifiedName: "libvirt.domain.DomainDevicesSoundsCodec")]
    public interface IDomainDevicesSoundsCodec
    {
        /// <summary>Sets the audio codec type used by the sound device (for example, a specific codec profile or format string supported by the chosen sound model).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesSoundsCodec), fullyQualifiedName: "libvirt.domain.DomainDevicesSoundsCodec")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesSoundsCodec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the audio codec type used by the sound device (for example, a specific codec profile or format string supported by the chosen sound model).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
