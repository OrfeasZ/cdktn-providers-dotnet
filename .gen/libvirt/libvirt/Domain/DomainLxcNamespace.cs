using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainLxcNamespace")]
    public class DomainLxcNamespace : libvirt.Domain.IDomainLxcNamespace
    {
        /// <summary>Configures sharing of the UTS namespace for the LXC guest instead of creating a private one.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#share_ipc Domain#share_ipc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shareIpc", typeJson: "{\"fqn\":\"libvirt.domain.DomainLxcNamespaceShareIpc\"}", isOptional: true)]
        public libvirt.Domain.IDomainLxcNamespaceShareIpc? ShareIpc
        {
            get;
            set;
        }

        /// <summary>Configures sharing of the UTS namespace for the LXC guest instead of creating a private one.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#share_net Domain#share_net}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shareNet", typeJson: "{\"fqn\":\"libvirt.domain.DomainLxcNamespaceShareNet\"}", isOptional: true)]
        public libvirt.Domain.IDomainLxcNamespaceShareNet? ShareNet
        {
            get;
            set;
        }

        /// <summary>Configures sharing of the UTS namespace for the LXC guest instead of creating a private one.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#share_uts Domain#share_uts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shareUts", typeJson: "{\"fqn\":\"libvirt.domain.DomainLxcNamespaceShareUts\"}", isOptional: true)]
        public libvirt.Domain.IDomainLxcNamespaceShareUts? ShareUts
        {
            get;
            set;
        }
    }
}
