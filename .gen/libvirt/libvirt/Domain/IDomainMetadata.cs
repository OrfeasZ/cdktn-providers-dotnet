using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainMetadata), fullyQualifiedName: "libvirt.domain.DomainMetadata")]
    public interface IDomainMetadata
    {
        /// <summary>Provides the raw XML content to store inside the domain’s metadata element;</summary>
        /// <remarks>
        /// this must be well-formed XML and is fully user-defined.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#general-metadata">https://libvirt.org/formatdomain.html#general-metadata</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#xml Domain#xml}
        /// </remarks>
        [JsiiProperty(name: "xml", typeJson: "{\"primitive\":\"string\"}")]
        string Xml
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainMetadata), fullyQualifiedName: "libvirt.domain.DomainMetadata")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainMetadata
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Provides the raw XML content to store inside the domain’s metadata element;</summary>
            /// <remarks>
            /// this must be well-formed XML and is fully user-defined.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#general-metadata">https://libvirt.org/formatdomain.html#general-metadata</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#xml Domain#xml}
            /// </remarks>
            [JsiiProperty(name: "xml", typeJson: "{\"primitive\":\"string\"}")]
            public string Xml
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
