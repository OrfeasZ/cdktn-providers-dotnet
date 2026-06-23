using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesAudiosSpice), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosSpice")]
    public interface IDomainDevicesAudiosSpice
    {
        /// <summary>Declares an output (playback) stream for the SPICE audio backend;</summary>
        /// <remarks>
        /// presence of this block enables SPICE audio playback with default stream properties.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSpiceInput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosSpiceInput? Input
        {
            get
            {
                return null;
            }
        }

        /// <summary>Declares an output (playback) stream for the SPICE audio backend;</summary>
        /// <remarks>
        /// presence of this block enables SPICE audio playback with default stream properties.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSpiceOutput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosSpiceOutput? Output
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesAudiosSpice), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosSpice")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesAudiosSpice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Declares an output (playback) stream for the SPICE audio backend;</summary>
            /// <remarks>
            /// presence of this block enables SPICE audio playback with default stream properties.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#input Domain#input}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSpiceInput\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosSpiceInput? Input
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosSpiceInput?>();
            }

            /// <summary>Declares an output (playback) stream for the SPICE audio backend;</summary>
            /// <remarks>
            /// presence of this block enables SPICE audio playback with default stream properties.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#output Domain#output}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosSpiceOutput\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosSpiceOutput? Output
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosSpiceOutput?>();
            }
        }
    }
}
