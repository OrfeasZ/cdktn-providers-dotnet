using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainLaunchSecurity")]
    public class DomainLaunchSecurity : libvirt.Domain.IDomainLaunchSecurity
    {
        private object? _s390Pv;

        /// <summary>Enables s390 protected virtualization (IBM Secure Execution) for the domain when set to true;</summary>
        /// <remarks>
        /// if absent/false, s390‑pv launch security is not configured.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#s390pv Domain#s390pv}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s390Pv", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? S390Pv
        {
            get => _s390Pv;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s390Pv = value;
            }
        }

        /// <summary>Configures AMD SEV launch security parameters for the domain, such as policy, certificates, and reduced physical address bits.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sev Domain#sev}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sev", typeJson: "{\"fqn\":\"libvirt.domain.DomainLaunchSecuritySev\"}", isOptional: true)]
        public libvirt.Domain.IDomainLaunchSecuritySev? Sev
        {
            get;
            set;
        }

        /// <summary>Configures AMD SEV-SNP launch security parameters for the domain, extending SEV with additional integrity and security features;</summary>
        /// <remarks>
        /// the subfields (if any) are user‑provided.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sevsnp Domain#sevsnp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sevsnp", typeJson: "{\"fqn\":\"libvirt.domain.DomainLaunchSecuritySevsnp\"}", isOptional: true)]
        public libvirt.Domain.IDomainLaunchSecuritySevsnp? Sevsnp
        {
            get;
            set;
        }

        /// <summary>Enables Intel TDX launch security configuration for the domain and groups all TDX-specific measurement and policy options;</summary>
        /// <remarks>
        /// presence configures the domain to run as a TDX guest.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tdx Domain#tdx}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tdx", typeJson: "{\"fqn\":\"libvirt.domain.DomainLaunchSecurityTdx\"}", isOptional: true)]
        public libvirt.Domain.IDomainLaunchSecurityTdx? Tdx
        {
            get;
            set;
        }
    }
}
