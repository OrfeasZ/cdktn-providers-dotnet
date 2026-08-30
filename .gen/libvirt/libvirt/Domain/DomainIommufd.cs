using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainIommufd")]
    public class DomainIommufd : libvirt.Domain.IDomainIommufd
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#enabled Domain#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}")]
        public string Enabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#fd_group Domain#fd_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fdGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FdGroup
        {
            get;
            set;
        }
    }
}
