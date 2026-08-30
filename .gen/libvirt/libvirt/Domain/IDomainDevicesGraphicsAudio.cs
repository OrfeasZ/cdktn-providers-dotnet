using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesGraphicsAudio), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsAudio")]
    public interface IDomainDevicesGraphicsAudio
    {
        /// <summary>Identifies which audio backend definition this graphics device should use;</summary>
        /// <remarks>
        /// when omitted, libvirt may assign or infer an id automatically.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#audio-backends">https://libvirt.org/formatdomain.html#audio-backends</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id Domain#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Id
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesGraphicsAudio), fullyQualifiedName: "libvirt.domain.DomainDevicesGraphicsAudio")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesGraphicsAudio
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifies which audio backend definition this graphics device should use;</summary>
            /// <remarks>
            /// when omitted, libvirt may assign or infer an id automatically.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#audio-backends">https://libvirt.org/formatdomain.html#audio-backends</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id Domain#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Id
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
