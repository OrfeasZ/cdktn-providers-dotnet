using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesSoundsAudio), fullyQualifiedName: "libvirt.domain.DomainDevicesSoundsAudio")]
    public interface IDomainDevicesSoundsAudio
    {
        /// <summary>Exposes the numeric ID of the audio backend instance bound to this sound device;</summary>
        /// <remarks>
        /// this is computed from the audio backend configuration and not set by the user.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#audio-backends">https://libvirt.org/formatdomain.html#audio-backends</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id Domain#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        double Id
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesSoundsAudio), fullyQualifiedName: "libvirt.domain.DomainDevicesSoundsAudio")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesSoundsAudio
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Exposes the numeric ID of the audio backend instance bound to this sound device;</summary>
            /// <remarks>
            /// this is computed from the audio backend configuration and not set by the user.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#audio-backends">https://libvirt.org/formatdomain.html#audio-backends</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id Domain#id}
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
