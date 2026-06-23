using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainOsFirmwareInfo), fullyQualifiedName: "libvirt.domain.DomainOsFirmwareInfo")]
    public interface IDomainOsFirmwareInfo
    {
        /// <summary>Configures one or more firmware features to be exposed to the guest firmware/boot environment;</summary>
        /// <remarks>
        /// each entry corresponds to a single feature toggle, with semantics defined by the underlying firmware implementation.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#features Domain#features}
        /// </remarks>
        [JsiiProperty(name: "features", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainOsFirmwareInfoFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Features
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainOsFirmwareInfo), fullyQualifiedName: "libvirt.domain.DomainOsFirmwareInfo")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainOsFirmwareInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures one or more firmware features to be exposed to the guest firmware/boot environment;</summary>
            /// <remarks>
            /// each entry corresponds to a single feature toggle, with semantics defined by the underlying firmware implementation.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#features Domain#features}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "features", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainOsFirmwareInfoFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Features
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
