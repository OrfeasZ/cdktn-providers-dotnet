using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainOsNvRamSourceCtl")]
    public class DomainOsNvRamSourceCtl : libvirt.Domain.IDomainOsNvRamSourceCtl
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dev Domain#dev}.</summary>
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}")]
        public string Dev
        {
            get;
            set;
        }
    }
}
