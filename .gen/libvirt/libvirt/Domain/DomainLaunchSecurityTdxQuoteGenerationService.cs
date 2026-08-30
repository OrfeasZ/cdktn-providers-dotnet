using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainLaunchSecurityTdxQuoteGenerationService")]
    public class DomainLaunchSecurityTdxQuoteGenerationService : libvirt.Domain.IDomainLaunchSecurityTdxQuoteGenerationService
    {
        /// <summary>Sets the path used by the TDX quote generation service (for example, a socket or device path) for obtaining attestation quotes;</summary>
        /// <remarks>
        /// value is a user-provided string.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }
    }
}
