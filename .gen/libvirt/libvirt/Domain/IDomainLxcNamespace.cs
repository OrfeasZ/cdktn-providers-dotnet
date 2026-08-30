using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainLxcNamespace), fullyQualifiedName: "libvirt.domain.DomainLxcNamespace")]
    public interface IDomainLxcNamespace
    {
        /// <summary>Configures sharing of the UTS namespace for the LXC guest instead of creating a private one.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#share_ipc Domain#share_ipc}
        /// </remarks>
        [JsiiProperty(name: "shareIpc", typeJson: "{\"fqn\":\"libvirt.domain.DomainLxcNamespaceShareIpc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainLxcNamespaceShareIpc? ShareIpc
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures sharing of the UTS namespace for the LXC guest instead of creating a private one.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#share_net Domain#share_net}
        /// </remarks>
        [JsiiProperty(name: "shareNet", typeJson: "{\"fqn\":\"libvirt.domain.DomainLxcNamespaceShareNet\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainLxcNamespaceShareNet? ShareNet
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures sharing of the UTS namespace for the LXC guest instead of creating a private one.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#share_uts Domain#share_uts}
        /// </remarks>
        [JsiiProperty(name: "shareUts", typeJson: "{\"fqn\":\"libvirt.domain.DomainLxcNamespaceShareUts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainLxcNamespaceShareUts? ShareUts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainLxcNamespace), fullyQualifiedName: "libvirt.domain.DomainLxcNamespace")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainLxcNamespace
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures sharing of the UTS namespace for the LXC guest instead of creating a private one.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#share_ipc Domain#share_ipc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shareIpc", typeJson: "{\"fqn\":\"libvirt.domain.DomainLxcNamespaceShareIpc\"}", isOptional: true)]
            public libvirt.Domain.IDomainLxcNamespaceShareIpc? ShareIpc
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainLxcNamespaceShareIpc?>();
            }

            /// <summary>Configures sharing of the UTS namespace for the LXC guest instead of creating a private one.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#share_net Domain#share_net}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shareNet", typeJson: "{\"fqn\":\"libvirt.domain.DomainLxcNamespaceShareNet\"}", isOptional: true)]
            public libvirt.Domain.IDomainLxcNamespaceShareNet? ShareNet
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainLxcNamespaceShareNet?>();
            }

            /// <summary>Configures sharing of the UTS namespace for the LXC guest instead of creating a private one.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#share_uts Domain#share_uts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shareUts", typeJson: "{\"fqn\":\"libvirt.domain.DomainLxcNamespaceShareUts\"}", isOptional: true)]
            public libvirt.Domain.IDomainLxcNamespaceShareUts? ShareUts
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainLxcNamespaceShareUts?>();
            }
        }
    }
}
