using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainLaunchSecurityTdx")]
    public class DomainLaunchSecurityTdx : libvirt.Domain.IDomainLaunchSecurityTdx
    {
        /// <summary>Sets the TDX mrConfigId measurement value representing the guest configuration identity;</summary>
        /// <remarks>
        /// value is user-provided binary/hex data from the TDX tooling.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mr_config_id Domain#mr_config_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mrConfigId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MrConfigId
        {
            get;
            set;
        }

        /// <summary>Sets the TDX mrOwner measurement value representing the owner of the guest;</summary>
        /// <remarks>
        /// value is user-provided binary/hex data from the TDX tooling.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mr_owner Domain#mr_owner}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mrOwner", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MrOwner
        {
            get;
            set;
        }

        /// <summary>Sets the TDX mrOwnerConfig measurement value describing the owner-specific configuration; value is user-provided binary/hex data from the TDX tooling.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mr_owner_config Domain#mr_owner_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mrOwnerConfig", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MrOwnerConfig
        {
            get;
            set;
        }

        /// <summary>Sets the TDX guest policy bitfield controlling allowed operations (such as debug or migration);</summary>
        /// <remarks>
        /// value is user-provided, typically as an integer or hex string.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#policy Domain#policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Policy
        {
            get;
            set;
        }

        /// <summary>Configures an optional TDX quoteGenerationService, which specifies how attestation quotes are generated for the guest;</summary>
        /// <remarks>
        /// child attributes further describe the service endpoint.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#quote_generation_service Domain#quote_generation_service}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "quoteGenerationService", typeJson: "{\"fqn\":\"libvirt.domain.DomainLaunchSecurityTdxQuoteGenerationService\"}", isOptional: true)]
        public libvirt.Domain.IDomainLaunchSecurityTdxQuoteGenerationService? QuoteGenerationService
        {
            get;
            set;
        }
    }
}
