using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesVirtualPort")]
    public class DomainDevicesInterfacesVirtualPort : libvirt.Domain.IDomainDevicesInterfacesVirtualPort
    {
        /// <summary>Provides backend-specific parameter set for the virtual port profile;</summary>
        /// <remarks>
        /// concrete attributes depend on the underlying virtual switch or network driver.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#params Domain#params}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "params", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortParams\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesInterfacesVirtualPortParams? Params
        {
            get;
            set;
        }
    }
}
