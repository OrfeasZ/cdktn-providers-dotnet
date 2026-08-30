using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainFeaturesAsyncTeardown")]
    public class DomainFeaturesAsyncTeardown : libvirt.Domain.IDomainFeaturesAsyncTeardown
    {
        /// <summary>Sets whether asynchronous teardown is enabled for the domain;</summary>
        /// <remarks>
        /// valid values are user-provided strings typically treated as "on"/"off" or "yes"/"no" by the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hypervisor-features">https://libvirt.org/formatdomain.html#hypervisor-features</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#enabled Domain#enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Enabled
        {
            get;
            set;
        }
    }
}
