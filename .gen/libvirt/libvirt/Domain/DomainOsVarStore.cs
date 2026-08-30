using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainOsVarStore")]
    public class DomainOsVarStore : libvirt.Domain.IDomainOsVarStore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#path Domain#path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#template Domain#template}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "template", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Template
        {
            get;
            set;
        }
    }
}
