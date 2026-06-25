using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksMirrorSourceCookies), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorSourceCookies")]
    public interface IDomainDevicesDisksMirrorSourceCookies
    {
        /// <summary>Configures one or more HTTP cookies to be sent when accessing the mirrored backing store over a network protocol that supports cookies (for example, HTTPS or HTTP-based storage).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cookies Domain#cookies}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceCookiesCookies" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "cookies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceCookiesCookies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Cookies
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksMirrorSourceCookies), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorSourceCookies")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksMirrorSourceCookies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures one or more HTTP cookies to be sent when accessing the mirrored backing store over a network protocol that supports cookies (for example, HTTPS or HTTP-based storage).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cookies Domain#cookies}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksMirrorSourceCookiesCookies" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cookies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorSourceCookiesCookies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Cookies
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
