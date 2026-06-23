using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainLaunchSecurityTdxQuoteGenerationService), fullyQualifiedName: "libvirt.domain.DomainLaunchSecurityTdxQuoteGenerationService")]
    public interface IDomainLaunchSecurityTdxQuoteGenerationService
    {
        /// <summary>Sets the path used by the TDX quote generation service (for example, a socket or device path) for obtaining attestation quotes;</summary>
        /// <remarks>
        /// value is a user-provided string.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainLaunchSecurityTdxQuoteGenerationService), fullyQualifiedName: "libvirt.domain.DomainLaunchSecurityTdxQuoteGenerationService")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainLaunchSecurityTdxQuoteGenerationService
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the path used by the TDX quote generation service (for example, a socket or device path) for obtaining attestation quotes;</summary>
            /// <remarks>
            /// value is a user-provided string.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
